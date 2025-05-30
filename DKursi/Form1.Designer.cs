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

        
        // Ruaj listën e përdoruesve
        Dictionary<string, string> users = new Dictionary<string, string>()
{
    { "admin", "1234" },
    { "user1", "pass1" },
    { "arina", "arina123" },
    { "dritan", "dritan987" }
};
       
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblPerdoruesi = new Label();
            txtPerdoruesi = new TextBox();
            txtFjalekalimi = new TextBox();
            lblFjalekalimi = new Label();
            btnHyr = new Button();
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 279);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(37, 61);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPerdoruesi
            // 
            lblPerdoruesi.AutoSize = true;
            lblPerdoruesi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerdoruesi.Location = new Point(195, 28);
            lblPerdoruesi.Margin = new Padding(2, 0, 2, 0);
            lblPerdoruesi.Name = "lblPerdoruesi";
            lblPerdoruesi.Size = new Size(108, 28);
            lblPerdoruesi.TabIndex = 3;
            lblPerdoruesi.Text = "Perdoruesi:";
            lblPerdoruesi.Click += lblPerdoruesi_Click;
            // 
            // txtPerdoruesi
            // 
            txtPerdoruesi.Location = new Point(195, 61);
            txtPerdoruesi.Margin = new Padding(2, 2, 2, 2);
            txtPerdoruesi.Name = "txtPerdoruesi";
            txtPerdoruesi.Size = new Size(292, 27);
            txtPerdoruesi.TabIndex = 0;
            // 
            // txtFjalekalimi
            // 
            txtFjalekalimi.Location = new Point(195, 141);
            txtFjalekalimi.Margin = new Padding(2, 2, 2, 2);
            txtFjalekalimi.Name = "txtFjalekalimi";
            txtFjalekalimi.Size = new Size(292, 27);
            txtFjalekalimi.TabIndex = 1;
            txtFjalekalimi.UseSystemPasswordChar = true;
            txtFjalekalimi.TextChanged += txtFjalekalimi_TextChanged;
            // 
            // lblFjalekalimi
            // 
            lblFjalekalimi.AutoSize = true;
            lblFjalekalimi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFjalekalimi.Location = new Point(195, 108);
            lblFjalekalimi.Margin = new Padding(2, 0, 2, 0);
            lblFjalekalimi.Name = "lblFjalekalimi";
            lblFjalekalimi.Size = new Size(108, 28);
            lblFjalekalimi.TabIndex = 4;
            lblFjalekalimi.Text = "Fjalekalimi:";
            lblFjalekalimi.Click += lblFjalekalimi_Click;
            // 
            // btnHyr
            // 
            btnHyr.BackgroundImage = (Image)resources.GetObject("btnHyr.BackgroundImage");
            btnHyr.BackgroundImageLayout = ImageLayout.Stretch;
            btnHyr.Location = new Point(300, 184);
            btnHyr.Margin = new Padding(2, 2, 2, 2);
            btnHyr.Name = "btnHyr";
            btnHyr.Size = new Size(74, 58);
            btnHyr.TabIndex = 2;
            btnHyr.UseVisualStyleBackColor = true;
            btnHyr.Click += btnHyr_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnHyr;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(525, 279);
            Controls.Add(btnHyr);
            Controls.Add(txtFjalekalimi);
            Controls.Add(lblFjalekalimi);
            Controls.Add(txtPerdoruesi);
            Controls.Add(lblPerdoruesi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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
        private TextBox txtPerdoruesi;
        private TextBox txtFjalekalimi;
        private Label lblFjalekalimi;
        private Button btnHyr;
    }
}
