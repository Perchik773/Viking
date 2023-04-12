namespace Viking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddNewClient_btn = new System.Windows.Forms.Button();
            this.DeleteCLient_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAbonement = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeData_btn = new System.Windows.Forms.Button();
            this.GenerationData_btn = new System.Windows.Forms.Button();
            this.DeleteAllData_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(854, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddNewClient_btn
            // 
            this.AddNewClient_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewClient_btn.Location = new System.Drawing.Point(12, 12);
            this.AddNewClient_btn.Name = "AddNewClient_btn";
            this.AddNewClient_btn.Size = new System.Drawing.Size(126, 66);
            this.AddNewClient_btn.TabIndex = 2;
            this.AddNewClient_btn.Text = "Добавить Клиента";
            this.AddNewClient_btn.UseVisualStyleBackColor = true;
            this.AddNewClient_btn.Click += new System.EventHandler(this.AddNewClient_btn_Click);
            // 
            // DeleteCLient_btn
            // 
            this.DeleteCLient_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteCLient_btn.Location = new System.Drawing.Point(144, 12);
            this.DeleteCLient_btn.Name = "DeleteCLient_btn";
            this.DeleteCLient_btn.Size = new System.Drawing.Size(126, 66);
            this.DeleteCLient_btn.TabIndex = 3;
            this.DeleteCLient_btn.Text = "Удалить Выбранного клиента";
            this.DeleteCLient_btn.UseVisualStyleBackColor = true;
            this.DeleteCLient_btn.Click += new System.EventHandler(this.DeleteCLient_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Редактирование";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 526);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(122, 555);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(122, 584);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiddleName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия:";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(395, 528);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(142, 23);
            this.textBoxBirthDate.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(400, 559);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(137, 23);
            this.textBoxPhoneNumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(252, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата Рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(252, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер Телефона:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(569, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Статус:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(569, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Абонемент:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(678, 526);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // comboBoxAbonement
            // 
            this.comboBoxAbonement.FormattingEnabled = true;
            this.comboBoxAbonement.Location = new System.Drawing.Point(678, 559);
            this.comboBoxAbonement.Name = "comboBoxAbonement";
            this.comboBoxAbonement.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAbonement.TabIndex = 20;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(911, 526);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(43, 23);
            this.textBoxID.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(878, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Viking.Properties.Resources.ic24_rotate;
            this.pictureBox1.InitialImage = global::Viking.Properties.Resources.ic24_rotate;
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChangeData_btn
            // 
            this.ChangeData_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeData_btn.Location = new System.Drawing.Point(228, 464);
            this.ChangeData_btn.Name = "ChangeData_btn";
            this.ChangeData_btn.Size = new System.Drawing.Size(134, 24);
            this.ChangeData_btn.TabIndex = 24;
            this.ChangeData_btn.Text = "Изменить";
            this.ChangeData_btn.UseVisualStyleBackColor = true;
            this.ChangeData_btn.Click += new System.EventHandler(this.ChangeData_btn_Click);
            // 
            // GenerationData_btn
            // 
            this.GenerationData_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerationData_btn.Location = new System.Drawing.Point(351, 12);
            this.GenerationData_btn.Name = "GenerationData_btn";
            this.GenerationData_btn.Size = new System.Drawing.Size(115, 66);
            this.GenerationData_btn.TabIndex = 25;
            this.GenerationData_btn.Text = "Генерация (200 чел.)";
            this.GenerationData_btn.UseVisualStyleBackColor = true;
            this.GenerationData_btn.Click += new System.EventHandler(this.GenerationData_btn_Click);
            // 
            // DeleteAllData_btn
            // 
            this.DeleteAllData_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAllData_btn.Location = new System.Drawing.Point(472, 12);
            this.DeleteAllData_btn.Name = "DeleteAllData_btn";
            this.DeleteAllData_btn.Size = new System.Drawing.Size(108, 66);
            this.DeleteAllData_btn.TabIndex = 26;
            this.DeleteAllData_btn.Text = "Удалить ВСЕ Данные";
            this.DeleteAllData_btn.UseVisualStyleBackColor = true;
            this.DeleteAllData_btn.Click += new System.EventHandler(this.DeleteAllData_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 618);
            this.Controls.Add(this.DeleteAllData_btn);
            this.Controls.Add(this.GenerationData_btn);
            this.Controls.Add(this.ChangeData_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxAbonement);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteCLient_btn);
            this.Controls.Add(this.AddNewClient_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddNewClient_btn;
        private Button DeleteCLient_btn;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxMiddleName;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBoxBirthDate;
        private TextBox textBoxPhoneNumber;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxAbonement;
        private TextBox textBoxID;
        private Label label9;
        private PictureBox pictureBox1;
        private Button ChangeData_btn;
        private Button GenerationData_btn;
        private Button DeleteAllData_btn;
    }
}