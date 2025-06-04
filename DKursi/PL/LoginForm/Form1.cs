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
                    .FirstOrDefault(user => user.Username == username && user.Password == password);

                if (user != null)
                {
                    if (user.Role == "menaxher")
                    {
                        this.Hide();
                        var adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else if (user.Role == "kamarier")
                    {
                        this.Hide();
                        var waiterForm = new UserForm();
                        waiterForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Roli i përdoruesit nuk njihet.", "Gabim");
                    }
                }
                else
                {
                    MessageBox.Show("Emri ose fjalëkalimi është i pasaktë!", "Gabim");
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
                comboBox1.DisplayMember = "Username";
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
