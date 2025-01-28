using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace usingbd
{
    public partial class Form1 : Form
    {
        static string nameServer = "VITALIK\\MSSQLSERVER01";
        static string nameDb = "candy_store";
        string connectDb = $"Server={nameServer};Database={nameDb};Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            tbServer.Text = nameServer;
            tbDB.Text = nameDb;
        }
        static string serverName = "MSI";
        static string dataBaseName = "stories_site";

        string conectingInf = $"Server={serverName};Database={dataBaseName};Trusted_Connection=True;";
        private void LoadTables()
        {
            using (SqlConnection connection = new SqlConnection(connectDb))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT TABLE_NAME 
                    FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME != 'sysdiagrams'"; 
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    listBoxTables.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxTables.Items.Add(reader["TABLE_NAME"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні таблиць: " + ex.Message);
                }
            }
        }

        private void LoadTableContent(string tableName)
        {
            using (SqlConnection connection = new SqlConnection("Server=MSI;Database=stories_site;Trusted_Connection=True;"))
            {
                try
                {
                    string tableName = listBoxTables.SelectedItem.ToString();

                    using (SqlConnection connection = new SqlConnection(connectDb))
                    {
                        try
                        {
                            connection.Open();
                            string query = $"SELECT * FROM [{tableName}]";
                            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dataGridViewTable.DataSource = table;
                            labelInfo.Text = "Таблиця: " + tableName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка при завантаженні даних таблиці: " + ex.Message);
                        }
                    }


                    dataGridViewTable.DataSource = table;
                    labelInfo.Text = "Таблиця: " + tableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні даних таблиці: " + ex.Message);
                }
            }
        }
        private void showProcedure(string comandName)
        {
            using (SqlConnection connection = new SqlConnection(conectingInf))
            {
                try
                {
                    connection.Open();

                    switch (procedureName)
                    {
                        case "Інформація про історії":
                            procedure= "GetClientTotalIncome";
                            break;
                        case "Підрахунок фанатів":
                            procedure = "GetDetailedRevenueByDateRange";
                            break;
                        case "Топ 10 історій":
                            procedure = "GetOrdersWithHighestAverageCheck";
                            break;
                        case "Топ 10 авторів":
                            procedure = "GetRevenueByDateRange";
                            break;
                    }

                    using (SqlConnection connection = new SqlConnection(connectDb))
                    {
                        try
                        {
                            connection.Open();

                    dataGridViewTable.DataSource = table;

                    labelInfo.Text = comandName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при виконанні процедури: " + ex.Message);
                }
            }
        }
        private void LoadProcedures()
        {
            using (SqlConnection connection = new SqlConnection(conectingInf))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT name 
                    FROM sys.objects 
                    WHERE type = 'P' AND is_ms_shipped = 0";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    listBoxTables.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxTables.Items.Add(reader["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні процедур: " + ex.Message);
                }
            }
        }

        bool showStatisticDetails = false;

        private void listBoxTables_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedItem != null)
            {
                string tableOrProcedure = listBoxTables.SelectedItem.ToString();
                if (showStatisticDetails == false)
                {
                    LoadTableContent(tableOrProcedure);
                }
                else
                {                   
                    showProcedure(tableOrProcedure);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedItem != null)
            {
                string tableName = listBoxTables.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?",
                                                      "Підтвердження",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectDb))

                    {
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM [{tableName}]", connection);
                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                            DataTable changes = ((DataTable)dataGridViewTable.DataSource).GetChanges();
                            if (changes != null)
                            {
                                adapter.UpdateCommand = builder.GetUpdateCommand();
                                adapter.InsertCommand = builder.GetInsertCommand();
                                adapter.DeleteCommand = builder.GetDeleteCommand();

                                adapter.Update(changes);
                                ((DataTable)dataGridViewTable.DataSource).AcceptChanges();
                                MessageBox.Show("Зміни успішно збережені.");

                                using (SqlConnection newConnection = new SqlConnection("Server=VITALIK\\MSSQLSERVER01;Database=candy_store;Trusted_Connection=True;"))
                                {
                                    try
                                    {
                                        connection.Open();
                                        string query = $"SELECT * FROM [{tableName}]";
                                        SqlDataAdapter newAdapter = new SqlDataAdapter(query, newConnection);
                                        DataTable table = new DataTable();
                                        newAdapter.Fill(table);

                                        dataGridViewTable.DataSource = table;
                                        labelInfo.Text = "Таблиця: " + tableName;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Помилка при завантаженні даних таблиці: " + ex.Message);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Немає змін для збереження.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка при збереженні змін: " + ex.Message);
                        }
                    }
                }
            }
        }
        private void buttonShowTables_Click(object sender, EventArgs e)
        {
            showStatisticDetails = false;
            listBoxTables.Items.Clear();
            buttonSave.Visible = true;
            LoadTables();
        }

        private void buttonShowStatistic_Click(object sender, EventArgs e)
        {
            LoadProcedures();
            showStatisticDetails = true;
            buttonSave.Visible = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string find = textBoxFind.Text.Trim();

            if (string.IsNullOrEmpty(find))
            {
                MessageBox.Show("Будь ласка, введіть текст для пошуку.");
                return;
            }

            int cTrue = 0;
            string[] searchParts = find.Split(',');

            for (int i = 0; i < searchParts.Length; i++)
            {
                if (searchParts[i].Length >= 3)
                {
                    cTrue += 1;
                }
            }

            if (cTrue == searchParts.Length)
            {
                bool found = false;
                int firstMatchIndex = -1;

                foreach (DataGridViewRow row in dataGridViewTable.Rows)
                {
                    row.Selected = false;
                }

                foreach (DataGridViewRow row in dataGridViewTable.Rows)
                {
                    bool match = true;

                    foreach (string searchPart in searchParts)
                    {
                        bool partFound = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                string cellValue = cell.Value.ToString().ToLower();
                                string searchValue = searchPart.Trim().ToLower();

                                if (cellValue.Contains(searchValue))
                                {
                                    partFound = true;
                                    break;
                                }
                            }
                        }

                        if (!partFound)
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        row.Selected = true;
                        found = true;

                        if (firstMatchIndex == -1)
                        {
                            firstMatchIndex = row.Index;
                        }
                    }
                }

                if (found)
                {
                    if (firstMatchIndex != -1)
                    {
                        dataGridViewTable.FirstDisplayedScrollingRowIndex = firstMatchIndex;
                    }
                }
                else
                {
                    MessageBox.Show("Не знайдено елементів, що відповідають пошуку.");
                }
            }
            else
            {
                MessageBox.Show("Слово для пошуку має бути не менше 3 символів.");
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            nameServer = tbServer.Text.ToString();
            nameDb = tbDB.Text.ToString();
            connectDb = $"Server={nameServer};Database={nameDb};Trusted_Connection=True;";
            LoadTables();

        }
    }
}
