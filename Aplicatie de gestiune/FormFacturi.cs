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
    public partial class FormFacturi : Form
    {

        public FormFacturi()
        {
            InitializeComponent();
        }
        private void FormFacturi_Load(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
                facturiContinutBindingSource.Filter = "NrF='" + txtIdFactura.Text+ "'";
            }
            catch { }
        }
        private void refreshGrid()
        {
            this.facturiTableAdapter.Fill(this.dataFacturi.Facturi);
            this.facturiContinutTableAdapter.Fill(this.dataFacturi.FacturiContinut);
        }

        private void comenziBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                facturiContinutBindingSource.Filter = "NrF='" + txtIdFactura.Text+"'";
            }
            catch { }
        }
        private void btnModificareComanda_Click(object sender, EventArgs e)
        {
            FormFacturaNoua f = new FormFacturaNoua();
            f.completeazaComanda(facturiBindingSource, facturiContinutBindingSource);
            f.completeazaTitlu("MODIFICARE COMANDA");
            f.ShowDialog();
            refreshGrid();
        }
        private void btnComandaNoua_Click(object sender, EventArgs e)
        {
            FormFacturaNoua f = new FormFacturaNoua();
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
            con.ConnectionString = facturiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut comanda
            cmd.CommandText = "Delete From FacturiContinut Where NrF = " + "'"+ txtIdFactura.Text+"'";
            MessageBox.Show("STERS !");
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg comanda
            cmd.CommandText = "Delete From Facturi Where NrF = '" + txtIdFactura.Text+ "'"; 
            
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
        }

        private void btnProdusNou_Click(object sender, EventArgs e)
        {
            FormProduse f = new FormProduse();
            f.ShowDialog();
        }
    }
}

