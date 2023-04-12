using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viking
{
    public partial class Creating_an_entryForm : Form
    {
        public Creating_an_entryForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Creating_an_entryForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Клиент");
            comboBox1.Items.Add("Бизнес-клиент");
            comboBox1.Items.Add("Вип-клиент");


            comboBox2.Items.Add("30");
            comboBox2.Items.Add("90");
            comboBox2.Items.Add("360");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;");
            m_dbConnection.Open();

            var firstNames = textBox1.Text;
            var lastNames = textBox2.Text;
            var middleNames = textBox3.Text;
            var birthdate = textBox4.Text;
            long phonenumber;
            var status = comboBox1.Text;
            var abonement = comboBox2.Text;
            var todaytime = DateTime.Today.ToString("dd.MM.yyyy");
            

            if (long.TryParse(textBox5.Text, out phonenumber) && textBox5.Text.Length == 11)
            {
                string sql = $"INSERT INTO People (FirstName, LastName, MiddleName, BirthDate, PhoneNumber, Status, Abonement, PurchaseDate) VALUES ('{firstNames}', '{lastNames}', '{middleNames}', '{birthdate}', '{phonenumber}', '{status}', '{abonement}', '{todaytime}')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Номер Телефона введен неправильно. Повторите попытку");
            }
            
            m_dbConnection.Close();
            this.Close();
        }

        private void textBoxPurchaseDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
