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
using System.Text.RegularExpressions;

namespace SimpleDataApp
{
    public partial class FillOrCancel : Form
    {
        // ID tut
        private int parsedOrderID;

        //ID kontrol et
        private bool IsOrderIDValid()
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }

            //int kontrolü
            else if (Regex.IsMatch(txtOrderID.Text, @"^\D*$"))
            {
                MessageBox.Show("Customer ID must contain only numbers.");
                txtOrderID.Clear();
                return false;
            }
            else
            {
                parsedOrderID = Int32.Parse(txtOrderID.Text);
                return true;
            }
        }
        public FillOrCancel()
        {
            InitializeComponent();
        }

        private void btnFindByOrderID_Click(object sender, EventArgs e)
        
            {
                if (IsOrderIDValid())
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        const string sql = "SELECT * FROM Sales.Orders WHERE orderID = @orderID";

                        using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                        {
                            sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                            sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                            try
                            {
                                connection.Open();

                                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                                {
                                    DataTable dataTable = new DataTable();

                                    dataTable.Load(dataReader);

                                    this.dgvCustomerOrders.DataSource = dataTable;

                                    dataReader.Close();
                                }
                            }
                            catch
                            {
                                MessageBox.Show("The requested order could not be loaded into the form.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspCancelOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("The cancel operation was not completed.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnFillOrder_Click(object sender, EventArgs e)
        
            {
                if (IsOrderIDValid())
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("Sales.uspFillOrder", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // order ID yi tut
                            sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                            sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                            // siparişin tamamlnadığı günü tut
                            sqlCommand.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
                            sqlCommand.Parameters["@FilledDate"].Value = dtpFillDate.Value;

                            try
                            {
                                connection.Open();

                                sqlCommand.ExecuteNonQuery();
                            }
                            catch
                            {
                                MessageBox.Show("The fill operation was not completed.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }

        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
