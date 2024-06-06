namespace WindowsFormsApp1
{
    partial class FormContracte
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
            this.lv_Contracte = new System.Windows.Forms.ListView();
            this.idContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeCompanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSemnarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataLivrarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeFurnizor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valoareContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procentPenalizare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaPaginaPrincipalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireTotalaDinAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Contracte
            // 
            this.lv_Contracte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idContract,
            this.numeCompanie,
            this.dataSemnarii,
            this.dataLivrarii,
            this.numeFurnizor,
            this.valoareContract,
            this.procentPenalizare});
            this.lv_Contracte.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_Contracte.HideSelection = false;
            this.lv_Contracte.Location = new System.Drawing.Point(12, 121);
            this.lv_Contracte.Name = "lv_Contracte";
            this.lv_Contracte.Size = new System.Drawing.Size(883, 289);
            this.lv_Contracte.TabIndex = 0;
            this.lv_Contracte.UseCompatibleStateImageBehavior = false;
            this.lv_Contracte.View = System.Windows.Forms.View.Details;
            // 
            // idContract
            // 
            this.idContract.Text = "idContract";
            this.idContract.Width = 95;
            // 
            // numeCompanie
            // 
            this.numeCompanie.Text = "numeCompanie";
            this.numeCompanie.Width = 133;
            // 
            // dataSemnarii
            // 
            this.dataSemnarii.Text = "dataSemnarii";
            this.dataSemnarii.Width = 146;
            // 
            // dataLivrarii
            // 
            this.dataLivrarii.Text = "dataLivrarii";
            this.dataLivrarii.Width = 110;
            // 
            // numeFurnizor
            // 
            this.numeFurnizor.Text = "numeFurnizor";
            this.numeFurnizor.Width = 124;
            // 
            // valoareContract
            // 
            this.valoareContract.Text = "valoareContract";
            this.valoareContract.Width = 109;
            // 
            // procentPenalizare
            // 
            this.procentPenalizare.Text = "procentPenalizare";
            this.procentPenalizare.Width = 124;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaContractToolStripMenuItem,
            this.stergeContractToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaContractToolStripMenuItem
            // 
            this.adaugaContractToolStripMenuItem.Name = "adaugaContractToolStripMenuItem";
            this.adaugaContractToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.adaugaContractToolStripMenuItem.Text = "Adauga Contract";
            this.adaugaContractToolStripMenuItem.Click += new System.EventHandler(this.adaugaContractToolStripMenuItem_Click);
            // 
            // stergeContractToolStripMenuItem
            // 
            this.stergeContractToolStripMenuItem.Name = "stergeContractToolStripMenuItem";
            this.stergeContractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeContractToolStripMenuItem.Text = "Sterge Contract";
            this.stergeContractToolStripMenuItem.Click += new System.EventHandler(this.stergeContractToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.iesireToolStripMenuItem,
            this.adaugareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarToolStripMenuItem,
            this.fisierXMLToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // fisierBinarToolStripMenuItem
            // 
            this.fisierBinarToolStripMenuItem.Name = "fisierBinarToolStripMenuItem";
            this.fisierBinarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fisierBinarToolStripMenuItem.Text = "Fisier Binar";
            this.fisierBinarToolStripMenuItem.Click += new System.EventHandler(this.fisierBinarToolStripMenuItem_Click);
            // 
            // fisierXMLToolStripMenuItem
            // 
            this.fisierXMLToolStripMenuItem.Name = "fisierXMLToolStripMenuItem";
            this.fisierXMLToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fisierXMLToolStripMenuItem.Text = "Fisier XML";
            this.fisierXMLToolStripMenuItem.Click += new System.EventHandler(this.fisierXMLToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiLaPaginaPrincipalaToolStripMenuItem,
            this.iesireTotalaDinAplicatieToolStripMenuItem});
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // inapoiLaPaginaPrincipalaToolStripMenuItem
            // 
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Name = "inapoiLaPaginaPrincipalaToolStripMenuItem";
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Text = "Inapoi la pagina principala";
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaPaginaPrincipalaToolStripMenuItem_Click);
            // 
            // iesireTotalaDinAplicatieToolStripMenuItem
            // 
            this.iesireTotalaDinAplicatieToolStripMenuItem.Name = "iesireTotalaDinAplicatieToolStripMenuItem";
            this.iesireTotalaDinAplicatieToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.iesireTotalaDinAplicatieToolStripMenuItem.Text = "Iesire totala din aplicatie";
            this.iesireTotalaDinAplicatieToolStripMenuItem.Click += new System.EventHandler(this.iesireTotalaDinAplicatieToolStripMenuItem_Click);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarToolStripMenuItem1,
            this.fisierXMLToolStripMenuItem1});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // fisierBinarToolStripMenuItem1
            // 
            this.fisierBinarToolStripMenuItem1.Name = "fisierBinarToolStripMenuItem1";
            this.fisierBinarToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.fisierBinarToolStripMenuItem1.Text = "Fisier binar";
            // 
            // fisierXMLToolStripMenuItem1
            // 
            this.fisierXMLToolStripMenuItem1.Name = "fisierXMLToolStripMenuItem1";
            this.fisierXMLToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.fisierXMLToolStripMenuItem1.Text = "Fisier XML";
            // 
            // FormContracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 573);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lv_Contracte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContracte";
            this.Text = "FormContracte";
            this.Load += new System.EventHandler(this.FormContracte_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Contracte;
        private System.Windows.Forms.ColumnHeader idContract;
        private System.Windows.Forms.ColumnHeader numeCompanie;
        private System.Windows.Forms.ColumnHeader dataSemnarii;
        private System.Windows.Forms.ColumnHeader dataLivrarii;
        private System.Windows.Forms.ColumnHeader numeFurnizor;
        private System.Windows.Forms.ColumnHeader valoareContract;
        private System.Windows.Forms.ColumnHeader procentPenalizare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaPaginaPrincipalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireTotalaDinAplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeContractToolStripMenuItem;
    }
}