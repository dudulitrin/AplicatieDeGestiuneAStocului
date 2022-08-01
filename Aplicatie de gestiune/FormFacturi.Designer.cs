
namespace Aplicatie_de_gestiune
{
    partial class FormFacturi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataFacturi = new Aplicatie_de_gestiune.DataFacturi();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturiContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFacturaNoua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificaFactura = new System.Windows.Forms.Button();
            this.facturiTableAdapter = new Aplicatie_de_gestiune.DataFacturiTableAdapters.FacturiTableAdapter();
            this.facturiContinutTableAdapter = new Aplicatie_de_gestiune.DataFacturiTableAdapters.FacturiContinutTableAdapter();
            this.btnProdusNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturiBindingSource, "NrF", true));
            this.txtIdFactura.Location = new System.Drawing.Point(428, 92);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 20);
            this.txtIdFactura.TabIndex = 3;
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataMember = "Facturi";
            this.facturiBindingSource.DataSource = this.dataFacturi;
            this.facturiBindingSource.PositionChanged += new System.EventHandler(this.comenziBindingSource_PositionChanged);
            // 
            // dataFacturi
            // 
            this.dataFacturi.DataSetName = "DataFacturi";
            this.dataFacturi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturiContinutBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(618, 273);
            this.dataGridView1.TabIndex = 12;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturiContinutBindingSource
            // 
            this.facturiContinutBindingSource.DataMember = "FacturiContinut";
            this.facturiContinutBindingSource.DataSource = this.dataFacturi;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFDataGridViewTextBoxColumn,
            this.nrFDataGridViewTextBoxColumn,
            this.dataFDataGridViewTextBoxColumn,
            this.dFurnizorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.facturiBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(618, 158);
            this.dataGridView2.TabIndex = 13;
            // 
            // idFDataGridViewTextBoxColumn
            // 
            this.idFDataGridViewTextBoxColumn.DataPropertyName = "IdF";
            this.idFDataGridViewTextBoxColumn.HeaderText = "IdF";
            this.idFDataGridViewTextBoxColumn.Name = "idFDataGridViewTextBoxColumn";
            this.idFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrFDataGridViewTextBoxColumn
            // 
            this.nrFDataGridViewTextBoxColumn.DataPropertyName = "NrF";
            this.nrFDataGridViewTextBoxColumn.HeaderText = "NrF";
            this.nrFDataGridViewTextBoxColumn.Name = "nrFDataGridViewTextBoxColumn";
            this.nrFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFDataGridViewTextBoxColumn
            // 
            this.dataFDataGridViewTextBoxColumn.DataPropertyName = "DataF";
            this.dataFDataGridViewTextBoxColumn.HeaderText = "DataF";
            this.dataFDataGridViewTextBoxColumn.Name = "dataFDataGridViewTextBoxColumn";
            this.dataFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            this.dFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
            this.idFurnizorDataGridViewTextBoxColumn.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.Name = "idFurnizorDataGridViewTextBoxColumn";
            this.idFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnFacturaNoua
            // 
            this.btnFacturaNoua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturaNoua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaNoua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFacturaNoua.Location = new System.Drawing.Point(648, 23);
            this.btnFacturaNoua.Name = "btnFacturaNoua";
            this.btnFacturaNoua.Size = new System.Drawing.Size(88, 49);
            this.btnFacturaNoua.TabIndex = 14;
            this.btnFacturaNoua.Text = "Factura Noua";
            this.btnFacturaNoua.UseVisualStyleBackColor = true;
            this.btnFacturaNoua.Click += new System.EventHandler(this.btnComandaNoua_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sterge Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // btnModificaFactura
            // 
            this.btnModificaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaFactura.Location = new System.Drawing.Point(648, 78);
            this.btnModificaFactura.Name = "btnModificaFactura";
            this.btnModificaFactura.Size = new System.Drawing.Size(88, 45);
            this.btnModificaFactura.TabIndex = 16;
            this.btnModificaFactura.Text = "Modifica Factura";
            this.btnModificaFactura.UseVisualStyleBackColor = true;
            this.btnModificaFactura.Click += new System.EventHandler(this.btnModificareComanda_Click);
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // facturiContinutTableAdapter
            // 
            this.facturiContinutTableAdapter.ClearBeforeFill = true;
            // 
            // btnProdusNou
            // 
            this.btnProdusNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdusNou.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusNou.Location = new System.Drawing.Point(648, 396);
            this.btnProdusNou.Name = "btnProdusNou";
            this.btnProdusNou.Size = new System.Drawing.Size(88, 53);
            this.btnProdusNou.TabIndex = 17;
            this.btnProdusNou.Text = "Produs Nou";
            this.btnProdusNou.UseVisualStyleBackColor = true;
            this.btnProdusNou.Click += new System.EventHandler(this.btnProdusNou_Click);
            // 
            // FormFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 459);
            this.Controls.Add(this.btnProdusNou);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnModificaFactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFacturaNoua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIdFactura);
            this.Name = "FormFacturi";
            this.Text = "FormFacturi";
            this.Load += new System.EventHandler(this.FormFacturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataFacturi dataFacturi;
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private DataFacturiTableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facturiContinutBindingSource;
        private DataFacturiTableAdapters.FacturiContinutTableAdapter facturiContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFacturaNoua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificaFactura;
        private System.Windows.Forms.Button btnProdusNou;
    }
}