
namespace Aplicatie_de_gestiune
{
    partial class FormProduseF
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
            this.txtIdProdus = new System.Windows.Forms.TextBox();
            this.produseFurnizateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataProduse = new Aplicatie_de_gestiune.DataProduse();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturaNoua = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateIngredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMIngredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificaFactura = new System.Windows.Forms.Button();
            this.produseFurnizateTableAdapter = new Aplicatie_de_gestiune.DataProduseTableAdapters.ProduseFurnizateTableAdapter();
            this.produseContinutTableAdapter = new Aplicatie_de_gestiune.DataProduseTableAdapters.ProduseContinutTableAdapter();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produseFurnizateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProdus
            // 
            this.txtIdProdus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseFurnizateBindingSource, "IdProdus", true));
            this.txtIdProdus.Location = new System.Drawing.Point(168, 112);
            this.txtIdProdus.Name = "txtIdProdus";
            this.txtIdProdus.Size = new System.Drawing.Size(100, 20);
            this.txtIdProdus.TabIndex = 30;
            // 
            // produseFurnizateBindingSource
            // 
            this.produseFurnizateBindingSource.DataMember = "ProduseFurnizate";
            this.produseFurnizateBindingSource.DataSource = this.dataProduse;
            this.produseFurnizateBindingSource.PositionChanged += new System.EventHandler(this.comenziBindingSource_PositionChanged);
            // 
            // dataProduse
            // 
            this.dataProduse.DataSetName = "DataProduse";
            this.dataProduse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sterge Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // btnFacturaNoua
            // 
            this.btnFacturaNoua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturaNoua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaNoua.Location = new System.Drawing.Point(648, 23);
            this.btnFacturaNoua.Name = "btnFacturaNoua";
            this.btnFacturaNoua.Size = new System.Drawing.Size(88, 49);
            this.btnFacturaNoua.TabIndex = 27;
            this.btnFacturaNoua.Text = "Produs Nou";
            this.btnFacturaNoua.UseVisualStyleBackColor = true;
            this.btnFacturaNoua.Click += new System.EventHandler(this.btnProdusNou_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn1,
            this.ingredientDataGridViewTextBoxColumn,
            this.cantitateIngredientDataGridViewTextBoxColumn,
            this.uMIngredientDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.produseContinutBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(12, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(618, 158);
            this.dataGridView2.TabIndex = 26;
            // 
            // idProdusDataGridViewTextBoxColumn1
            // 
            this.idProdusDataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.Name = "idProdusDataGridViewTextBoxColumn1";
            this.idProdusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            this.ingredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateIngredientDataGridViewTextBoxColumn
            // 
            this.cantitateIngredientDataGridViewTextBoxColumn.DataPropertyName = "CantitateIngredient";
            this.cantitateIngredientDataGridViewTextBoxColumn.HeaderText = "CantitateIngredient";
            this.cantitateIngredientDataGridViewTextBoxColumn.Name = "cantitateIngredientDataGridViewTextBoxColumn";
            this.cantitateIngredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMIngredientDataGridViewTextBoxColumn
            // 
            this.uMIngredientDataGridViewTextBoxColumn.DataPropertyName = "UMIngredient";
            this.uMIngredientDataGridViewTextBoxColumn.HeaderText = "UMIngredient";
            this.uMIngredientDataGridViewTextBoxColumn.Name = "uMIngredientDataGridViewTextBoxColumn";
            this.uMIngredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produseContinutBindingSource
            // 
            this.produseContinutBindingSource.DataMember = "ProduseContinut";
            this.produseContinutBindingSource.DataSource = this.dataProduse;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseFurnizateBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(618, 273);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnModificaFactura
            // 
            this.btnModificaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaFactura.Location = new System.Drawing.Point(648, 78);
            this.btnModificaFactura.Name = "btnModificaFactura";
            this.btnModificaFactura.Size = new System.Drawing.Size(88, 45);
            this.btnModificaFactura.TabIndex = 29;
            this.btnModificaFactura.Text = "Modifica Produs";
            this.btnModificaFactura.UseVisualStyleBackColor = true;
            this.btnModificaFactura.Click += new System.EventHandler(this.btnModificareComanda_Click);
            // 
            // produseFurnizateTableAdapter
            // 
            this.produseFurnizateTableAdapter.ClearBeforeFill = true;
            // 
            // produseContinutTableAdapter
            // 
            this.produseContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Visible = false;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormProduseF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIdProdus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFacturaNoua);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnModificaFactura);
            this.Name = "FormProduseF";
            this.Text = "FormProduseF";
            this.Load += new System.EventHandler(this.FormProduseF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produseFurnizateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdProdus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFacturaNoua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificaFactura;
        private DataProduse dataProduse;
        private System.Windows.Forms.BindingSource produseFurnizateBindingSource;
        private DataProduseTableAdapters.ProduseFurnizateTableAdapter produseFurnizateTableAdapter;
        private System.Windows.Forms.BindingSource produseContinutBindingSource;
        private DataProduseTableAdapters.ProduseContinutTableAdapter produseContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateIngredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMIngredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
    }
}