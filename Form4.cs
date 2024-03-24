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

namespace MiniProjecttt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty(dataGridView1))
            {
                MessageBox.Show("That's not possible.Please choose something else.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form5 form = new Form5();
                form.ShowDialog();
            }

        }
        private bool IsDataGridViewEmpty(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=Workshop; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM activities WHERE 1 = 1";
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (quantity.SelectedItem != null)
                {
                    conditions.Add("quantity = @quantity");
                }

                if (people.SelectedItem != null)
                {
                    conditions.Add("people = @people");
                }

                if (things.SelectedItem != null)
                {
                    conditions.Add("things = @things");
                }

                // Combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values, handling the case where ComboBox is empty
                if (quantity.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity.SelectedItem.ToString());
                }

                if (people.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@people", people.SelectedItem.ToString());
                }

                if (things.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@things", things.SelectedItem.ToString());
                }

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }

        }

        private void dataGridView1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
