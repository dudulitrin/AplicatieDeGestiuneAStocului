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
    public partial class FComenziAct : Form
    {
        OleDbDataReader r1;
        OleDbDataReader r2;
        public FComenziAct()
        {
            InitializeComponent();
        }
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;
        ActualizareStoc calculStoc = new ActualizareStoc();
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void completeazaComanda()
        {
            DataRowView current = (DataRowView)bs1.Current;
            idCda = (int)current["IdComanda"];
            txtNrComanda.Text = Convert.ToString(current["NrComanda"]);
            cmbVanzator.Text = current["Nume"].ToString();
            txtTotal.Text = current["Total"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(current["DataComanda"]);
            bs2.MoveFirst();
            dataComandaNoua.ComandaContinutManevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataComandaNoua.ComandaContinutManevraRow r =
                dataComandaNoua.ComandaContinutManevra.NewComandaContinutManevraRow();
                r.NrCrt = Convert.ToInt16(current["NrCrt"]);
                r.DProdus = Convert.ToString(current["DProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.PretVanzare = Convert.ToDecimal(current["PretVanzare"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);

                dataComandaNoua.ComandaContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }


        private void A1()
        {
           //Incarcare DataTable Produse
            produseFurnizateTableAdapter.Fill(dataComandaNoua.ProduseFurnizate);
            //Incarcare DataTable Clienti
            utilizatoriTableAdapter.Fill(dataComandaNoua.Utilizatori);

            // Protectie la modificare
            txtNrComanda.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE COMANDA") completeazaComanda();
            else if (lblOp.Text == "COMANDA NOUA") cmbVanzator.SelectedIndex = -1;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE COMANDA")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "COMANDA NOUA")
            {
                generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                adaugaInregistrariComenziContinut();
                golireCampuri();
            }
        }
        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)comandaContinutManevraBindingSource.Current;
            try { current["NrCrt"] = comandaContinutManevraBindingSource.Position + 1; }
            catch { }
        }
        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)produseFurnizateBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    comandaContinutManevraBindingSource.EndEdit();
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



        private void FComenziAct_Load(object sender, EventArgs e)
        {
            A1();

        }

        private void comandaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
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
            foreach (DataRow r in dataComandaNoua.ComandaContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }
        private void generez_nr_cda()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Comenzi.NrComanda) AS NrMax FROM Comenzi";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrComanda.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbVanzator.Text == "")
            {
                MessageBox.Show("Completati Casier !");
                cmbVanzator.Focus();
                return false;
            }
            // Validare completare continut
            if (comandaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut comanda !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori; DateTime d = dateTimePicker1.Value;
            listaCampuri = "NrComanda, DataComanda, IdVanzator";
            listaValori = txtNrComanda.Text +
            ",#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbVanzator.SelectedValue;
            cmd.CommandText = "Insert into Comenzi(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdComanda From Comenzi Where NrComanda = " +
           txtNrComanda.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariComenziContinut()
        {
            
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            string listaCampuri = "IdComanda, NrCrt, IdProdus, Cantitate, PretVanzare";
            string listaValori;
            int cantitate = 0;
            cmd.CommandText = "Select MAX(NrComanda) FROM Comenzi";
            con.Open();
            rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                txtNrComanda.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            }
            con.Close();

            foreach (DataRow r in dataComandaNoua.ComandaContinutManevra)
            {
                listaValori = idCda + "," + r["NrCrt"] + "," + r["IdProdus"] + "," + r["Cantitate"]
               + "," + r["PretVanzare"];
                cmd.CommandText = "Insert into ComenziContinut(" + listaCampuri + ") " + "Select " +
               listaValori;
                //MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "SELECT IdProdus FROM ProduseContinut WHERE IdProdus="+ r["IdProdus"] + "";
                r1 = cmd.ExecuteReader();
                cantitate = Convert.ToInt32(r["Cantitate"]);
                if (r1.Read())
                {
                    calculStoc.actualizareStoc(r1.GetInt32(0), 3, cantitate);
                }
                con.Close();
            }
        }
        private void golireCampuri()
        {
            txtNrComanda.Text = "";
            cmbVanzator.SelectedIndex = -1;
            txtTotal.Text = "";
            dataComandaNoua.ComandaContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            string clauzaWhere = " Where IdComanda = " + idCda;
            string clauzaSet = "Set DataComanda = " +dateTimePicker1.Value.ToShortDateString() +"," +
                "IdVanzator = " + cmbVanzator.SelectedValue; 

            cmd.CommandText = "Update Comenzi " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void stergeContinut()
        {
            OleDbDataReader r;
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select IdProdus,Cantitate FROM ComenziContinut Where IdComanda = " + txtNrComanda.Text + "";
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                calculStoc.actualizareStoc(r.GetInt32(0), 4, r.GetInt32(1));
            }
            con.Close();

            cmd.CommandText = "Delete from ComenziContinut Where IdComanda = " + idCda;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }



    }
}
