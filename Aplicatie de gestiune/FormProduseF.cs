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
    public partial class FormProduseF : Form
    {
        public FormProduseF()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            
        }

        private void comenziBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
                produseContinutBindingSource.Filter = "IdProdus= " + txtIdProdus.Text ;
            }
            catch { }
        }
        private void btnModificareComanda_Click(object sender, EventArgs e)
        {
            FProdusNou f = new FProdusNou();
            f.completeazaComanda(produseFurnizateBindingSource,produseContinutBindingSource);
            f.completeazaTitlu("MODIFICARE PRODUS");
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
            con.ConnectionString = produseFurnizateTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut comanda
            cmd.CommandText = "Delete From Produse Where IdProdus = " + txtIdProdus.Text;
            MessageBox.Show("STERS !");
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Delete From ProduseContinut Where IdProdus = " + txtIdProdus.Text;
            
            cmd.ExecuteNonQuery();
            // Sterg comanda
            cmd.CommandText = "Delete From ProduseFurnizate Where IdProdus = " + txtIdProdus.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
        }

        private void btnProdusNou_Click(object sender, EventArgs e)
        {
            FProdusNou f = new FProdusNou();
            f.ShowDialog();
            refreshGrid();
        }

        private void FormProduseF_Load(object sender, EventArgs e)
        {
            produseContinutTableAdapter.Fill(dataProduse.ProduseContinut);
            produseFurnizateTableAdapter.Fill(dataProduse.ProduseFurnizate);
            refreshGrid();
            try
            {
                produseContinutBindingSource.Filter = "IdProdus= " + txtIdProdus.Text;
            }
            catch { }
        }
    }
}

