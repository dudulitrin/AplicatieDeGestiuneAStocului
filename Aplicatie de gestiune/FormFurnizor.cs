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
    public partial class FormFurnizor : Form
    {
        public FormFurnizor()
        {
            InitializeComponent();
        }

        private void FormFurnizor_Load(object sender, EventArgs e)
        {
            A1();
        }
        private void A1()
        {
            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            furnizoriTableAdapter.Fill(dataFurnizori.Furnizori);
            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtIdPersoana
            txtIdFurnizor.ReadOnly = true;
            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";
            //Pozitionare cursor pe primul camp
            txtDFurnizor.Focus();
            // Golire campuri
            golireCampuri();
        }
        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";
            //Çonfigurare(butoane)
            configureazaButoane(true);
            //Protectie componente Panel
            protectiePanel(true);
            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;
                adauga_inregistrare();
                golireCampuri();
                //Pune cursor pe primul camp
                txtDFurnizor.Focus();
                refresh_grid(furnizoriBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(furnizoriBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }
        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;
            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select DFurnizor From Furnizori where CUI=" +
               txtCUI.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Denumire Furnizor deja existent");
                    txtCUI.Focus();
                }
                con.Close();
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select DFurnizor From Furnizori where CUI=" +
               txtCUI.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Denumire Furnizor deja existent");
                    txtCUI.Focus();
                }
                con.Close();
            }
        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";
            //Pozitionare cursor pe primul camp
            txtDFurnizor.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdFurnizor From Facturi where IdFurnizor=" + txtIdFurnizor.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Furnizor referit in tabela Facturi! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            cmd.CommandText = "Delete From Furnizori Where IdFurnizor = " + txtIdFurnizor.Text;
            MessageBox.Show("Furnizorul a fost sters !");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(furnizoriBindingSource.Position);
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                txtDFurnizor.DataBindings.Add("Text", furnizoriBindingSource, "DFurnizor");
                txtCUI.DataBindings.Add("Text", furnizoriBindingSource, "CUI");
                txtAdresa.DataBindings.Add("Text", furnizoriBindingSource, "Adresa");
                txtLocalitate.DataBindings.Add("Text", furnizoriBindingSource, "Localitate");
                txtIdFurnizor.DataBindings.Add("Text", furnizoriBindingSource, "IdFurnizor");
            }
            else
            {
                txtDFurnizor.DataBindings.Clear();
                txtCUI.DataBindings.Clear();
                txtLocalitate.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                txtIdFurnizor.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDFurnizor.ReadOnly = v;
            txtCUI.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtLocalitate.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDFurnizor.Text = "";
            txtIdFurnizor.Text = "";
            txtLocalitate.Text = "";
            txtAdresa.Text = "";
            txtCUI.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtDFurnizor.Text == "")
            {
                MessageBox.Show("Completati Denumire Furnizor !");
                txtDFurnizor.Focus();
                return false;
            }
            if (txtCUI.Text == "")
            {
                MessageBox.Show("Completati CUI !");
                txtCUI.Focus();
                return false;
            }
            if (txtLocalitate.Text == "")
            {
                MessageBox.Show("Completati Localitate !");
                txtLocalitate.Focus();
                return false;
            }
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Completati Adresa !");
                txtAdresa.Focus();
                return false;
            }
            return true;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DFurnizor, CUI, Localitate, Adresa";
            listaValori = "'" + txtDFurnizor.Text + "'" +
            "," + txtCUI.Text +
           ",'" + txtLocalitate.Text + "'" +
            ",'" + txtAdresa.Text + "'";
            cmd.CommandText = "Insert into Furnizori(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show("Furnizorul a fost adaugat !");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            furnizoriTableAdapter.Fill(dataFurnizori.Furnizori);
            furnizoriBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DFurnizor = '" + txtDFurnizor.Text + "'," +
            "CUI = " + txtCUI.Text + "," +
            "Localitate = '" + txtLocalitate.Text + "'," +
            "Adresa = '" + txtAdresa.Text + "'";
            cmd.CommandText = "Update Furnizori Set " + listaSet + " Where IdFurnizor=" +
           txtIdFurnizor.Text;
            MessageBox.Show("Furnizorul a fost modificat !");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }
        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void txtCUI_Leave(object sender, EventArgs e)
        {
            A5(txtCUI);
        }
    }
}
        

