using System.Configuration;

namespace DKursi
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            lblPerdoruesi = new Label();
            lblFjalekalimi = new Label();
            btnHyr = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            txtValue = new TextBox();
            btnFshi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 416);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(30, 137);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(300, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 38);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblPerdoruesi
            // 
            lblPerdoruesi.AutoSize = true;
            lblPerdoruesi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerdoruesi.Location = new Point(172, 31);
            lblPerdoruesi.Margin = new Padding(2, 0, 2, 0);
            lblPerdoruesi.Name = "lblPerdoruesi";
            lblPerdoruesi.Size = new Size(87, 21);
            lblPerdoruesi.TabIndex = 3;
            lblPerdoruesi.Text = "Perdoruesi:";
            lblPerdoruesi.Click += lblPerdoruesi_Click;
            // 
            // lblFjalekalimi
            // 
            lblFjalekalimi.AutoSize = true;
            lblFjalekalimi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFjalekalimi.Location = new Point(172, 118);
            lblFjalekalimi.Margin = new Padding(2, 0, 2, 0);
            lblFjalekalimi.Name = "lblFjalekalimi";
            lblFjalekalimi.Size = new Size(87, 21);
            lblFjalekalimi.TabIndex = 4;
            lblFjalekalimi.Text = "Fjalekalimi:";
            lblFjalekalimi.Click += lblFjalekalimi_Click;
            // 
            // btnHyr
            // 
            btnHyr.BackgroundImage = (Image)resources.GetObject("btnHyr.BackgroundImage");
            btnHyr.BackgroundImageLayout = ImageLayout.Stretch;
            btnHyr.Location = new Point(294, 336);
            btnHyr.Margin = new Padding(2);
            btnHyr.Name = "btnHyr";
            btnHyr.Size = new Size(60, 56);
            btnHyr.TabIndex = 2;
            btnHyr.UseVisualStyleBackColor = true;
            btnHyr.Click += btnHyr_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.CadetBlue;
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.PeachPuff;
            btn4.Location = new Point(294, 213);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 56);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += onNumberButton_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.CadetBlue;
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.PeachPuff;
            btn1.Location = new Point(294, 151);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 56);
            btn1.TabIndex = 20;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += onNumberButton_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.CadetBlue;
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.PeachPuff;
            btn7.Location = new Point(294, 275);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 56);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += onNumberButton_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.CadetBlue;
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.PeachPuff;
            btn8.Location = new Point(360, 275);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 56);
            btn8.TabIndex = 24;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += onNumberButton_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.CadetBlue;
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.PeachPuff;
            btn2.Location = new Point(360, 151);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 56);
            btn2.TabIndex = 23;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += onNumberButton_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.CadetBlue;
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.PeachPuff;
            btn5.Location = new Point(360, 213);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 56);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += onNumberButton_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.CadetBlue;
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.PeachPuff;
            btn9.Location = new Point(426, 275);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 56);
            btn9.TabIndex = 27;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += onNumberButton_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.CadetBlue;
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.PeachPuff;
            btn3.Location = new Point(426, 151);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 56);
            btn3.TabIndex = 26;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += onNumberButton_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.CadetBlue;
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.PeachPuff;
            btn6.Location = new Point(426, 213);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 56);
            btn6.TabIndex = 25;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += onNumberButton_Click;
            // 
            // txtValue
            // 
            txtValue.BackColor = SystemColors.Control;
            txtValue.Font = new Font("Segoe UI", 20F);
            txtValue.Location = new Point(300, 102);
            txtValue.Name = "txtValue";
            txtValue.ReadOnly = true;
            txtValue.Size = new Size(176, 43);
            txtValue.TabIndex = 28;
            // 
            // btnFshi
            // 
            btnFshi.BackgroundImage = (Image)resources.GetObject("btnFshi.BackgroundImage");
            btnFshi.BackgroundImageLayout = ImageLayout.Stretch;
            btnFshi.Location = new Point(426, 336);
            btnFshi.Name = "btnFshi";
            btnFshi.Size = new Size(60, 56);
            btnFshi.TabIndex = 29;
            btnFshi.UseVisualStyleBackColor = true;
            btnFshi.Click += btnFshi_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnHyr;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(547, 416);
            Controls.Add(btnFshi);
            Controls.Add(txtValue);
            Controls.Add(comboBox1);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnHyr);
            Controls.Add(lblFjalekalimi);
            Controls.Add(lblPerdoruesi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblPerdoruesi;
        private Label lblFjalekalimi;
        private Button btnHyr;
        private ComboBox comboBox1;
        private Button btn4;
        private Button btn1;
        private Button btn7;
        private Button btn8;
        private Button btn2;
        private Button btn5;
        private Button btn9;
        private Button btn3;
        private Button btn6;
        private TextBox txtValue;
        private Button btnFshi;
    }
}
