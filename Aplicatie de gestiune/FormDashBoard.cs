using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataFacturi.Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter.Fill(this.dataFacturi.Facturi);
            // TODO: This line of code loads data into the 'dataComenzi.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this.dataComenzi.Comenzi);
            textBox1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            

        }
    }
}
