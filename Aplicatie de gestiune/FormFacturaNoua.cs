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
    public partial class FormFacturaNoua : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public BindingSource bs1;
        public BindingSource bs2;
        ActualizareStoc actualizareStoc = new ActualizareStoc();

        public FormFacturaNoua()
        {
            InitializeComponent();
        }
        private void FormFacturaNoua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataFacturaNoua.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataFacturaNoua.Produse);
            // TODO: This line of code loads data into the 'dataFacturaNoua.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.dataFacturaNoua.Furnizori);
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
            txtNrFactura.Text = Convert.ToString(current["NrF"]);
            cmbFurnizor.Text = current["DFurnizor"].ToString();
            txtTotal.Text = current["Total"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(current["DataF"]);
            bs2.MoveFirst();
            dataFacturaNoua.Manevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataFacturaNoua.ManevraRow r =
               dataFacturaNoua.Manevra.NewManevraRow();
                r.Nrc = Convert.ToInt16(current["Nrc"]);
                r.DProdus = Convert.ToString(current["DProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.PretIntrare = Convert.ToDecimal(current["PretIntrare"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);

                dataFacturaNoua.Manevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }
        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(dataFacturaNoua.Produse);
            //Incarcare DataTable Furnizori
            furnizoriTableAdapter.Fill(dataFacturaNoua.Furnizori);

            // Protectie la modificare
            txtTotal.ReadOnly = true;
            nrcDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretIntrareDataGridViewTextBoxColumn.ReadOnly = false;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "FACTURA NOUA") cmbFurnizor.SelectedIndex = -1;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE COMANDA")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariFacturiContinut();
                this.Close();
                
            }
            else if (lblOp.Text == "FACTURA  NOUA")
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
                    //dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    manevraBindingSource.EndEdit();
                    calcTotal();
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
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in dataFacturaNoua.Manevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbFurnizor.Text == "")
            {
                MessageBox.Show("Completati Furnizor !");
                cmbFurnizor.Focus();
                return false;
            }
            // Validare completare continut
            if (manevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut factura !");
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
            string listaValori; DateTime d = dateTimePicker1.Value;
            listaCampuri = "NrF, DataF, IdFurnizor";
            listaValori = "'" + txtNrFactura.Text +
            "',#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbFurnizor.SelectedValue;
            cmd.CommandText = "Insert into Facturi(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show("Factura adaugata !");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void adaugaInregistrariFacturiContinut()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";

            cmd.Connection = con;
            string listaCampuri = "NrF, Nrc, IdProdus, Cantitate, PretIntrare";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataFacturaNoua.Manevra)
            {
                listaValori = "'"+ txtNrFactura.Text + "'," + r["Nrc"] + "," + r["IdProdus"] + "," + r["Cantitate"]
               + "," + r["PretIntrare"];
                cmd.CommandText = "Insert into FacturiContinut(" + listaCampuri + ") " + "Select " +
               listaValori;
                cmd.ExecuteNonQuery();
                actualizareStoc.actualizareStoc(Convert.ToInt32(r["IdProdus"]),1, Convert.ToInt32(r["Cantitate"]));
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrFactura.Text = "";
            cmbFurnizor.SelectedIndex = -1;
            txtTotal.Text = "";
            dataFacturaNoua.Manevra.Clear();
        }
        private void modificaInregistrare()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";

            cmd.Connection = con;
            DateTime d1 = dateTimePicker1.Value;

            string clauzaWhere = " Where NrF = '" + txtNrFactura.Text + "'";
            string clauzaSet = "Set DataF = #" + d1.Month + "/"
            + d1.Day + "/"
            + d1.Year + "#,"
           + "IdFurnizor = " + cmbFurnizor.SelectedValue; cmd.CommandText = "Update Facturi " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void stergeContinut()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdProdus,Cantitate FROM FacturiContinut Where NrF = '" + txtNrFactura.Text + "' ";
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                actualizareStoc.actualizareStoc(rdr.GetInt32(0), 2, rdr.GetInt32(1));
            }
            con.Close();

            cmd.CommandText = "Delete from FacturiContinut Where NrF = '" + txtNrFactura.Text + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            

        }


    }
}
