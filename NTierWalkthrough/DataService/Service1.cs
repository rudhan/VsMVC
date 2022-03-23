using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{    
    public class Service1 : IService1
    {
        public DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            return CustomersTableAdapter1.GetCustomers();
        }
        public DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            return OrdersTableAdapter1.GetOrders();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
