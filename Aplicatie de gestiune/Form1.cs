using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace Aplicatie_de_gestiune
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private Form activeForm = null;
        public void deschideFormCopil(Form formCopil)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formCopil;
            formCopil.TopLevel = false;
            formCopil.FormBorderStyle = FormBorderStyle.None;
            formCopil.Dock = DockStyle.Fill;
            panelTata.Controls.Add(formCopil);
            panelTata.Tag = formCopil;
            formCopil.BringToFront();
            formCopil.Show();
            
        }
        public void parinte2()
        {
            deschideFormCopil(new FormFacturi());
        }
        public void deschideFormCopil2(Form formCopil)
        {
            formCopil.TopLevel = false;
            formCopil.FormBorderStyle = FormBorderStyle.None;
            formCopil.Dock = DockStyle.Fill;
            panelTata.Controls.Add(formCopil);
            panelTata.Tag = formCopil;
            formCopil.BringToFront();
            formCopil.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormDashBoard());
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormProduseF());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormStock());
        }

        public void btnFacturi_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormFacturi());
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormVanzare());
        }


        private void btnFurnizor_Click(object sender, EventArgs e)
        {
            deschideFormCopil(new FormFurnizor());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}