﻿using NLog;
using ROV_TL.Models;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class AddVioForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Vio to create
        Vio newVio;

        public AddVioForm(Admin currentAdmin)
        {
            InitializeComponent();
            admin = currentAdmin;
        }

        private void AddVioForm_Load(object sender, EventArgs e)
        {

        }

        private void RandomGenButton_Click(object sender, EventArgs e)
        {
            User[] users = db.Users.ToArray();
            Rule[] rules = db.Rules.ToArray();

            Random rnd = new Random();

            int rndUser = rnd.Next(0, users.Count());

            while (db.Cars.Where(c => c.UserId == users[rndUser].Id).ToArray().Count() <= 0)
            {
                rndUser = rnd.Next(0, users.Count());
            }

            Car[] cars = db.Cars.Where(c => c.UserId == users[rndUser].Id).ToArray();
            int rndCar = rnd.Next(0, cars.Count());
            int rndRule = rnd.Next(0, rules.Count());

            UIDTextBox.Text = users[rndUser].Id.ToString();
            LoginTextBox.Text = users[rndUser].Login;
            CIDTextBox.Text = cars[rndCar].CarId.ToString();
            ModelTextBox.Text = cars[rndCar].Model;

            VioTextBox.Text = rules[rndRule].Text;
            FineTextBox.Text = rules[rndRule].Fine.ToString();

            newVio = new Vio
            {
                CarId = cars[rndCar].CarId,
                UserId = users[rndUser].Id,

                Violation = rules[rndRule].Text,
                Fine = rules[rndRule].Fine.ToString(),
                Date = DateTimePicker.Value
            };

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {

                db.Violations.Add(newVio);
                db.SaveChanges();

                MessageBox.Show("Нарушение успешно добавлено");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка во время сохранения" + ex.Message);
            }


        }

        private void CarsLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsform = new CarsForm(admin);
            this.Hide();
            carsform.ShowDialog();
            this.Close();

        }

        private void UsersLabel_Click(object sender, EventArgs e)
        {
            UsersForm usersform = new UsersForm(admin);
            this.Hide();
            usersform.ShowDialog();
            this.Close();
        }

        private void AdminsLabel_Click(object sender, EventArgs e)
        {
            AdminsForm adminForms = new AdminsForm(admin);
            this.Hide();
            adminForms.ShowDialog();
            this.Close();

        }

        private void AdminProfileLabel_Click(object sender, EventArgs e)
        {
            AdminProfileForm adminform = new AdminProfileForm(admin);
            this.Hide();
            adminform.ShowDialog();
            this.Close();
        }

        private void ViosLabel_Click(object sender, EventArgs e)
        {
            ViosForm vioform = new ViosForm(admin);
            this.Hide();
            vioform.ShowDialog();
            this.Close();
        }
    }
}
