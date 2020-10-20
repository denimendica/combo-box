namespace ComboBox
{
    partial class Form1
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.cmbIzbor = new System.Windows.Forms.ComboBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(302, 200);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(146, 22);
            this.txtIspis.TabIndex = 0;
            this.txtIspis.TextChanged += new System.EventHandler(this.txtIspis_TextChanged);
            // 
            // cmbIzbor
            // 
            this.cmbIzbor.FormattingEnabled = true;
            this.cmbIzbor.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            ""});
            this.cmbIzbor.Location = new System.Drawing.Point(302, 151);
            this.cmbIzbor.Name = "cmbIzbor";
            this.cmbIzbor.Size = new System.Drawing.Size(146, 24);
            this.cmbIzbor.TabIndex = 1;
            this.cmbIzbor.SelectedIndexChanged += new System.EventHandler(this.cmbIzbor_SelectedIndexChanged);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(342, 255);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(65, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cmbIzbor);
            this.Controls.Add(this.txtIspis);
            this.Name = "Form1";
            this.Text = "combo box vježba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.ComboBox cmbIzbor;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

