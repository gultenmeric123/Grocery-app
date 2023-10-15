namespace Registration
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.check_pass = new System.Windows.Forms.CheckBox();
            this.con_pass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.check_pass);
            this.panel1.Controls.Add(this.con_pass);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.adres);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.last_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.first_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(176, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 515);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(59, 450);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 30);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "You Already Member?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 6;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(576, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_pass
            // 
            this.check_pass.AutoSize = true;
            this.check_pass.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check_pass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.check_pass.Location = new System.Drawing.Point(448, 396);
            this.check_pass.Margin = new System.Windows.Forms.Padding(4);
            this.check_pass.Name = "check_pass";
            this.check_pass.Size = new System.Drawing.Size(123, 27);
            this.check_pass.TabIndex = 18;
            this.check_pass.Text = "Şifreyi Göster";
            this.check_pass.UseVisualStyleBackColor = true;
            this.check_pass.CheckedChanged += new System.EventHandler(this.check_pass_CheckedChanged);
            // 
            // con_pass
            // 
            this.con_pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.con_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.con_pass.Location = new System.Drawing.Point(432, 361);
            this.con_pass.Margin = new System.Windows.Forms.Padding(4);
            this.con_pass.Name = "con_pass";
            this.con_pass.Size = new System.Drawing.Size(263, 24);
            this.con_pass.TabIndex = 17;
            this.con_pass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.SeaShell;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(443, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dogrula Password";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(432, 281);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(263, 24);
            this.password.TabIndex = 15;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(444, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.email.Location = new System.Drawing.Point(432, 207);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(263, 24);
            this.email.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(455, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adres.Location = new System.Drawing.Point(432, 132);
            this.adres.Margin = new System.Windows.Forms.Padding(4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(263, 24);
            this.adres.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(455, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.gender.Location = new System.Drawing.Point(56, 363);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(263, 24);
            this.gender.TabIndex = 9;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(62, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "LastName";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 282);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(62, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.last_name.Location = new System.Drawing.Point(51, 207);
            this.last_name.Margin = new System.Windows.Forms.Padding(4);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(263, 24);
            this.last_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(59, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Birth Date";
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.first_name.Location = new System.Drawing.Point(56, 132);
            this.first_name.Margin = new System.Windows.Forms.Padding(4);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(263, 24);
            this.first_name.TabIndex = 2;
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(59, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(336, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Ol";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, -23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(798, 379);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.DarkGreen;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(986, -5);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(103, 568);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkGreen;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-43, -5);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(184, 568);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox check_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox con_pass;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox adres;
        public System.Windows.Forms.ComboBox gender;
        public System.Windows.Forms.TextBox last_name;
        public System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

