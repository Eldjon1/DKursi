namespace DKursi.Magazina
{
    partial class Magazina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazina));
            panel1 = new Panel();
            btnKthehu = new Button();
            button2 = new Button();
            btnBlerjet = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnKthehu);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnBlerjet);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 637);
            panel1.TabIndex = 1;
            // 
            // btnKthehu
            // 
            btnKthehu.BackColor = Color.Gainsboro;
            btnKthehu.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKthehu.ForeColor = Color.Brown;
            btnKthehu.Location = new Point(169, 392);
            btnKthehu.Name = "btnKthehu";
            btnKthehu.Size = new Size(179, 78);
            btnKthehu.TabIndex = 12;
            btnKthehu.Text = "Kthehu ↪";
            btnKthehu.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 251);
            button2.Name = "button2";
            button2.Size = new Size(345, 57);
            button2.TabIndex = 10;
            button2.Text = "🗑️ Fshi";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnBlerjet
            // 
            btnBlerjet.BackColor = Color.Gainsboro;
            btnBlerjet.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBlerjet.Location = new Point(3, 188);
            btnBlerjet.Name = "btnBlerjet";
            btnBlerjet.Size = new Size(345, 57);
            btnBlerjet.TabIndex = 8;
            btnBlerjet.Text = "🛍️ Blerjet";
            btnBlerjet.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(102, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 150);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(769, 499);
            dataGridView1.TabIndex = 2;
            // 
            // Magazina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1206, 637);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Magazina";
            Text = "Magazina";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKthehu;
        private Button button2;
        private Button btnBlerjet;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}