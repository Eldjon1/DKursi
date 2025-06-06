namespace DKursi.Furnitore
{
    partial class ShtoFurnitoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShtoFurnitoreForm));
            lblEmri = new Label();
            lblMbiemri = new Label();
            lblBalanca = new Label();
            lblNrCel = new Label();
            panel1 = new Panel();
            btnRuaj = new Button();
            txtBalanca = new TextBox();
            txtNrCel = new TextBox();
            txtMbiemri = new TextBox();
            txtEmri = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmri
            // 
            lblEmri.AutoSize = true;
            lblEmri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmri.Location = new Point(27, 52);
            lblEmri.Name = "lblEmri";
            lblEmri.Size = new Size(89, 38);
            lblEmri.TabIndex = 0;
            lblEmri.Text = "Emri :";
            // 
            // lblMbiemri
            // 
            lblMbiemri.AutoSize = true;
            lblMbiemri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMbiemri.Location = new Point(3, 119);
            lblMbiemri.Name = "lblMbiemri";
            lblMbiemri.Size = new Size(139, 38);
            lblMbiemri.TabIndex = 1;
            lblMbiemri.Text = "Mbiemri :";
            // 
            // lblBalanca
            // 
            lblBalanca.AutoSize = true;
            lblBalanca.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanca.Location = new Point(12, 252);
            lblBalanca.Name = "lblBalanca";
            lblBalanca.Size = new Size(130, 38);
            lblBalanca.TabIndex = 2;
            lblBalanca.Text = "Balanca :";
            // 
            // lblNrCel
            // 
            lblNrCel.AutoSize = true;
            lblNrCel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrCel.Location = new Point(3, 184);
            lblNrCel.Name = "lblNrCel";
            lblNrCel.Size = new Size(163, 38);
            lblNrCel.TabIndex = 4;
            lblNrCel.Text = "Nr. Celular :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnRuaj);
            panel1.Controls.Add(txtBalanca);
            panel1.Controls.Add(txtNrCel);
            panel1.Controls.Add(txtMbiemri);
            panel1.Controls.Add(txtEmri);
            panel1.Controls.Add(lblNrCel);
            panel1.Controls.Add(lblBalanca);
            panel1.Controls.Add(lblEmri);
            panel1.Controls.Add(lblMbiemri);
            panel1.Location = new Point(37, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 483);
            panel1.TabIndex = 1;
            // 
            // btnRuaj
            // 
            btnRuaj.BackColor = Color.White;
            btnRuaj.BackgroundImage = (Image)resources.GetObject("btnRuaj.BackgroundImage");
            btnRuaj.BackgroundImageLayout = ImageLayout.Stretch;
            btnRuaj.Font = new Font("Perpetua", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuaj.Location = new Point(151, 334);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(113, 85);
            btnRuaj.TabIndex = 9;
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextAlign = ContentAlignment.BottomCenter;
            btnRuaj.UseVisualStyleBackColor = false;
            // 
            // txtBalanca
            // 
            txtBalanca.Location = new Point(178, 259);
            txtBalanca.Name = "txtBalanca";
            txtBalanca.Size = new Size(236, 31);
            txtBalanca.TabIndex = 8;
            // 
            // txtNrCel
            // 
            txtNrCel.Location = new Point(178, 192);
            txtNrCel.Name = "txtNrCel";
            txtNrCel.Size = new Size(236, 31);
            txtNrCel.TabIndex = 7;
            // 
            // txtMbiemri
            // 
            txtMbiemri.Location = new Point(178, 126);
            txtMbiemri.Name = "txtMbiemri";
            txtMbiemri.Size = new Size(236, 31);
            txtMbiemri.TabIndex = 6;
            // 
            // txtEmri
            // 
            txtEmri.Location = new Point(178, 59);
            txtEmri.Name = "txtEmri";
            txtEmri.Size = new Size(236, 31);
            txtEmri.TabIndex = 5;
            // 
            // ShtoFurnitoreForm
            // 
            AcceptButton = btnRuaj;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(522, 582);
            Controls.Add(panel1);
            Name = "ShtoFurnitoreForm";
            Text = "Shto Furnitore";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblEmri;
        private Label lblMbiemri;
        private Label lblBalanca;
        private Label lblNrCel;
        private Panel panel1;
        private TextBox txtEmri;
        private TextBox txtBalanca;
        private TextBox txtNrCel;
        private TextBox txtMbiemri;
        private Button btnRuaj;
    }
}