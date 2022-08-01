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
using System.Net;
using System.Diagnostics;


namespace Aplicatie_de_gestiune
{
    public partial class loging : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public loging()
        {
            InitializeComponent();
            
        }

        private void loging_Load(object sender, EventArgs e)
        {
            txtHwid.Text = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            txtHwid.ReadOnly = true;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return;
            }
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola, HWID from Utilizatori " +
            "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return;
                }

                if (txtHwid.Text != rdr.GetString(2))
                {
                    MessageBox.Show("HWID Invalid");
                    txtHwid.Focus();
                    con.Close();
                    return;
                }
                WebClient webClient = new WebClient();

                try
                {
                    if (!webClient.DownloadString("http://dudiito.ga/updatelicenta/update.txt").Contains("1.5.1"))
                    {
                        if (MessageBox.Show("Versiune noua disponibila, doriti sa facem update acum?", "Aplicatie de gestiune", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            using (var client = new WebClient())
                            {
                                Process.Start("UpdateAplicatie.exe");
                                System.Threading.Thread.Sleep(1000);
                                this.Close();
                            }
                    }
                }
                catch
                {

                }
                con.Close();
                this.Hide();
                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                
                return;
            }
           
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return;
            }

        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStart.PerformClick();
            }
        }
    }
}
