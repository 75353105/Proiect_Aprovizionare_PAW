namespace WindowsFormsApp1
{
    partial class AdaugaContracte
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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_numeFurnizor = new System.Windows.Forms.TextBox();
            this.tb_numeCompanie = new System.Windows.Forms.TextBox();
            this.tb_ValoareContract = new System.Windows.Forms.TextBox();
            this.tb_ProcentPenalizare = new System.Windows.Forms.TextBox();
            this.dtp_Semnare = new System.Windows.Forms.DateTimePicker();
            this.dtp_Livrare = new System.Windows.Forms.DateTimePicker();
            this.btn_adauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.erP_ID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erP_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(48, 75);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(132, 22);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ID_Validating);
            // 
            // tb_numeFurnizor
            // 
            this.tb_numeFurnizor.Location = new System.Drawing.Point(48, 422);
            this.tb_numeFurnizor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_numeFurnizor.Name = "tb_numeFurnizor";
            this.tb_numeFurnizor.Size = new System.Drawing.Size(132, 22);
            this.tb_numeFurnizor.TabIndex = 1;
            // 
            // tb_numeCompanie
            // 
            this.tb_numeCompanie.Location = new System.Drawing.Point(48, 180);
            this.tb_numeCompanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_numeCompanie.Name = "tb_numeCompanie";
            this.tb_numeCompanie.Size = new System.Drawing.Size(132, 22);
            this.tb_numeCompanie.TabIndex = 2;
            // 
            // tb_ValoareContract
            // 
            this.tb_ValoareContract.Location = new System.Drawing.Point(48, 522);
            this.tb_ValoareContract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ValoareContract.Name = "tb_ValoareContract";
            this.tb_ValoareContract.Size = new System.Drawing.Size(132, 22);
            this.tb_ValoareContract.TabIndex = 3;
            // 
            // tb_ProcentPenalizare
            // 
            this.tb_ProcentPenalizare.Location = new System.Drawing.Point(48, 614);
            this.tb_ProcentPenalizare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ProcentPenalizare.Name = "tb_ProcentPenalizare";
            this.tb_ProcentPenalizare.Size = new System.Drawing.Size(132, 22);
            this.tb_ProcentPenalizare.TabIndex = 4;
            // 
            // dtp_Semnare
            // 
            this.dtp_Semnare.Location = new System.Drawing.Point(48, 313);
            this.dtp_Semnare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Semnare.Name = "dtp_Semnare";
            this.dtp_Semnare.Size = new System.Drawing.Size(265, 22);
            this.dtp_Semnare.TabIndex = 5;
            // 
            // dtp_Livrare
            // 
            this.dtp_Livrare.Location = new System.Drawing.Point(401, 313);
            this.dtp_Livrare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Livrare.Name = "dtp_Livrare";
            this.dtp_Livrare.Size = new System.Drawing.Size(265, 22);
            this.dtp_Livrare.TabIndex = 6;
            // 
            // btn_adauga
            // 
            this.btn_adauga.Location = new System.Drawing.Point(701, 576);
            this.btn_adauga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_adauga.Name = "btn_adauga";
            this.btn_adauga.Size = new System.Drawing.Size(168, 63);
            this.btn_adauga.TabIndex = 7;
            this.btn_adauga.Text = "Adauga";
            this.btn_adauga.UseVisualStyleBackColor = true;
            this.btn_adauga.Click += new System.EventHandler(this.btn_adauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "IdContract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(44, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "NumeCompanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(419, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "DataLivrare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(44, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "NumeFurnizor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(44, 482);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ValoareContract";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(44, 576);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ProceantPenalizare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(45, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "DataSemnare";
            // 
            // erP_ID
            // 
            this.erP_ID.ContainerControl = this;
            // 
            // AdaugaContracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 666);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adauga);
            this.Controls.Add(this.dtp_Livrare);
            this.Controls.Add(this.dtp_Semnare);
            this.Controls.Add(this.tb_ProcentPenalizare);
            this.Controls.Add(this.tb_ValoareContract);
            this.Controls.Add(this.tb_numeCompanie);
            this.Controls.Add(this.tb_numeFurnizor);
            this.Controls.Add(this.tb_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdaugaContracte";
            this.Text = "AdaugaContracte";
            ((System.ComponentModel.ISupportInitialize)(this.erP_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_numeFurnizor;
        private System.Windows.Forms.TextBox tb_numeCompanie;
        private System.Windows.Forms.TextBox tb_ValoareContract;
        private System.Windows.Forms.TextBox tb_ProcentPenalizare;
        private System.Windows.Forms.DateTimePicker dtp_Semnare;
        private System.Windows.Forms.DateTimePicker dtp_Livrare;
        private System.Windows.Forms.Button btn_adauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider erP_ID;
    }
}