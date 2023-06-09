﻿using System.Data;
using ROV_TL.Models;
using NLog;
using System.Text.RegularExpressions;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System.Diagnostics;

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

        private async void registerButton_Click(object sender, EventArgs e)
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
                    MimeMessage mail = new MimeMessage();
                    mail.From.Add(new MailboxAddress("Штрафы", "fuj6629@gmail.com"));
                    mail.To.Add(new MailboxAddress("Нарушитель", user.Email));

                    BodyBuilder bodybuilder = new BodyBuilder();
                    bodybuilder.HtmlBody = "Регистрация успешна!";
                    bodybuilder.TextBody = $"{user.Login}, Вы были успешно зарегистрированы!";
                    mail.Body = bodybuilder.ToMessageBody();
                    mail.Subject = "Регистрация";
                    using (var client = new SmtpClient())
                    {
                        await client.ConnectAsync("smtp.gmail.com", 587, false);
                        await client.AuthenticateAsync("fuj6629@gmail.com", "khiyvsscoromwtds");
                        await client.SendAsync(mail);

                        await client.DisconnectAsync(true);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }

        private void RegisterForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
