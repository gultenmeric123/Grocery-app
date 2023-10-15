namespace Registration
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.targetdataGridView = new System.Windows.Forms.DataGridView();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uRUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisDbDataSet1 = new Registration.GirisDbDataSet1();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisDbDataSet2 = new Registration.GirisDbDataSet2();
            this.girisDbDataSet = new Registration.GirisDbDataSet();
            this.girisDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitTablosuTableAdapter = new Registration.GirisDbDataSetTableAdapters.KayitTablosuTableAdapter();
            this.kayitTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uRUNLERTableAdapter = new Registration.GirisDbDataSet1TableAdapters.URUNLERTableAdapter();
            this.kategorilerTableAdapter = new Registration.GirisDbDataSet1TableAdapters.KategorilerTableAdapter();
            this.tableAdapterManager = new Registration.GirisDbDataSet1TableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kategorilerTableAdapter1 = new Registration.GirisDbDataSet2TableAdapters.KategorilerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTablosuBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.targetdataGridView);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 524);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(912, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // targetdataGridView
            // 
            this.targetdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.targetdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Miktar,
            this.Arti,
            this.Eksi});
            this.targetdataGridView.Location = new System.Drawing.Point(351, 174);
            this.targetdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.targetdataGridView.MaximumSize = new System.Drawing.Size(400, 308);
            this.targetdataGridView.MinimumSize = new System.Drawing.Size(400, 246);
            this.targetdataGridView.Name = "targetdataGridView";
            this.targetdataGridView.RowHeadersWidth = 4;
            this.targetdataGridView.Size = new System.Drawing.Size(400, 246);
            this.targetdataGridView.TabIndex = 5;
            this.targetdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.targetdataGridView_CellContentClick);
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.MinimumWidth = 6;
            this.Miktar.Name = "Miktar";
            this.Miktar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Miktar.Width = 45;
            // 
            // Arti
            // 
            this.Arti.HeaderText = "+";
            this.Arti.MinimumWidth = 6;
            this.Arti.Name = "Arti";
            this.Arti.Text = "+";
            this.Arti.UseColumnTextForButtonValue = true;
            this.Arti.Width = 25;
            // 
            // Eksi
            // 
            this.Eksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Eksi.DefaultCellStyle = dataGridViewCellStyle1;
            this.Eksi.HeaderText = "-";
            this.Eksi.MinimumWidth = 6;
            this.Eksi.Name = "Eksi";
            this.Eksi.Text = "-";
            this.Eksi.UseColumnTextForButtonValue = true;
            this.Eksi.Width = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 198);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(351, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(481, 106);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Türünü Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uRUNLERBindingSource, "urunID", true));
            this.comboBox1.DropDownWidth = 169;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(29, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.girisDbDataSet2;
            // 
            // girisDbDataSet2
            // 
            this.girisDbDataSet2.DataSetName = "GirisDbDataSet2";
            this.girisDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girisDbDataSet
            // 
            this.girisDbDataSet.DataSetName = "GirisDbDataSet";
            this.girisDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girisDbDataSetBindingSource
            // 
            this.girisDbDataSetBindingSource.DataSource = this.girisDbDataSet;
            this.girisDbDataSetBindingSource.Position = 0;
            // 
            // kayitTablosuBindingSource
            // 
            this.kayitTablosuBindingSource.DataMember = "KayitTablosu";
            this.kayitTablosuBindingSource.DataSource = this.girisDbDataSetBindingSource;
            // 
            // kayitTablosuTableAdapter
            // 
            this.kayitTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // kayitTablosuBindingSource1
            // 
            this.kayitTablosuBindingSource1.DataMember = "KayitTablosu";
            this.kayitTablosuBindingSource1.DataSource = this.girisDbDataSetBindingSource;
            // 
            // uRUNLERTableAdapter
            // 
            this.uRUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KategorilerTableAdapter = this.kategorilerTableAdapter;
            this.tableAdapterManager.KayitTablosuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Registration.GirisDbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.URUNLERTableAdapter = null;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1067, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // kategorilerTableAdapter1
            // 
            this.kategorilerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTablosuBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource girisDbDataSetBindingSource;
        private GirisDbDataSet girisDbDataSet;
        private System.Windows.Forms.BindingSource kayitTablosuBindingSource;
        private GirisDbDataSetTableAdapters.KayitTablosuTableAdapter kayitTablosuTableAdapter;
        private System.Windows.Forms.BindingSource kayitTablosuBindingSource1;
        private GirisDbDataSet1 girisDbDataSet1;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource;
        private GirisDbDataSet1TableAdapters.URUNLERTableAdapter uRUNLERTableAdapter;
        private GirisDbDataSet1TableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private GirisDbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private GirisDbDataSet2 girisDbDataSet2;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private GirisDbDataSet2TableAdapters.KategorilerTableAdapter kategorilerTableAdapter1;
        private System.Windows.Forms.DataGridView targetdataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewButtonColumn Arti;
        private System.Windows.Forms.DataGridViewButtonColumn Eksi;
    }
}