namespace DKursi.Magazina
{
    partial class BlerjetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlerjetForm));
            panel1 = new Panel();
            btnRuaj = new Button();
            txtBalanca = new TextBox();
            txtMbiemri = new TextBox();
            txtArtikulli = new TextBox();
            lblNjesia = new Label();
            lblCmimi = new Label();
            lblArtikulli = new Label();
            lblSasia = new Label();
            cmboxNjesia = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cmboxNjesia);
            panel1.Controls.Add(btnRuaj);
            panel1.Controls.Add(txtBalanca);
            panel1.Controls.Add(txtMbiemri);
            panel1.Controls.Add(txtArtikulli);
            panel1.Controls.Add(lblNjesia);
            panel1.Controls.Add(lblCmimi);
            panel1.Controls.Add(lblArtikulli);
            panel1.Controls.Add(lblSasia);
            panel1.Location = new Point(48, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 483);
            panel1.TabIndex = 2;
            // 
            // btnRuaj
            // 
            btnRuaj.BackColor = Color.White;
            btnRuaj.BackgroundImage = (Image)resources.GetObject("btnRuaj.BackgroundImage");
            btnRuaj.BackgroundImageLayout = ImageLayout.Stretch;
            btnRuaj.Font = new Font("Perpetua", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuaj.Location = new Point(168, 334);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(113, 85);
            btnRuaj.TabIndex = 9;
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextAlign = ContentAlignment.BottomCenter;
            btnRuaj.UseVisualStyleBackColor = false;
            // 
            // txtBalanca
            // 
            txtBalanca.Location = new Point(151, 259);
            txtBalanca.Name = "txtBalanca";
            txtBalanca.Size = new Size(261, 31);
            txtBalanca.TabIndex = 8;
            // 
            // txtMbiemri
            // 
            txtMbiemri.Location = new Point(151, 126);
            txtMbiemri.Name = "txtMbiemri";
            txtMbiemri.Size = new Size(261, 31);
            txtMbiemri.TabIndex = 6;
            // 
            // txtArtikulli
            // 
            txtArtikulli.Location = new Point(151, 66);
            txtArtikulli.Name = "txtArtikulli";
            txtArtikulli.Size = new Size(261, 31);
            txtArtikulli.TabIndex = 5;
            // 
            // lblNjesia
            // 
            lblNjesia.AutoSize = true;
            lblNjesia.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNjesia.Location = new Point(19, 184);
            lblNjesia.Name = "lblNjesia";
            lblNjesia.Size = new Size(109, 38);
            lblNjesia.TabIndex = 4;
            lblNjesia.Text = "Njesia :";
            // 
            // lblCmimi
            // 
            lblCmimi.AutoSize = true;
            lblCmimi.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCmimi.Location = new Point(12, 252);
            lblCmimi.Name = "lblCmimi";
            lblCmimi.Size = new Size(113, 38);
            lblCmimi.TabIndex = 2;
            lblCmimi.Text = "Cmimi :";
            // 
            // lblArtikulli
            // 
            lblArtikulli.AutoSize = true;
            lblArtikulli.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtikulli.Location = new Point(12, 59);
            lblArtikulli.Name = "lblArtikulli";
            lblArtikulli.Size = new Size(131, 38);
            lblArtikulli.TabIndex = 0;
            lblArtikulli.Text = "Artikulli :";
            // 
            // lblSasia
            // 
            lblSasia.AutoSize = true;
            lblSasia.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSasia.Location = new Point(19, 118);
            lblSasia.Name = "lblSasia";
            lblSasia.Size = new Size(96, 38);
            lblSasia.TabIndex = 1;
            lblSasia.Text = "Sasia :";
            // 
            // cmboxNjesia
            // 
            cmboxNjesia.FormattingEnabled = true;
            cmboxNjesia.Location = new Point(151, 189);
            cmboxNjesia.Name = "cmboxNjesia";
            cmboxNjesia.Size = new Size(261, 33);
            cmboxNjesia.TabIndex = 10;
            // 
            // BlerjetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(531, 589);
            Controls.Add(panel1);
            Name = "BlerjetForm";
            Text = "Blerje e Re";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRuaj;
        private TextBox txtBalanca;
        private TextBox txtNrCel;
        private TextBox txtMbiemri;
        private TextBox txtArtikulli;
        private Label lblNjesia;
        private Label lblCmimi;
        private Label lblArtikulli;
        private Label lblSasia;
        private ComboBox cmboxNjesia;
    }
}