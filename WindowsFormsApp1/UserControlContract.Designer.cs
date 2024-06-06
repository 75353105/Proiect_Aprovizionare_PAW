namespace WindowsFormsApp1
{
    partial class UserControlContract
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_companii = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acceseaza compania careia vrei sa ii vezi contractele";
            // 
            // cb_companii
            // 
            this.cb_companii.FormattingEnabled = true;
            this.cb_companii.Items.AddRange(new object[] {
            "Audi",
            "BMW"});
            this.cb_companii.Location = new System.Drawing.Point(25, 128);
            this.cb_companii.Name = "cb_companii";
            this.cb_companii.Size = new System.Drawing.Size(121, 21);
            this.cb_companii.TabIndex = 1;
            this.cb_companii.SelectedIndexChanged += new System.EventHandler(this.cb_companii_SelectedIndexChanged);
            // 
            // UserControlContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_companii);
            this.Controls.Add(this.label1);
            this.Name = "UserControlContract";
            this.Size = new System.Drawing.Size(551, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_companii;
    }
}
