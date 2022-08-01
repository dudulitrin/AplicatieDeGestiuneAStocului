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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataProduse.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataProduse.Produse);

        }
    }
}
