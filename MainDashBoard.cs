using System.Data;
using ITI_EF_WorkShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITI_EF_WorkShop
{

    public partial class MainDashBoard : Form
    {
        Trackercontext tracker = new Trackercontext();

        private int _userId;

        public MainDashBoard(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        public MainDashBoard()
        {
            InitializeComponent();
            InitializeChart();

        }
       
        private void InitializeChart()
        {
            var categorySum = tracker.transactions.Where(t => t.UserID == _userId)
                    .GroupBy(t => t.Category.CategoryName)
                    .Select(group => new
                                        {
                                            CategoryName = group.Key,
                                            totalAmount = group.Sum(t =>t.Amount)
                                        } ).ToList();   

            chart1.Series.Clear();

            var series = new Series 
            { 
                Name = "Series1",
                IsVisibleInLegend = true, 
                ChartType = SeriesChartType.Bar ,

            };

            chart1.Series.Add(series);

            foreach (var category in categorySum)
            {
                series.Points.AddXY(category.CategoryName, category.totalAmount);
            }

            chart1.ChartAreas[0].AxisX.Title = "Category";
            chart1.ChartAreas[0].AxisY.Title = "Total Amount";

            // Rotate the X-axis labels for better readability
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            // Ensure all labels are displayed
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Increase margins for better spacing
            chart1.ChartAreas[0].Position.Auto = false;
            chart1.ChartAreas[0].Position.Width = 90;
            chart1.ChartAreas[0].Position.Height = 90;

            // Customize font for X-axis labels
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            // Adjust Y-axis range (optional)
            chart1.ChartAreas[0].AxisY.Minimum = 0;

        }
       
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void MainDashBoard_Load(object sender, EventArgs e)
        {
            dataGridView2.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;


            // Category tab 

            var tracker01 = tracker.Categories.ToList();
            dataGridView1.DataSource = tracker01;

            //Category comboBox

            var transactioncombo = tracker.Categories.ToList();

            foreach (var category in transactioncombo)
            {
                Categortcombo.Items.Add(category.CategoryName);
                comboBox1.Items.Add(category.CategoryName);
            }


            // Category comboBox

            var categories = tracker.Categories.ToList();

            Categortcombo.DataSource = categories;
            Categortcombo.DisplayMember = "CategoryName";
            Categortcombo.ValueMember = "CategoryID";

            typecombo.Items.Add("Expenses");
            typecombo.Items.Add("Income");

            comboBox2.Items.Add("High");
            comboBox2.Items.Add("Medium");
            comboBox2.Items.Add("Low");

            Addtransaction();
            SummaryLoad();
            InitializeChart();


        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void categorytab_Click(object sender, EventArgs e)
        {


        }

        private void SummaryLoad()
        {
            var trackersummary = tracker.transactions.Where(t => (t.UserID == _userId && t.TransactionType == "Income"))
                                   .Select(t => t.Amount).Sum();
            var tracksummary02 = (decimal)tracker.Users.Where(u => u.UserID == _userId).Select(I => I.Income).FirstOrDefault();

            var totalIncome = trackersummary + tracksummary02;

            label1.Text = totalIncome.ToString();

            // expenses

            var trackersummaryExpens = tracker.transactions.Where(t => (t.UserID == _userId && t.TransactionType == "Expenses"))
                                   .Select(t => t.Amount).Sum();

            label2.Text = trackersummaryExpens.ToString();

            // Remaining 

            var Remainig = totalIncome - trackersummaryExpens;
            label3.Text = Remainig.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Categoryselected = comboBox2.SelectedItem.ToString();
            Category category01 = new Category()
            {
                CategoryName = textBox11.Text.ToLower(),
                Priority = Categoryselected

            };

            tracker.Categories.Add(category01);
            tracker.SaveChanges();
            MessageBox.Show("Category Added Successfully", "success",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            CategoryDisplay();
        } //add category


        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string removedCategory = comboBox1.SelectedItem.ToString();
                var deleteCategory = tracker.Categories
                                           .FirstOrDefault(c => c.CategoryName == removedCategory);

                if (deleteCategory != null)
                {
                    // Check if the category is associated with any transactions
                    bool hasTransactions = tracker.transactions.Any(t => t.CategoryID == deleteCategory.CategoryID);

                    if (hasTransactions)
                    {
                        MessageBox.Show("This category is associated with transactions and cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    tracker.Categories.Remove(deleteCategory);
                    tracker.SaveChanges();

                    MessageBox.Show("Category Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh category list and comboBoxes
                    CategoryDisplay();
                }
                else
                {
                    MessageBox.Show("Selected category not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No category selected. Please select a category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } //remove category

        private void CategoryDisplay()
        {
            var tracker01 = tracker.Categories.ToList();
            dataGridView1.DataSource = tracker01;
            tracker.SaveChanges();
            Categortcombo.DataSource = tracker01;
            Categortcombo.DisplayMember = "CategoryName";
            Categortcombo.ValueMember = "CategoryID";

            comboBox1.Items.Clear();
            foreach (var category in tracker01)
            {
                comboBox1.Items.Add(category.CategoryName);
            }

            tracker.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int transactionId;

            if (int.TryParse(textBox9.Text, out transactionId))
            {
                var transaction = tracker.transactions.FirstOrDefault(t => t.TransactionID == transactionId);

                if (transaction != null)
                {
                    tracker.transactions.Remove(transaction);
                    tracker.SaveChanges();
                    MessageBox.Show("Transaction has been removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Transaction ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Addtransaction();
            CategoryDisplay();
            SummaryLoad();
            InitializeChart();


        }        // Remove transaction 


        private void button1_Click(object sender, EventArgs e)
        {

            if (Categortcombo.SelectedValue == null || typecombo.SelectedItem == null)
            {
                MessageBox.Show("Please select both a category and transaction type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CategoryId = (int)Categortcombo.SelectedValue;

            string selectedCategory = typecombo.SelectedItem.ToString();


            Transaction transaction01 = new Transaction()
            {
                Amount = decimal.Parse(textBox8.Text.ToLower()),
                TransactionDate = DateTime.Parse(dateTimePicker1.Text),
                CategoryID = CategoryId,
                TransactionType = typecombo.SelectedItem.ToString(),
                UserID = _userId

            };

            tracker.transactions.Add(transaction01);
            tracker.SaveChanges();

            MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Addtransaction();
            CategoryDisplay();
            SummaryLoad();
            InitializeChart();
        }   // add transaction button

        private void Addtransaction()
        {
            var userTransactions = tracker.transactions.Where(t => t.UserID == _userId).
                           Select(t => new
                           {
                               t.TransactionID,
                               t.Category.CategoryName,
                               t.Amount,
                               t.TransactionType,
                               t.TransactionDate
                           }).ToList();

            dataGridView2.DataSource = userTransactions;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var userTransactions = tracker.transactions.Where(t => t.UserID == _userId).
                Select(t => new
                {
                    t.TransactionID,
                    t.Category.CategoryName,
                    t.Amount,
                    t.TransactionType,
                    t.TransactionDate
                }).ToList();

            dataGridView2.DataSource = userTransactions;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }   // displaydata in textbox

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    textBox8.Text = selectedRow.Cells["Amount"].Value?.ToString();
                    dateTimePicker1.Value = selectedRow.Cells["TransactionDate"].Value != null
                        ? Convert.ToDateTime(selectedRow.Cells["TransactionDate"].Value)
                        : DateTime.Now;
                    Categortcombo.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
                    typecombo.Text = selectedRow.Cells["TransactionType"].Value?.ToString();
                    textBox9.Text = selectedRow.Cells["TransactionID"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    textBox11.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
                    comboBox1.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
                    comboBox2.Text = selectedRow.Cells["Priority"].Value?.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button6_Click_1(object sender, EventArgs e) // Update Transaction
        {
            if (Categortcombo.SelectedValue == null || typecombo.SelectedItem == null)
            {
                MessageBox.Show("Please select both a category and transaction type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int transactionId;
            if (!int.TryParse(textBox9.Text, out transactionId))
            {
                MessageBox.Show("Invalid Transaction ID. Please ensure a valid transaction is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transaction = tracker.transactions.FirstOrDefault(t => t.TransactionID == transactionId);

            if (transaction == null)
            {
                MessageBox.Show("Transaction not found. Please ensure a valid transaction is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the transaction fields
            transaction.Amount = decimal.Parse(textBox8.Text);
            transaction.TransactionDate = DateTime.Parse(dateTimePicker1.Text);
            transaction.CategoryID = (int)Categortcombo.SelectedValue;
            transaction.TransactionType = typecombo.SelectedItem.ToString();

            tracker.SaveChanges();

            MessageBox.Show("Transaction updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Addtransaction();
            CategoryDisplay();
            SummaryLoad();
        }

        private void summarytab_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}



