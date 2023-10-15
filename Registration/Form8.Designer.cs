namespace Registration
{
    partial class Gecmis
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ColumnHeader Miktar;
            this.listView1 = new System.Windows.Forms.ListView();
            this.KategoriAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToplamTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KategoriAdi,
            this.UrunAdi,
            Miktar,
            this.BirimFiyat,
            this.ToplamTutar,
            this.Tarih});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 709);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Gecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 709);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gecmis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Gecmis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader KategoriAdi;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader BirimFiyat;
        private System.Windows.Forms.ColumnHeader ToplamTutar;
        private System.Windows.Forms.ColumnHeader Tarih;
    }
}