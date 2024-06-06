namespace WindowsFormsApp1
{
    partial class AdaugareMaterial
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
            this.tb_IdMarfa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_denumireMarfa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stocDisponibil = new System.Windows.Forms.TextBox();
            this.tb_pretMediu = new System.Windows.Forms.TextBox();
            this.tb_Proprietar = new System.Windows.Forms.TextBox();
            this.btn_adaugaSauEditeaza = new System.Windows.Forms.Button();
            this.erP_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erP_Proprietar = new System.Windows.Forms.ErrorProvider(this.components);
            this.erP_Denumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.erP_stoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.erP_pret = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erP_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_Proprietar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_Denumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_stoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_pret)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_IdMarfa
            // 
            this.tb_IdMarfa.Location = new System.Drawing.Point(113, 104);
            this.tb_IdMarfa.Name = "tb_IdMarfa";
            this.tb_IdMarfa.Size = new System.Drawing.Size(100, 20);
            this.tb_IdMarfa.TabIndex = 0;
            this.tb_IdMarfa.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IdMarfa_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_denumireMarfa
            // 
            this.tb_denumireMarfa.Location = new System.Drawing.Point(113, 163);
            this.tb_denumireMarfa.Name = "tb_denumireMarfa";
            this.tb_denumireMarfa.Size = new System.Drawing.Size(100, 20);
            this.tb_denumireMarfa.TabIndex = 2;
            this.tb_denumireMarfa.Validating += new System.ComponentModel.CancelEventHandler(this.tb_denumireMarfa_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(23, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stoc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(23, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(23, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proprietar";
            // 
            // tb_stocDisponibil
            // 
            this.tb_stocDisponibil.Location = new System.Drawing.Point(113, 214);
            this.tb_stocDisponibil.Name = "tb_stocDisponibil";
            this.tb_stocDisponibil.Size = new System.Drawing.Size(100, 20);
            this.tb_stocDisponibil.TabIndex = 8;
            this.tb_stocDisponibil.Validating += new System.ComponentModel.CancelEventHandler(this.tb_stocDisponibil_Validating);
            // 
            // tb_pretMediu
            // 
            this.tb_pretMediu.Location = new System.Drawing.Point(113, 271);
            this.tb_pretMediu.Name = "tb_pretMediu";
            this.tb_pretMediu.Size = new System.Drawing.Size(100, 20);
            this.tb_pretMediu.TabIndex = 9;
            this.tb_pretMediu.Validating += new System.ComponentModel.CancelEventHandler(this.tb_pretMediu_Validating);
            // 
            // tb_Proprietar
            // 
            this.tb_Proprietar.Location = new System.Drawing.Point(113, 328);
            this.tb_Proprietar.Name = "tb_Proprietar";
            this.tb_Proprietar.Size = new System.Drawing.Size(100, 20);
            this.tb_Proprietar.TabIndex = 10;
            this.tb_Proprietar.TextChanged += new System.EventHandler(this.tb_Proprietar_TextChanged);
            this.tb_Proprietar.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Proprietar_Validating);
            // 
            // btn_adaugaSauEditeaza
            // 
            this.btn_adaugaSauEditeaza.Location = new System.Drawing.Point(113, 398);
            this.btn_adaugaSauEditeaza.Name = "btn_adaugaSauEditeaza";
            this.btn_adaugaSauEditeaza.Size = new System.Drawing.Size(100, 40);
            this.btn_adaugaSauEditeaza.TabIndex = 11;
            this.btn_adaugaSauEditeaza.Text = "OK!";
            this.btn_adaugaSauEditeaza.UseVisualStyleBackColor = true;
            this.btn_adaugaSauEditeaza.Click += new System.EventHandler(this.btn_adaugaSauEditeaza_Click);
            // 
            // erP_ID
            // 
            this.erP_ID.ContainerControl = this;
            // 
            // erP_Proprietar
            // 
            this.erP_Proprietar.ContainerControl = this;
            // 
            // erP_Denumire
            // 
            this.erP_Denumire.ContainerControl = this;
            // 
            // erP_stoc
            // 
            this.erP_stoc.ContainerControl = this;
            // 
            // erP_pret
            // 
            this.erP_pret.ContainerControl = this;
            // 
            // AdaugareMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_adaugaSauEditeaza);
            this.Controls.Add(this.tb_Proprietar);
            this.Controls.Add(this.tb_pretMediu);
            this.Controls.Add(this.tb_stocDisponibil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_denumireMarfa);
            this.Controls.Add(this.tb_IdMarfa);
            this.Name = "AdaugareMaterial";
            this.Text = "AdaugareMaterial";
            this.Load += new System.EventHandler(this.AdaugareMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erP_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_Proprietar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_Denumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_stoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP_pret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IdMarfa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_denumireMarfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stocDisponibil;
        private System.Windows.Forms.TextBox tb_pretMediu;
        private System.Windows.Forms.TextBox tb_Proprietar;
        private System.Windows.Forms.Button btn_adaugaSauEditeaza;
        private System.Windows.Forms.ErrorProvider erP_ID;
        private System.Windows.Forms.ErrorProvider erP_Proprietar;
        private System.Windows.Forms.ErrorProvider erP_Denumire;
        private System.Windows.Forms.ErrorProvider erP_stoc;
        private System.Windows.Forms.ErrorProvider erP_pret;
    }
}