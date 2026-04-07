namespace LKS_DIY_2026_12.Forms
{
    partial class FormAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KelUser = new System.Windows.Forms.Button();
            this.btn_KelLaporan = new System.Windows.Forms.Button();
            this.btn_Activity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Tipe = new System.Windows.Forms.ComboBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_telepon = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.alamat = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Activity);
            this.panel1.Controls.Add(this.btn_KelLaporan);
            this.panel1.Controls.Add(this.btn_KelUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 641);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // btn_KelUser
            // 
            this.btn_KelUser.Location = new System.Drawing.Point(119, 302);
            this.btn_KelUser.Name = "btn_KelUser";
            this.btn_KelUser.Size = new System.Drawing.Size(172, 46);
            this.btn_KelUser.TabIndex = 1;
            this.btn_KelUser.Text = "Kelola User";
            this.btn_KelUser.UseVisualStyleBackColor = true;
            // 
            // btn_KelLaporan
            // 
            this.btn_KelLaporan.Location = new System.Drawing.Point(119, 373);
            this.btn_KelLaporan.Name = "btn_KelLaporan";
            this.btn_KelLaporan.Size = new System.Drawing.Size(172, 46);
            this.btn_KelLaporan.TabIndex = 2;
            this.btn_KelLaporan.Text = "Kelola Laporan";
            this.btn_KelLaporan.UseVisualStyleBackColor = true;
            this.btn_KelLaporan.Click += new System.EventHandler(this.btn_KelLaporan_Click);
            // 
            // btn_Activity
            // 
            this.btn_Activity.Location = new System.Drawing.Point(119, 442);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(172, 46);
            this.btn_Activity.TabIndex = 3;
            this.btn_Activity.Text = "Log Activity";
            this.btn_Activity.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(161, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cb_Tipe
            // 
            this.cb_Tipe.FormattingEnabled = true;
            this.cb_Tipe.Items.AddRange(new object[] {
            "Admin",
            "Gudang",
            "Kasir"});
            this.cb_Tipe.Location = new System.Drawing.Point(569, 122);
            this.cb_Tipe.Name = "cb_Tipe";
            this.cb_Tipe.Size = new System.Drawing.Size(180, 25);
            this.cb_Tipe.TabIndex = 1;
            this.cb_Tipe.Text = "Gudang";
            this.cb_Tipe.SelectedIndexChanged += new System.EventHandler(this.cb_Tipe_SelectedIndexChanged);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(786, 122);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(183, 25);
            this.tb_username.TabIndex = 2;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(569, 168);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(180, 25);
            this.tb_nama.TabIndex = 3;
            this.tb_nama.TextChanged += new System.EventHandler(this.tb_nama_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(786, 168);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(180, 25);
            this.tb_password.TabIndex = 4;
            this.tb_password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_telepon
            // 
            this.tb_telepon.Location = new System.Drawing.Point(569, 228);
            this.tb_telepon.Name = "tb_telepon";
            this.tb_telepon.Size = new System.Drawing.Size(180, 25);
            this.tb_telepon.TabIndex = 5;
            this.tb_telepon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(799, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tamabah";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(893, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(987, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // alamat
            // 
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alamat.Location = new System.Drawing.Point(569, 302);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(180, 18);
            this.alamat.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Salmon;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Salmon;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 148;
            this.iconPictureBox1.Location = new System.Drawing.Point(130, 45);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(148, 148);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Location = new System.Drawing.Point(119, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 641);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_telepon);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.cb_Tipe);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KelUser;
        private System.Windows.Forms.Button btn_KelLaporan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Activity;
        private System.Windows.Forms.ComboBox cb_Tipe;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_telepon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alamat;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button button5;
    }
}