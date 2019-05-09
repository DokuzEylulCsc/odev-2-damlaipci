namespace UniversiteSistemi
{
    partial class DersEkrani
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
            this.BolumListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BolumListesi
            // 
            this.BolumListesi.FormattingEnabled = true;
            this.BolumListesi.ItemHeight = 16;
            this.BolumListesi.Location = new System.Drawing.Point(12, 12);
            this.BolumListesi.Name = "BolumListesi";
            this.BolumListesi.Size = new System.Drawing.Size(307, 308);
            this.BolumListesi.TabIndex = 3;
            // 
            // DersEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(844, 515);
            this.Controls.Add(this.BolumListesi);
            this.Name = "DersEkrani";
            this.Text = "DersEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BolumListesi;
    }
}