using DKursi.Core.Data;

namespace DKursi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            string username = comboBox1.Text;
            string password = txtValue.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Users
                                  .FirstOrDefault(u => u.Name == username && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Hyrje e suksesshme!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Emri i përdoruesit ose fjalëkalimi është i pasaktë.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtValue.PasswordChar = '*';
            using (var context = new AppDbContext())
            {
                var userList = context.Users.ToList();

                comboBox1.DataSource = userList;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
        private void txtPerdoruesi_TextChanged(object sender, EventArgs e)
        {

        }
        public void AppendNumber(string nr)
        {
            txtValue.Text += nr;
        }
        private void onNumberButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            AppendNumber(btn.Text);
        }
        private void onActionButtonClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text == "0")
            {

            }
            else
                AppendNumber("*");
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length > 0)
            {
                txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1);
            }
        }
    }
}
