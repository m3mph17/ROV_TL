using System.Data;
using ROV_TL.Models;
using NLog;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ROV_TL.Forms
{
    public partial class RegisterForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                Fio = fioTextBox.Text,
                Balance = 0
            };

            if (loginTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "" || fioTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Data is not fulled: user {login}", loginTextBox.Text);
                return;
            }

            // Regex for validating email 
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (regex.IsMatch(emailTextBox.Text) == false)
            {
                MessageBox.Show("Неверная электронная почта", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Email is wrong: {email}", emailTextBox.Text);
                return;
            }

            // Regex for validating FIO
            regex = new Regex(@"/^([А-ЯA-Z]|[А-ЯA-Z][\x27а-яa-z]{1,}|[А-ЯA-Z][\x27а-яa-z]{1,}\-([А-ЯA-Z][\x27а-яa-z]{1,}|(оглы)|(кызы)))\040[А-ЯA-Z][\x27а-яa-z]{1,}(\040[А-ЯA-Z][\x27а-яa-z]{1,})?$/");
            if (regex.IsMatch(loginTextBox.Text) == false && fioTextBox.Text.Length < 5 || fioTextBox.Text.Length > 75)
            {
                MessageBox.Show("Неверное ФИО", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("FIO is wrong: {FIO}", loginTextBox.Text);
                return;
            }

            if (IsLoginUnique(user) == true && IsEmailUnique(user) == true)
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Успешная регистрация\nВаши данные можно найти в профиле.");

                log.Info("User register success {login}", user.Login);

                try
                {
                    MailMessage mm = new MailMessage();
                    SmtpClient smtpclient = new SmtpClient("smtp.mail.ru", 587);
                    mm.From = new MailAddress("z4574736@gmail.com");
                    mm.To.Add(user.Email);
                    mm.Subject = "registration";
                    mm.Body = "registration";
                    smtpclient.Credentials = new System.Net.NetworkCredential("fghfgh1954@inbox.ru", "231204den");
                    smtpclient.EnableSsl = true;
                    smtpclient.Send(mm);
                    MessageBox.Show("Email has meen sent.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error");
                }

                user = db.Users.Where(u => u.Login == user.Login).First();
                ProfileForm profileForm = new ProfileForm(user.Id);
                this.Hide();
                profileForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такие данные как логин и/или электронная почта уже существуют!");
            }


        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();

            loginForm.ShowDialog();
            this.Close();
        }

        private bool IsEmailUnique(User user)
        {
            try
            {
                // if there's no users with 'email' it creates exception
                User emailUser = db.Users.Where(x => x.Email == user.Email).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: email {email}", user.Email);
            return false;
        }
        private bool IsLoginUnique(User user)   
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User logUser = db.Users.Where(x => x.Login == user.Login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: login {login}", user.Login);
            return false;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            log.Info("Application closing {args}", e.GetHashCode());
            LogManager.Shutdown();

            this.Close();
        }
    }
}
