namespace DKursi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblPerdoruesi_Click(object sender, EventArgs e)
        {

        }

        private void txtFjalekalimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFjalekalimi_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }


        private void btnHyr_Click(object sender, EventArgs e)
        {
        {
            string username = txtPerdoruesi.Text;
            string password = txtFjalekalimi.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                MessageBox.Show("Hyrje e suksesshme!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                this.Hide(); // Fshih form�n e loginit
            }
            else
            {
                MessageBox.Show("Emri i p�rdoruesit ose fjal�kalimi �sht� i pasakt�.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        }
    }
}
