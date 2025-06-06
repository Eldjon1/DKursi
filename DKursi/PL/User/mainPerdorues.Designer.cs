namespace DKursi
{
    partial class UserForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            panel1 = new Panel();
            btnDil = new Button();
            btnRaporte = new Button();
            pictureBox1 = new PictureBox();
            btnFatura = new Button();
            panel2 = new Panel();
            lblOra = new Label();
            button21 = new Button();
            btnTav15 = new Button();
            btnTav13 = new Button();
            btnTav11 = new Button();
            btnTav9 = new Button();
            btnTav12 = new Button();
            btnTav10 = new Button();
            btnTav8 = new Button();
            btnTav7 = new Button();
            btnTav6 = new Button();
            btnTav5 = new Button();
            btnTav4 = new Button();
            btnTav3 = new Button();
            btnTav2 = new Button();
            btnTav1 = new Button();
            timerOra = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDil);
            panel1.Controls.Add(btnRaporte);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnFatura);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 624);
            panel1.TabIndex = 0;
            // 
            // btnDil
            // 
            btnDil.BackColor = Color.Gainsboro;
            btnDil.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDil.ForeColor = Color.Brown;
            btnDil.Location = new Point(149, 402);
            btnDil.Name = "btnDil";
            btnDil.Size = new Size(136, 66);
            btnDil.TabIndex = 11;
            btnDil.Text = "Dil ↪";
            btnDil.UseVisualStyleBackColor = false;
            // 
            // btnRaporte
            // 
            btnRaporte.BackColor = Color.Gainsboro;
            btnRaporte.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaporte.Location = new Point(12, 256);
            btnRaporte.Name = "btnRaporte";
            btnRaporte.Size = new Size(273, 57);
            btnRaporte.TabIndex = 7;
            btnRaporte.Text = "📊 Raporte";
            btnRaporte.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(77, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFatura
            // 
            btnFatura.BackColor = Color.Gainsboro;
            btnFatura.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFatura.Location = new Point(12, 193);
            btnFatura.Name = "btnFatura";
            btnFatura.Size = new Size(273, 57);
            btnFatura.TabIndex = 5;
            btnFatura.Text = "\U0001f9fe Fatura";
            btnFatura.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(lblOra);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 132);
            panel2.TabIndex = 0;
            // 
            // lblOra
            // 
            lblOra.AutoSize = true;
            lblOra.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOra.ForeColor = Color.WhiteSmoke;
            lblOra.Location = new Point(101, 42);
            lblOra.Name = "lblOra";
            lblOra.Size = new Size(98, 32);
            lblOra.TabIndex = 31;
            lblOra.Text = "label1";
            // 
            // button21
            // 
            button21.BackgroundImage = (Image)resources.GetObject("button21.BackgroundImage");
            button21.BackgroundImageLayout = ImageLayout.Stretch;
            button21.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.Location = new Point(917, 372);
            button21.Name = "button21";
            button21.Size = new Size(110, 82);
            button21.TabIndex = 30;
            button21.Text = "Tavolina 14";
            button21.TextAlign = ContentAlignment.BottomCenter;
            button21.UseVisualStyleBackColor = true;
            // 
            // btnTav15
            // 
            btnTav15.BackgroundImage = (Image)resources.GetObject("btnTav15.BackgroundImage");
            btnTav15.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav15.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav15.Location = new Point(917, 464);
            btnTav15.Name = "btnTav15";
            btnTav15.Size = new Size(110, 79);
            btnTav15.TabIndex = 29;
            btnTav15.Text = "Tavolina 15";
            btnTav15.TextAlign = ContentAlignment.BottomCenter;
            btnTav15.UseVisualStyleBackColor = true;
            // 
            // btnTav13
            // 
            btnTav13.BackgroundImage = (Image)resources.GetObject("btnTav13.BackgroundImage");
            btnTav13.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav13.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav13.Location = new Point(788, 464);
            btnTav13.Name = "btnTav13";
            btnTav13.Size = new Size(110, 78);
            btnTav13.TabIndex = 28;
            btnTav13.Text = "Tavolina 13";
            btnTav13.TextAlign = ContentAlignment.BottomCenter;
            btnTav13.UseVisualStyleBackColor = true;
            // 
            // btnTav11
            // 
            btnTav11.BackgroundImage = (Image)resources.GetObject("btnTav11.BackgroundImage");
            btnTav11.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav11.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav11.Location = new Point(659, 462);
            btnTav11.Name = "btnTav11";
            btnTav11.Size = new Size(113, 81);
            btnTav11.TabIndex = 27;
            btnTav11.Text = "Tavolina 11";
            btnTav11.TextAlign = ContentAlignment.BottomCenter;
            btnTav11.UseVisualStyleBackColor = true;
            // 
            // btnTav9
            // 
            btnTav9.BackgroundImage = (Image)resources.GetObject("btnTav9.BackgroundImage");
            btnTav9.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav9.Location = new Point(527, 462);
            btnTav9.Name = "btnTav9";
            btnTav9.Size = new Size(112, 80);
            btnTav9.TabIndex = 26;
            btnTav9.Text = "Tavolina 9";
            btnTav9.TextAlign = ContentAlignment.BottomCenter;
            btnTav9.UseVisualStyleBackColor = true;
            // 
            // btnTav12
            // 
            btnTav12.BackgroundImage = (Image)resources.GetObject("btnTav12.BackgroundImage");
            btnTav12.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav12.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav12.Location = new Point(788, 372);
            btnTav12.Name = "btnTav12";
            btnTav12.Size = new Size(110, 82);
            btnTav12.TabIndex = 25;
            btnTav12.Text = "Tavolina 12";
            btnTav12.TextAlign = ContentAlignment.BottomCenter;
            btnTav12.UseVisualStyleBackColor = true;
            // 
            // btnTav10
            // 
            btnTav10.BackgroundImage = (Image)resources.GetObject("btnTav10.BackgroundImage");
            btnTav10.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav10.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav10.Location = new Point(659, 372);
            btnTav10.Name = "btnTav10";
            btnTav10.Size = new Size(113, 80);
            btnTav10.TabIndex = 24;
            btnTav10.Text = "Tavolina 10";
            btnTav10.TextAlign = ContentAlignment.BottomCenter;
            btnTav10.UseVisualStyleBackColor = true;
            // 
            // btnTav8
            // 
            btnTav8.BackgroundImage = (Image)resources.GetObject("btnTav8.BackgroundImage");
            btnTav8.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav8.Location = new Point(527, 372);
            btnTav8.Name = "btnTav8";
            btnTav8.Size = new Size(112, 80);
            btnTav8.TabIndex = 23;
            btnTav8.Text = "Tavolina 8";
            btnTav8.TextAlign = ContentAlignment.BottomCenter;
            btnTav8.UseVisualStyleBackColor = true;
            // 
            // btnTav7
            // 
            btnTav7.BackgroundImage = (Image)resources.GetObject("btnTav7.BackgroundImage");
            btnTav7.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav7.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav7.Location = new Point(404, 372);
            btnTav7.Name = "btnTav7";
            btnTav7.Size = new Size(107, 80);
            btnTav7.TabIndex = 22;
            btnTav7.Text = "Tavolina 7";
            btnTav7.TextAlign = ContentAlignment.BottomCenter;
            btnTav7.UseVisualStyleBackColor = true;
            // 
            // btnTav6
            // 
            btnTav6.BackgroundImage = (Image)resources.GetObject("btnTav6.BackgroundImage");
            btnTav6.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav6.Location = new Point(527, 276);
            btnTav6.Name = "btnTav6";
            btnTav6.Size = new Size(107, 80);
            btnTav6.TabIndex = 21;
            btnTav6.Text = "Tavolina 6";
            btnTav6.TextAlign = ContentAlignment.BottomCenter;
            btnTav6.UseVisualStyleBackColor = true;
            // 
            // btnTav5
            // 
            btnTav5.BackgroundImage = (Image)resources.GetObject("btnTav5.BackgroundImage");
            btnTav5.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav5.Location = new Point(404, 276);
            btnTav5.Name = "btnTav5";
            btnTav5.Size = new Size(107, 80);
            btnTav5.TabIndex = 20;
            btnTav5.Text = "Tavolina 5";
            btnTav5.TextAlign = ContentAlignment.BottomCenter;
            btnTav5.UseVisualStyleBackColor = true;
            // 
            // btnTav4
            // 
            btnTav4.BackgroundImage = (Image)resources.GetObject("btnTav4.BackgroundImage");
            btnTav4.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav4.Location = new Point(527, 181);
            btnTav4.Name = "btnTav4";
            btnTav4.Size = new Size(107, 81);
            btnTav4.TabIndex = 19;
            btnTav4.Text = "Tavolina 4";
            btnTav4.TextAlign = ContentAlignment.BottomCenter;
            btnTav4.UseVisualStyleBackColor = true;
            // 
            // btnTav3
            // 
            btnTav3.BackgroundImage = (Image)resources.GetObject("btnTav3.BackgroundImage");
            btnTav3.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav3.Location = new Point(404, 181);
            btnTav3.Name = "btnTav3";
            btnTav3.Size = new Size(107, 79);
            btnTav3.TabIndex = 18;
            btnTav3.Text = "Tavolina 3";
            btnTav3.TextAlign = ContentAlignment.BottomCenter;
            btnTav3.UseVisualStyleBackColor = true;
            // 
            // btnTav2
            // 
            btnTav2.BackgroundImage = (Image)resources.GetObject("btnTav2.BackgroundImage");
            btnTav2.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav2.Location = new Point(527, 95);
            btnTav2.Name = "btnTav2";
            btnTav2.Size = new Size(107, 80);
            btnTav2.TabIndex = 17;
            btnTav2.Text = "Tavolina 2";
            btnTav2.TextAlign = ContentAlignment.BottomCenter;
            btnTav2.UseVisualStyleBackColor = true;
            // 
            // btnTav1
            // 
            btnTav1.BackgroundImage = (Image)resources.GetObject("btnTav1.BackgroundImage");
            btnTav1.BackgroundImageLayout = ImageLayout.Stretch;
            btnTav1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTav1.Location = new Point(404, 94);
            btnTav1.Name = "btnTav1";
            btnTav1.Size = new Size(107, 81);
            btnTav1.TabIndex = 16;
            btnTav1.Text = "Tavolina 1";
            btnTav1.TextAlign = ContentAlignment.BottomCenter;
            btnTav1.UseVisualStyleBackColor = true;
            // 
            // timerOra
            // 
            timerOra.Interval = 1000;
            timerOra.Tick += timerOra_Tick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1133, 624);
            Controls.Add(button21);
            Controls.Add(btnTav15);
            Controls.Add(btnTav13);
            Controls.Add(btnTav11);
            Controls.Add(btnTav9);
            Controls.Add(btnTav12);
            Controls.Add(btnTav10);
            Controls.Add(btnTav8);
            Controls.Add(btnTav7);
            Controls.Add(btnTav6);
            Controls.Add(btnTav5);
            Controls.Add(btnTav4);
            Controls.Add(btnTav3);
            Controls.Add(btnTav2);
            Controls.Add(btnTav1);
            Controls.Add(panel1);
            Name = "UserForm";
            Text = "Faqja Kryesore/Perdorues";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnFatura;
        private PictureBox pictureBox1;
        private Button btnRaporte;
        private Button btnDil;
        private Button button21;
        private Button btnTav15;
        private Button btnTav13;
        private Button btnTav11;
        private Button btnTav9;
        private Button btnTav12;
        private Button btnTav10;
        private Button btnTav8;
        private Button btnTav7;
        private Button btnTav6;
        private Button btnTav5;
        private Button btnTav4;
        private Button btnTav3;
        private Button btnTav2;
        private Button btnTav1;
        private System.Windows.Forms.Timer timerOra;
        private Label lblOra;
    }
}