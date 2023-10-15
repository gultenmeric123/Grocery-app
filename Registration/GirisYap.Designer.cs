namespace Registration
{
    partial class GirisYap
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_pass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(236, 105);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 54);
            label1.TabIndex = 15;
            label1.Text = "GİRİŞ YAP";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.check_pass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(244, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(555, 524);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(455, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // check_pass
            // 
            this.check_pass.AutoSize = true;
            this.check_pass.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check_pass.Location = new System.Drawing.Point(127, 375);
            this.check_pass.Margin = new System.Windows.Forms.Padding(4);
            this.check_pass.Name = "check_pass";
            this.check_pass.Size = new System.Drawing.Size(123, 27);
            this.check_pass.TabIndex = 24;
            this.check_pass.Text = "Şifreyi Göster";
            this.check_pass.UseVisualStyleBackColor = true;
            this.check_pass.CheckedChanged += new System.EventHandler(this.check_pass_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(378, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 67);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(123, 457);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 30);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Değil misin?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(116, 331);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(321, 36);
            this.password.TabIndex = 21;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_name.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_name.Location = new System.Drawing.Point(112, 223);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(321, 36);
            this.user_name.TabIndex = 20;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(119, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 44);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(118, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "UserName";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(555, 398);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkGreen;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(872, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 553);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.DarkGreen;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-7, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(177, 553);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisYap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}