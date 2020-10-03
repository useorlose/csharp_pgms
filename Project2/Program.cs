using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
     interface ICustomerManager
    {
        bool AddNewCustomer(Customer c);
        bool DeleteCustomerID(int id);
        bool UpdateCustomer(Customer c);
        Book[] GetAllCustomers(string name);
    }

    class Customer : ICustomerManager
    {

        private Customer[] allcustomers = null;

        private bool hasCustomerID(int id)
        {
            foreach (Customer c in allcustomers)
            {
                if ((c != null) && (c.CustomerId == id))
                    return true;
            }
            return false;

        }
        
        public CustomerManager(int size)
        {
            allcustomers = new Customer[size];
        }
        public bool AddNewCustomer(Customer c)
        {
            bool available = hasCustomerId(c.CustomerID);
            if (available)
                throw new Exception("already exists");
            for (int i = 0; i < allcustomers.Length; i++)
            {
                
                if (allcustomers[i] == null)
                {
                    allcustomers[i] = new Customer();
                    allcustomers[i].CustomerID = c.CustomerID;
                    allcustomers[i].Name = c.Name;
                    allcustomers[i].Address= c.Address;
                    allcustomers[i].Phone = c.phone;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            for (int i = 0; i < allcustomers.Length; i++)
            {
                ..
                if ((allcustomers[i] != null) && (allcustomers[i].CustomerID == id))
                {
                    allcustomers[i] = null;
                    return true;
                }
            }
            return false;
        }

        public Customers[] GetAllCustomers(string title)
        {
            /
            Customer[] copy = new Customer[allCustomers.Length];
            
            int index = 0;
            foreach (Customer bk c allcustomers)
            {
              
                if ((c != null) && (c.id.Contains(id)))
                {
                    copy[index] = bk;
                    index++;
                }
            }

     .
            return copy;
        }

        public bool UpdateCustomer(Customer c)
        {
            for (int i = 0; i < allcustomers.Length; i++)
            {
                
                if ((allcustomers[i] != null) && (allcustomers[i].customerID == c.customerID))
                {
                    allcustomers[i].Name = c.Name
                
                    return true;
                }
            }
            return false;
        }
    }
    class Customer
    {
        public int Customer { get; set; }
        
        public string CustomerName { get; set; }
        public double CustomerId{ get; set; }
   
   
          static void Main(string[] args)
        {
            int choice = Console.ReadLine();
       
            switch (choice)
            {
                case "1":
                    adding();
                    break;
                case "2":
                    updating();
                    break;
                case "3":
                    deleting();
                    break;
                case "4":
                    getAll();
                    break;
                default:
                    return false;
            }
            return true;
        }

       
        private static void deleteCustomerId()
        {
            int id = MyConsole.getNumber("Enter the ID ");
            if (c.DeleteCustomer(id))
                Console.WriteLine("Customer Deleted successfully");
            else
                Console.WriteLine("Could not find the Customer to delete");
        }


              }
    }
}





