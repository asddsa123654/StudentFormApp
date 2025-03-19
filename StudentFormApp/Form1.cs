using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник для кнопки OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string birthYear = txtBirthYear.Text;
            string group = txtGroup.Text;
            string course = txtCourse.Text;

            // Перевірка на порожні значення
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(birthYear) || string.IsNullOrWhiteSpace(group) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Перевірка на рік народження (ч чи число)
            if (!int.TryParse(birthYear, out int birthYearInt) || birthYearInt < 1900 || birthYearInt > DateTime.Now.Year)
            {
                MessageBox.Show("Будь ласка, введіть коректний рік народження.");
                return;
            }

            // Виведення даних у багаторядкове поле
            txtOutput.Text = $"Ім’я: {name}\r\nПрізвище: {surname}\r\nРік народження: {birthYear}\r\nГрупа: {group}\r\nКурс: {course}";
        }

        // Обробник для кнопки Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриває форму
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
