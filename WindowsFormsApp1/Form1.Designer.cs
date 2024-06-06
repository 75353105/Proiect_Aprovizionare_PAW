namespace WindowsFormsApp1
{
    partial class FormCompanii
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veziMărfurileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziMarfurileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preluareDateBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preluareDateXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireDinAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Companii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tv_Furnizori = new System.Windows.Forms.TreeView();
            this.pb_SigleCompanii = new System.Windows.Forms.PictureBox();
            this.userControlContract1 = new WindowsFormsApp1.UserControlContract();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SigleCompanii)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziMărfurileToolStripMenuItem,
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.iesireDinAplicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veziMărfurileToolStripMenuItem
            // 
            this.veziMărfurileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziMarfurileToolStripMenuItem});
            this.veziMărfurileToolStripMenuItem.Name = "veziMărfurileToolStripMenuItem";
            this.veziMărfurileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.veziMărfurileToolStripMenuItem.Text = "Marfuri";
            this.veziMărfurileToolStripMenuItem.Click += new System.EventHandler(this.veziMărfurileToolStripMenuItem_Click);
            // 
            // veziMarfurileToolStripMenuItem
            // 
            this.veziMarfurileToolStripMenuItem.Name = "veziMarfurileToolStripMenuItem";
            this.veziMarfurileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.veziMarfurileToolStripMenuItem.Text = "Vezi Marfurile";
            this.veziMarfurileToolStripMenuItem.Click += new System.EventHandler(this.veziMarfurileToolStripMenuItem_Click);
            // 
            // acceseazaContracteleUnuiFurnizorToolStripMenuItem
            // 
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem.Name = "acceseazaContracteleUnuiFurnizorToolStripMenuItem";
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem.Size = new System.Drawing.Size(192, 20);
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem.Text = "Acceseaza contractele unei firme";
            this.acceseazaContracteleUnuiFurnizorToolStripMenuItem.Click += new System.EventHandler(this.acceseazaContracteleUnuiFurnizorToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateBinarToolStripMenuItem,
            this.preluareDateBinarToolStripMenuItem,
            this.salvareDateXmlToolStripMenuItem,
            this.preluareDateXmlToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // salvareDateBinarToolStripMenuItem
            // 
            this.salvareDateBinarToolStripMenuItem.Name = "salvareDateBinarToolStripMenuItem";
            this.salvareDateBinarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.salvareDateBinarToolStripMenuItem.Text = "Salvare date binar";
            this.salvareDateBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareDateBinarToolStripMenuItem_Click);
            // 
            // preluareDateBinarToolStripMenuItem
            // 
            this.preluareDateBinarToolStripMenuItem.Name = "preluareDateBinarToolStripMenuItem";
            this.preluareDateBinarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.preluareDateBinarToolStripMenuItem.Text = "Preluare date binar";
            this.preluareDateBinarToolStripMenuItem.Click += new System.EventHandler(this.preluareDateBinarToolStripMenuItem_Click);
            // 
            // salvareDateXmlToolStripMenuItem
            // 
            this.salvareDateXmlToolStripMenuItem.Name = "salvareDateXmlToolStripMenuItem";
            this.salvareDateXmlToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.salvareDateXmlToolStripMenuItem.Text = "Salvare date xml";
            this.salvareDateXmlToolStripMenuItem.Click += new System.EventHandler(this.salvareDateXmlToolStripMenuItem_Click);
            // 
            // preluareDateXmlToolStripMenuItem
            // 
            this.preluareDateXmlToolStripMenuItem.Name = "preluareDateXmlToolStripMenuItem";
            this.preluareDateXmlToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.preluareDateXmlToolStripMenuItem.Text = "Preluare date xml";
            this.preluareDateXmlToolStripMenuItem.Click += new System.EventHandler(this.preluareDateXmlToolStripMenuItem_Click);
            // 
            // iesireDinAplicatieToolStripMenuItem
            // 
            this.iesireDinAplicatieToolStripMenuItem.Name = "iesireDinAplicatieToolStripMenuItem";
            this.iesireDinAplicatieToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.iesireDinAplicatieToolStripMenuItem.Text = "Iesire din aplicatie";
            this.iesireDinAplicatieToolStripMenuItem.Click += new System.EventHandler(this.iesireDinAplicatieToolStripMenuItem_Click);
            // 
            // cb_Companii
            // 
            this.cb_Companii.FormattingEnabled = true;
            this.cb_Companii.Items.AddRange(new object[] {
            "Audi",
            "BMW"});
            this.cb_Companii.Location = new System.Drawing.Point(16, 102);
            this.cb_Companii.Name = "cb_Companii";
            this.cb_Companii.Size = new System.Drawing.Size(177, 21);
            this.cb_Companii.TabIndex = 2;
            this.cb_Companii.SelectedIndexChanged += new System.EventHandler(this.cb_Companii_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecteaza compania!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Afiseaza furnizorii companiei!";
            // 
            // tv_Furnizori
            // 
            this.tv_Furnizori.Location = new System.Drawing.Point(0, 231);
            this.tv_Furnizori.Name = "tv_Furnizori";
            this.tv_Furnizori.Size = new System.Drawing.Size(359, 264);
            this.tv_Furnizori.TabIndex = 5;
            // 
            // pb_SigleCompanii
            // 
            this.pb_SigleCompanii.Location = new System.Drawing.Point(916, 37);
            this.pb_SigleCompanii.Name = "pb_SigleCompanii";
            this.pb_SigleCompanii.Size = new System.Drawing.Size(432, 252);
            this.pb_SigleCompanii.TabIndex = 6;
            this.pb_SigleCompanii.TabStop = false;
            // 
            // userControlContract1
            // 
            this.userControlContract1.Location = new System.Drawing.Point(365, 102);
            this.userControlContract1.Name = "userControlContract1";
            this.userControlContract1.Size = new System.Drawing.Size(545, 311);
            this.userControlContract1.TabIndex = 7;
            // 
            // FormCompanii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 581);
            this.Controls.Add(this.userControlContract1);
            this.Controls.Add(this.pb_SigleCompanii);
            this.Controls.Add(this.tv_Furnizori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Companii);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCompanii";
            this.Text = "FormCompanii";
            this.Load += new System.EventHandler(this.FormCompanii_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SigleCompanii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veziMărfurileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_Companii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem acceseazaContracteleUnuiFurnizorToolStripMenuItem;
        private System.Windows.Forms.TreeView tv_Furnizori;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preluareDateBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preluareDateXmlToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_SigleCompanii;
        private System.Windows.Forms.ToolStripMenuItem veziMarfurileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireDinAplicatieToolStripMenuItem;
        private UserControlContract userControlContract1;
    }
}

