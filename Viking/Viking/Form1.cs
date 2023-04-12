using VikingLibrary;
using System.Data;
using System.Data.SQLite;



namespace Viking
{
    public partial class Form1 : Form
    {
        
        DatabaseViking db = new DatabaseViking();
        

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            db.GenerationBirthDates();
            db.GenerationPurchaseDates();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            CalculationAge();
            CalculationStatusAbonement();
            AddComboBoxItems();
            
            
        }
        
        private void CalculationStatusAbonement()
        {


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime dateofpurchase = Convert.ToDateTime(row.Cells["PurchaseDate"].Value);
                int subscriptionLength = Convert.ToInt32(row.Cells["Abonement"].Value);
                DateTime expirationDate = dateofpurchase.AddDays(subscriptionLength);
                string subscriptionStatus = expirationDate < DateTime.Today ? "Истек" : "Актив";
                row.Cells["AbonementStatus"].Value = subscriptionStatus;
            }


        }
        
        private void CalculationAge()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime dateOfBirth = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                int age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age -= 1;

                row.Cells["Age"].Value = age;
            }
        }
        private void AddNewClient_btn_Click(object sender, EventArgs e)
        {
            Creating_an_entryForm form2 = new Creating_an_entryForm();
            form2.Show();
        }
        
        private void DeleteCLient_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;New=False;Compress=True;");
            m_dbConnection.Open();

            var cmd = new SQLiteCommand(m_dbConnection);

            try
            {
                cmd.CommandText = "DELETE FROM People where ID=@ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                RefreshDataGrid(dataGridView1);

            }
            catch (Exception)
            {

                return;
            }
        }

        private void AddComboBoxItems()
        {
            comboBoxStatus.Items.Add("Клиент");
            comboBoxStatus.Items.Add("Бизнес-клиент");
            comboBoxStatus.Items.Add("Вип-клиент");


            comboBoxAbonement.Items.Add("30");
            comboBoxAbonement.Items.Add("90");
            comboBoxAbonement.Items.Add("360");
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("NameClient", "Имя");
            dataGridView1.Columns.Add("SurnameClient", "Фамилия");
            dataGridView1.Columns.Add("MiddleName", "Отчество");
            dataGridView1.Columns.Add("BirthDate", "Дата рождения");
            dataGridView1.Columns.Add("PhoneNumber", "Номер Телефона");
            dataGridView1.Columns.Add("Status", "Статус");
            dataGridView1.Columns.Add("Abonement", "Абонемент (Дней)");
            dataGridView1.Columns.Add("PurchaseDate", "Дата Покупки Абон.");
            dataGridView1.Columns.Add("AbonementStatus", "Статус Абонемента");
            dataGridView1.Columns.Add("Age", "Возраст");


        }


        private  void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetInt32(7), record.GetString(8));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;New=False;Compress=True;");
            m_dbConnection.Open();
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM People";

            SQLiteCommand command = new SQLiteCommand(queryString, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            m_dbConnection.Close();
            CalculationAge();
            CalculationStatusAbonement();
        }
        
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxLastName.Text = row.Cells[2].Value.ToString();
                textBoxMiddleName.Text = row.Cells[3].Value.ToString();
                textBoxBirthDate.Text = row.Cells[4].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells[5].Value.ToString();
                comboBoxStatus.Text = row.Cells[6].Value.ToString();
                comboBoxAbonement.Text = row.Cells[7].Value.ToString();

            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            
        }

        private void ChangeData_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;New=False;Compress=True;");
            m_dbConnection.Open();

            var cmd = new SQLiteCommand(m_dbConnection);

            try
            {
                cmd.CommandText = "UPDATE People Set FirstName=@Firstname,Lastname=@Lastname, MiddleName=@Middlename, BirthDate=@Birthdate, PhoneNumber=@Phonenumber, Status=@Status, Abonement=@Abonement where ID=@ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Firstname", textBoxName.Text);
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@Lastname", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@Middlename", textBoxMiddleName.Text);
                cmd.Parameters.AddWithValue("@Birthdate", textBoxBirthDate.Text);
                cmd.Parameters.AddWithValue("@Phonenumber", textBoxPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
                cmd.Parameters.AddWithValue("@Abonement", comboBoxAbonement.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                RefreshDataGrid(dataGridView1);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void GenerationData_btn_Click(object sender, EventArgs e)
        {
            db.LoadData();
        }

        private void DeleteAllData_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Clients.db;Version=3;New=False;Compress=True;");
            m_dbConnection.Open();
            string sql = "DELETE FROM People";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
    }
}