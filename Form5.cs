using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace MiniProjecttt
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=Workshop; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM spacee WHERE 1 = 1";
                List<string> conditions = new List<string>();

                if (locationn.SelectedItem != null)
                {
                    conditions.Add("locationn = @locationn");
                }
                if (locationID.SelectedItem != null)
                {
                    conditions.Add("locationID = @locationID");
                }
                if (available.SelectedItem != null)
                {
                    conditions.Add("available = @available");
                }

                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (locationn.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@locationn", locationn.SelectedItem.ToString());
                }
                if (locationID.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@locationID", locationID.SelectedItem.ToString());
                }
                if (available.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@available", available.SelectedItem.ToString());
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Check if any row is selected
            {
                int locationID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["locationID"].Value); // Retrieve locationID from the selected row

                string connectionString = "Data Source=SOPHIA; Initial Catalog=Workshop; Integrated Security=True;"; // Connection string to your database
                ReserveLocation(connectionString, locationID); // Reserve the location with the retrieved locationID

            }
            else
            {
                MessageBox.Show("Please select a location before reserving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRowIndex()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            }
            else
            {
                return -1; // Return -1 if no row is selected
            }
        }

        private void ReserveLocation(string connectionString, int locationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("UPDATE spacee SET available = 'occupied' WHERE locationID = @locationID", connection))
                    {
                        command.Parameters.AddWithValue("@locationID", locationID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to reserve location. Location not found or already reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 again = new Form5();
            again.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 bye = new Form6();
            bye.ShowDialog();
        }
    }
}
