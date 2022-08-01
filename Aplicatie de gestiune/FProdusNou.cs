using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Aplicatie_de_gestiune
{
    public partial class FProdusNou : Form
    {
        private int idprodus = 0;
        public FProdusNou()
        {
            InitializeComponent();
        }
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public BindingSource bs1;
        public BindingSource bs2;

        private void FProdusNou_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataProduse.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataProduse.Produse);
            A1();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        public void completeazaComanda(BindingSource bs1, BindingSource bs2)
        {
            DataRowView current;
            current = (DataRowView)bs1.Current;
            txtNumeProdus.Text = Convert.ToString(current["DProdus"]);
            txtUM.Text = Convert.ToString(current["UM"]);

            bs2.MoveFirst();
            dataProduse.Manevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataProduse.ManevraRow r = dataProduse.Manevra.NewManevraRow();
                r.Nrc = Convert.ToInt16(current["Nrc"]);
                r.Ingredient = Convert.ToString(current["Ingredient"]);
                r.UM = Convert.ToString(current["UMIngredient"]);
                r.Cantitate = Convert.ToDecimal(current["CantitateIngredient"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);

                dataProduse.Manevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }
        private void A1()
        {
            //Incarcare DataTable Produse
            this.produseTableAdapter.Fill(this.dataProduse.Produse);

            // Protectie la modificare
            nrcDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE PRODUS")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariFacturiContinut();
                this.Close();

            }
            else if (lblOp.Text == "PRODUS NOU")
            {
                adaugaInregistrareFacturi();
                adaugaInregistrariFacturiContinut();
                golireCampuri();
            }
        }
        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)manevraBindingSource.Current;
            try { current["Nrc"] = manevraBindingSource.Position + 1; }
            catch { }
        }
        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)produseBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[4].Value = current["IdProdus"];
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    manevraBindingSource.EndEdit();
                }
            }
            catch { }
        }
        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }
        private void facturiContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private bool validareCampuriObligatorii()
        {
            if (txtNumeProdus.Text == "")
            {
                MessageBox.Show("Completati numele produsului !");
                txtNumeProdus.Focus();
                return false;
            }
            if (manevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut produs !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareFacturi()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            

            string listaCampuri;
            string listaValori; 
            listaCampuri = "DProdus, UM, Pret";
            listaValori = "'" + txtNumeProdus.Text +
            "','"+ txtUM.Text +"'," + textBox1.Text + "";

            cmd.CommandText = "Insert into ProduseFurnizate(" + listaCampuri + ") " +
            "Select " + listaValori;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd.CommandText = "SELECT IdProdus FROM ProduseFurnizate WHERE DProdus='" + txtNumeProdus.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                idprodus = rdr.GetInt32(0);
            }
            con.Close();
            MessageBox.Show("Produs adaugat !");
        }
        private void adaugaInregistrariFacturiContinut()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;

            
            string listaCampuri = "IdProdus, Nrc, Ingredient, CantitateIngredient, UMIngredient";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataProduse.Manevra)
            {
                listaValori = "" + idprodus + "," + r["Nrc"] + ",'" + r["Ingredient"] + "'," + r["Cantitate"] 
               + ",'" + r["UM"] + "'";
                cmd.CommandText = "Insert into ProduseContinut(" + listaCampuri + ") " + "Select " +
               listaValori;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNumeProdus.Text = "";
            txtUM.Text = "";
            dataProduse.Manevra.Clear();
        }
        private void modificaInregistrare()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";

            cmd.Connection = con;
            cmd.CommandText = "SELECT IdProdus FROM ProduseFurnizate WHERE DProdus='" + txtNumeProdus.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                idprodus = rdr.GetInt32(0);
            }
            con.Close();

            string clauzaWhere = " Where DProdus = '" + txtNumeProdus.Text + "'";
            string clauzaSet = "Set DProdus = '" + txtNumeProdus.Text + "'," +
            "UM = '" + txtUM.Text + "'," + "Pret = " + textBox1.Text; 
            cmd.CommandText = "Update ProduseFurnizate " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void stergeContinut()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;

            

            cmd.CommandText = "Delete from ProduseContinut Where IdProdus = " + idprodus ;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}