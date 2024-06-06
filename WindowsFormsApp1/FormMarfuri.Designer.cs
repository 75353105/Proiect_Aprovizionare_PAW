namespace WindowsFormsApp1
{
    partial class FormMarfuri
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateInFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preluaraeDateDinFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateInFisierXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareMaterialNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireInfereastraPrincipalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_inapoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_iesireDinAPlicatie = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocDisponibilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretMediuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialeCompaniiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialeCompaniiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiale_CompaniiDataSet = new WindowsFormsApp1.Materiale_CompaniiDataSet();
            this.materiale_CompaniiTableAdapter = new WindowsFormsApp1.Materiale_CompaniiDataSetTableAdapters.Materiale_CompaniiTableAdapter();
            this.lb_suplimentare = new System.Windows.Forms.ListBox();
            this.cms_DateMateriale = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaElementulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeElementulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToataTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_print = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeCompaniiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeCompaniiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiale_CompaniiDataSet)).BeginInit();
            this.cms_DateMateriale.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.optiuniToolStripMenuItem,
            this.iesireInfereastraPrincipalaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateInFisierBinarToolStripMenuItem,
            this.preluaraeDateDinFisierBinarToolStripMenuItem,
            this.salvareDateInFisierXmlToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareDateInFisierBinarToolStripMenuItem
            // 
            this.salvareDateInFisierBinarToolStripMenuItem.Name = "salvareDateInFisierBinarToolStripMenuItem";
            this.salvareDateInFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.salvareDateInFisierBinarToolStripMenuItem.Text = "Salvare date in fisier binar";
            this.salvareDateInFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareDateInFisierBinarToolStripMenuItem_Click);
            // 
            // preluaraeDateDinFisierBinarToolStripMenuItem
            // 
            this.preluaraeDateDinFisierBinarToolStripMenuItem.Name = "preluaraeDateDinFisierBinarToolStripMenuItem";
            this.preluaraeDateDinFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.preluaraeDateDinFisierBinarToolStripMenuItem.Text = "Preluare date din fisier binar";
            this.preluaraeDateDinFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.preluaraeDateDinFisierBinarToolStripMenuItem_Click);
            // 
            // salvareDateInFisierXmlToolStripMenuItem
            // 
            this.salvareDateInFisierXmlToolStripMenuItem.Name = "salvareDateInFisierXmlToolStripMenuItem";
            this.salvareDateInFisierXmlToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.salvareDateInFisierXmlToolStripMenuItem.Text = "Salvare date in fisier xml";
            this.salvareDateInFisierXmlToolStripMenuItem.Click += new System.EventHandler(this.salvareDateInFisierXmlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem1.Text = "Preluare date din fisier xml";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareMaterialNouToolStripMenuItem});
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // adaugareMaterialNouToolStripMenuItem
            // 
            this.adaugareMaterialNouToolStripMenuItem.Name = "adaugareMaterialNouToolStripMenuItem";
            this.adaugareMaterialNouToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.adaugareMaterialNouToolStripMenuItem.Text = "Adaugare material nou";
            this.adaugareMaterialNouToolStripMenuItem.Click += new System.EventHandler(this.adaugareMaterialNouToolStripMenuItem_Click);
            // 
            // iesireInfereastraPrincipalaToolStripMenuItem
            // 
            this.iesireInfereastraPrincipalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_inapoi,
            this.tsmi_iesireDinAPlicatie});
            this.iesireInfereastraPrincipalaToolStripMenuItem.Name = "iesireInfereastraPrincipalaToolStripMenuItem";
            this.iesireInfereastraPrincipalaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireInfereastraPrincipalaToolStripMenuItem.Text = "Iesire";
            // 
            // tsmi_inapoi
            // 
            this.tsmi_inapoi.Name = "tsmi_inapoi";
            this.tsmi_inapoi.Size = new System.Drawing.Size(221, 22);
            this.tsmi_inapoi.Text = "Inapoi la datele companiei";
            this.tsmi_inapoi.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmi_iesireDinAPlicatie
            // 
            this.tsmi_iesireDinAPlicatie.Name = "tsmi_iesireDinAPlicatie";
            this.tsmi_iesireDinAPlicatie.Size = new System.Drawing.Size(221, 22);
            this.tsmi_iesireDinAPlicatie.Text = "Iesire completa din aplicatie";
            this.tsmi_iesireDinAPlicatie.Click += new System.EventHandler(this.tsmi_iesireDinAPlicatie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireMaterialDataGridViewTextBoxColumn,
            this.stocDisponibilDataGridViewTextBoxColumn,
            this.pretMediuDataGridViewTextBoxColumn,
            this.proprietarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialeCompaniiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // denumireMaterialDataGridViewTextBoxColumn
            // 
            this.denumireMaterialDataGridViewTextBoxColumn.DataPropertyName = "denumireMaterial";
            this.denumireMaterialDataGridViewTextBoxColumn.HeaderText = "denumireMaterial";
            this.denumireMaterialDataGridViewTextBoxColumn.Name = "denumireMaterialDataGridViewTextBoxColumn";
            // 
            // stocDisponibilDataGridViewTextBoxColumn
            // 
            this.stocDisponibilDataGridViewTextBoxColumn.DataPropertyName = "stocDisponibil";
            this.stocDisponibilDataGridViewTextBoxColumn.HeaderText = "stocDisponibil";
            this.stocDisponibilDataGridViewTextBoxColumn.Name = "stocDisponibilDataGridViewTextBoxColumn";
            // 
            // pretMediuDataGridViewTextBoxColumn
            // 
            this.pretMediuDataGridViewTextBoxColumn.DataPropertyName = "pretMediu";
            this.pretMediuDataGridViewTextBoxColumn.HeaderText = "pretMediu";
            this.pretMediuDataGridViewTextBoxColumn.Name = "pretMediuDataGridViewTextBoxColumn";
            // 
            // proprietarDataGridViewTextBoxColumn
            // 
            this.proprietarDataGridViewTextBoxColumn.DataPropertyName = "Proprietar";
            this.proprietarDataGridViewTextBoxColumn.HeaderText = "Proprietar";
            this.proprietarDataGridViewTextBoxColumn.Name = "proprietarDataGridViewTextBoxColumn";
            // 
            // materialeCompaniiBindingSource
            // 
            this.materialeCompaniiBindingSource.DataMember = "Materiale_Companii";
            this.materialeCompaniiBindingSource.DataSource = this.materialeCompaniiDataSetBindingSource;
            this.materialeCompaniiBindingSource.CurrentChanged += new System.EventHandler(this.materialeCompaniiBindingSource_CurrentChanged);
            // 
            // materialeCompaniiDataSetBindingSource
            // 
            this.materialeCompaniiDataSetBindingSource.DataSource = this.materiale_CompaniiDataSet;
            this.materialeCompaniiDataSetBindingSource.Position = 0;
            // 
            // materiale_CompaniiDataSet
            // 
            this.materiale_CompaniiDataSet.DataSetName = "Materiale_CompaniiDataSet";
            this.materiale_CompaniiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiale_CompaniiTableAdapter
            // 
            this.materiale_CompaniiTableAdapter.ClearBeforeFill = true;
            // 
            // lb_suplimentare
            // 
            this.lb_suplimentare.FormattingEnabled = true;
            this.lb_suplimentare.Location = new System.Drawing.Point(483, 83);
            this.lb_suplimentare.Name = "lb_suplimentare";
            this.lb_suplimentare.Size = new System.Drawing.Size(305, 147);
            this.lb_suplimentare.TabIndex = 3;
            this.lb_suplimentare.SelectedIndexChanged += new System.EventHandler(this.lb_suplimentare_SelectedIndexChanged);
            this.lb_suplimentare.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_suplimentare_DragDrop);
            this.lb_suplimentare.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_suplimentare_DragEnter);
            this.lb_suplimentare.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_suplimentare_DragOver);
            this.lb_suplimentare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_suplimentare_MouseDown);
            // 
            // cms_DateMateriale
            // 
            this.cms_DateMateriale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaElementulToolStripMenuItem,
            this.stergeElementulToolStripMenuItem,
            this.stergeToataTabelaToolStripMenuItem});
            this.cms_DateMateriale.Name = "cms_DateMateriale";
            this.cms_DateMateriale.Size = new System.Drawing.Size(174, 70);
            this.cms_DateMateriale.Opening += new System.ComponentModel.CancelEventHandler(this.cms_DateMateriale_Opening);
            // 
            // editeazaElementulToolStripMenuItem
            // 
            this.editeazaElementulToolStripMenuItem.Name = "editeazaElementulToolStripMenuItem";
            this.editeazaElementulToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editeazaElementulToolStripMenuItem.Text = "Editeaza elementul";
            this.editeazaElementulToolStripMenuItem.Click += new System.EventHandler(this.editeazaElementulToolStripMenuItem_Click);
            // 
            // stergeElementulToolStripMenuItem
            // 
            this.stergeElementulToolStripMenuItem.Name = "stergeElementulToolStripMenuItem";
            this.stergeElementulToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stergeElementulToolStripMenuItem.Text = "Sterge elementul";
            this.stergeElementulToolStripMenuItem.Click += new System.EventHandler(this.stergeElementulToolStripMenuItem_Click);
            // 
            // stergeToataTabelaToolStripMenuItem
            // 
            this.stergeToataTabelaToolStripMenuItem.Name = "stergeToataTabelaToolStripMenuItem";
            this.stergeToataTabelaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stergeToataTabelaToolStripMenuItem.Text = "Sterge toata tabela";
            this.stergeToataTabelaToolStripMenuItem.Click += new System.EventHandler(this.stergeToataTabelaToolStripMenuItem_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(570, 361);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(111, 51);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Printeaza graifc!";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // FormMarfuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lb_suplimentare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMarfuri";
            this.Text = "FormMarfuri";
            this.Load += new System.EventHandler(this.FormMarfuri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMarfuri_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeCompaniiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeCompaniiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiale_CompaniiDataSet)).EndInit();
            this.cms_DateMateriale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireInfereastraPrincipalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_inapoi;
        private System.Windows.Forms.ToolStripMenuItem tsmi_iesireDinAPlicatie;
        private System.Windows.Forms.ToolStripMenuItem salvareDateInFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preluaraeDateDinFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateInFisierXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materialeCompaniiDataSetBindingSource;
        private Materiale_CompaniiDataSet materiale_CompaniiDataSet;
        private System.Windows.Forms.BindingSource materialeCompaniiBindingSource;
        private Materiale_CompaniiDataSetTableAdapters.Materiale_CompaniiTableAdapter materiale_CompaniiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocDisponibilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretMediuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lb_suplimentare;
        private System.Windows.Forms.ToolStripMenuItem adaugareMaterialNouToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_DateMateriale;
        private System.Windows.Forms.ToolStripMenuItem editeazaElementulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeElementulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToataTabelaToolStripMenuItem;
        private System.Windows.Forms.Button btn_print;
    }
}