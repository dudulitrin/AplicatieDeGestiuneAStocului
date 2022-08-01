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
    public partial class FormVanzare : Form
    {
        public FormVanzare()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            this.comenziTableAdapter.Fill(this.dataComenzi.Comenzi);
            this.comenziContinutTableAdapter.Fill(this.dataComenzi.ComenziContinut);
        }

        private void filtreazaDetaliu()
        {
            try
            {
                comenziContinutBindingSource.Filter = "IdComanda=" + txtIdComanda.Text;
            }
            catch { }
        }
        private void FormVanzare_Load(object sender, EventArgs e)
        {
            refreshGrid();
            filtreazaDetaliu();
        }

        private void comenziBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }
        private void btnComandaNoua_Click(object sender, EventArgs e)
        {
            FComenziAct f = new FComenziAct();
            f.completeazaTitlu("COMANDA NOUA");
            f.ShowDialog();
            refreshGrid();
        }
        private void btnModificareComanda_Click(object sender, EventArgs e)
        {
            FComenziAct f = new FComenziAct();
            f.completeazaTitlu("MODIFICARE COMANDA");
            f.bs1 = comenziBindingSource;
            f.bs2 = comenziContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }
        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = comenziTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut comanda
            cmd.CommandText = "Delete From ComenziContinut Where IdComanda = " + txtIdComanda.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
           // Sterg comanda
            cmd.CommandText = "Delete From Comenzi Where IdComanda = " + txtIdComanda.Text;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();
        } 
    }
}

