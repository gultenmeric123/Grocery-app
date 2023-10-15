namespace Registration
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uRUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisDbDataSet1 = new Registration.GirisDbDataSet1();
            this.uRUNLERTableAdapter = new Registration.GirisDbDataSet1TableAdapters.URUNLERTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(28, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 554);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(288, 63);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(424, 342);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // uRUNLERBindingSource
            // 
            this.uRUNLERBindingSource.DataMember = "URUNLER";
            this.uRUNLERBindingSource.DataSource = this.girisDbDataSet1;
            // 
            // girisDbDataSet1
            // 
            this.girisDbDataSet1.DataSetName = "GirisDbDataSet1";
            this.girisDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNLERTableAdapter
            // 
            this.uRUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GirisDbDataSet1 girisDbDataSet1;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource;
        private GirisDbDataSet1TableAdapters.URUNLERTableAdapter uRUNLERTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}