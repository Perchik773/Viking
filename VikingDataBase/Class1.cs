using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace VikingLibrary
{
    public class DatabaseViking
    {
        public void GenerationBirthDates()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                DateTime date = new DateTime(rnd.Next(1970, 2006), rnd.Next(1, 13), rnd.Next(1, 29));
                sb.AppendLine(date.ToString("dd.MM.yyyy"));
            }
            File.WriteAllText("birthdates.txt", sb.ToString());
        }
        public void LoadData()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;New=False;Compress=True;");
            m_dbConnection.Open();


            string[] firstNames = File.ReadAllLines("firstNames.txt");
            string[] lastNames = File.ReadAllLines("lastNames.txt");
            string[] middleNames = File.ReadAllLines("middleNames.txt");
            string[] birthdate = File.ReadAllLines("birthdates.txt");
            string[] phonenumber = File.ReadAllLines("phoneNumbers.txt");
            string[] status = File.ReadAllLines("statuses.txt");
            string[] abonement = File.ReadAllLines("abonement.txt");
            string[] purchasedateofabonement = File.ReadAllLines("PurchaseDates.txt");


            for (int i = 0; i < Math.Min(200, firstNames.Length); i++)
            {
                string sql = $"INSERT INTO People (FirstName, LastName, MiddleName, BirthDate, PhoneNumber, Status, Abonement, PurchaseDate) VALUES ('{firstNames[i]}', '{lastNames[i]}', '{middleNames[i]}', '{birthdate[i]}', '{phonenumber[i]}', '{status[i]}', '{abonement[i]}', '{purchasedateofabonement[i]}')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }
        public void GenerationPurchaseDates()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                DateTime date = new DateTime(rnd.Next(2022, 2024), rnd.Next(1, 13), rnd.Next(1, 29));
                sb.AppendLine(date.ToString("dd.MM.yyyy"));
            }
            File.WriteAllText("PurchaseDates.txt", sb.ToString());
        }
    }
}