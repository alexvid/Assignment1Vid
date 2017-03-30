using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Models;
using MySql.Data.MySqlClient;

namespace FurnitureManufacturer.DAL
{
    public class DataAccess
    {
        private string connString;

        public DataAccess()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM employee where UserName=\""+ userName +"\";";
                
                MySqlCommand cmd = new MySqlCommand(statement,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        
                        User user = new User();
                        user.ID = reader.GetInt32("Id");
                        user.UserName = reader.GetString("UserName");
                        user.Password = reader.GetString("Password");
                        user.firstName = reader.GetString("FirstName");
                        user.lastName = reader.GetString("LastName");
                        user.IsAdmin = reader.GetBoolean("Admin");
                        return user;
                    }
                }
            }

            return null;
        }
        public void CreateAdmin(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO employee(UserName, Password, FirstName, LastName, IsAdmin) VALUES(@username, @password, @firstname, @lastname, @isadmin, @dateofbirth)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@firstname", user.firstName);
                cmd.Parameters.AddWithValue("@lastname", user.lastName);
                cmd.Parameters.AddWithValue("@isadmin", user.IsAdmin);

                cmd.ExecuteNonQuery();
            }
        }
        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO employee(UserName, Password, FirstName, LastName, Admin) VALUES(@username, @password, @firstname, @lastname, @isadmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@firstname", user.firstName);
                cmd.Parameters.AddWithValue("@lastname", user.lastName);
                cmd.Parameters.AddWithValue("@isadmin", user.IsAdmin);

                cmd.ExecuteNonQuery();
            }
        }
        public int AddProduct(Product product)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(name, price, stock, description) VALUES(@name, @price, @stock, @description)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.Parameters.AddWithValue("@description", product.Description);

                cmd.ExecuteNonQuery();
            }
            return getId("product");

        }
        public int getId(string table) {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT MAX(ID) FROM " + table;
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                 return reader.GetInt32("MAX(ID)");

                return 0;

            }
            
        }
        public int AddToOrder(OrderProducts product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO OrderProducts(IDOrder, IDProduct, Quantity) VALUES(@idorder, @idproduct, @quantity)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idorder", product.IDOrder);
                cmd.Parameters.AddWithValue("@idproduct", product.IDProduct);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

                cmd.ExecuteNonQuery();
            }
            return getId("OrderProducts");
        }
        public int AddOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO order(Customer, Address, DeliveryDate) VALUES(@Customer, @Address, @DeliveryDate)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@customer", order.Customer);
                cmd.Parameters.AddWithValue("@address", order.Address);
                cmd.Parameters.AddWithValue("@deliverydate", order.DeliveryDate.Date);

                cmd.ExecuteNonQuery();
            }
            return getId("order");
        }
        public void AddToHistory(History history)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO history(IDEmployee, IDOperation, TableName,Date) VALUES(@IDEmployee, @IDOperation, @TableName,@Date)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@IDEmployee", history.IDEmployee);
                cmd.Parameters.AddWithValue("@IDOperation", history.IDOperation);
                cmd.Parameters.AddWithValue("@TableName", history.TableName);
                cmd.Parameters.AddWithValue("@Date", history.Date);

                cmd.ExecuteNonQuery();
            }
        }
        public int UpdateOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update order set Customer=@customer,Address=@address,DeliveryDate=@deliverydate  where ID=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", order.ID);
                cmd.Parameters.AddWithValue("@customer", order.Customer);
                cmd.Parameters.AddWithValue("@address", order.Address);
                cmd.Parameters.AddWithValue("@deliverydate", order.DeliveryDate.Date);

                cmd.ExecuteNonQuery();
            }
            return getId("order");
        }
        public int DeleteFromOrder(OrderProducts product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from OrderProducts where IDOrder=@idorder and IDProduct=@idproduct";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idorder", product.IDOrder);
                cmd.Parameters.AddWithValue("@idproduct", product.IDProduct);

                cmd.ExecuteNonQuery();
            }
            return getId("OrderProducts");
        }
        public int DeleteProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from product where ID=@id and name=@name";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@name", product.Name);
               
                cmd.ExecuteNonQuery();
            }
            return getId("product");

        }
        public int UpdateProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update product set name=@name,price=@price,stock=@stock ,description=@description where ID=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.Parameters.AddWithValue("@description", product.Description);

                cmd.ExecuteNonQuery();
            }
            return getId("product");
        }
        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update employee set Password=@password,FirstName=@firstname,LastName=@lastname ,Admin=@isadmin where UserName=@username";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@firstname", user.firstName);
                cmd.Parameters.AddWithValue("@lastname", user.lastName);
                cmd.Parameters.AddWithValue("@isadmin", user.IsAdmin);

                cmd.ExecuteNonQuery();
            }
        }
        public IList<Order> ListOrder(int id)
        {
            IList<Order> orders = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (id != 0)
                {
                    cmd.CommandText = "SELECT * FROM furnituremanufacturer.`order` where ID=@id;";
                    cmd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM furnituremanufacturer.`order` ;";
                }
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Order order = new Order();
                        order.ID = reader.GetInt32("ID");
                        order.Customer = reader.GetString("Customer");
                        order.Address = reader.GetString("Address");
                        order.DeliveryDate = reader.GetDateTime("DeliveryDate");

                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2.Connection = new MySqlConnection(connString);
                        cmd2.Connection.Open();

                        cmd2.CommandText = "SELECT * FROM OrderProducts where IDOrder = @id;";
                        cmd2.Parameters.AddWithValue("@id", order.ID);
                        cmd2.Prepare();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.HasRows)
                            while (reader2.Read())
                            {
                                OrderProducts orderproduct = new OrderProducts();
                                orderproduct.IDProduct = reader2.GetInt32("IDProduct");
                                orderproduct.IDOrder = reader2.GetInt32("IDOrder");
                                orderproduct.Quantity = reader2.GetInt32("Quantity");

                                MySqlCommand cmd3 = new MySqlCommand();
                                cmd3.Connection = new MySqlConnection(connString);
                                cmd3.Connection.Open();
                                cmd3.CommandText = "SELECT price FROM product where ID = @id;";
                                cmd3.Parameters.AddWithValue("@id", orderproduct.IDProduct);
                                cmd3.Prepare();
                                MySqlDataReader reader3 = cmd3.ExecuteReader();
                                reader3.Read();
                                float price = reader3.GetFloat("price");
                                order.Total += price * orderproduct.Quantity;
                            }

                        orders.Add(order);
                    }
                }
            }

            return orders;
        }
        public IList<OrderProducts> ListOrderProducts(int id)
        {
            IList<OrderProducts> orders = new List<OrderProducts>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (id != 0)
                {
                    cmd.CommandText = "SELECT * FROM furnituremanufacturer.`OrderProducts` where IDOrder=@id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    

                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            OrderProducts order = new OrderProducts();
                            order.IDProduct = reader.GetInt32("IDProduct");
                            order.Quantity = reader.GetInt32("Quantity");


                            orders.Add(order);
                        }
                    }
                }
            }
            return orders;
        }
        public IList<Product> ListProduct(int ID)
        {
            IList<Product> products = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (ID != 0)
                {
                    cmd.CommandText = "SELECT * FROM product where ID = @id;";
                    cmd.Parameters.AddWithValue("@id", ID);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM product ;";
                }
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Product product = new Product();
                        product.ID = reader.GetInt32("ID");
                        product.Name = reader.GetString("name");
                        product.Price = reader.GetFloat("price");
                        product.Stock = reader.GetInt32("stock");
                        product.Description = reader.GetString("description");

                        products.Add(product);
                    }
                }
            }

            return products;
        }
        public IList<History> ListHistory(int id)
        {
            IList<History> history = new List<History>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (id != 0)
                {
                    cmd.CommandText = "SELECT * FROM history where IDEmployee=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM history ;";
                }
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        History  histo = new History();
                        histo.ID = reader.GetInt32("ID");
                        histo.IDEmployee = reader.GetInt32("IDEmployee");
                        histo.IDOperation = reader.GetInt32("IDOperation");
                        histo.TableName = reader.GetString("TableName");
                        histo.Date = reader.GetDateTime("Date");
                        history.Add(histo);
                    }
                }
            }

            return history;
        }
        public IList<User> ListUser(string username)
        {
            IList<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (username != "")
                {
                    cmd.CommandText = "SELECT * FROM employee where UserName=\"" + username + "\";";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM employee ;";
                }
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        User user = new User();
                        user.ID = reader.GetInt32("Id");
                        user.UserName = reader.GetString("UserName");
                        user.Password = reader.GetString("Password");
                        user.firstName = reader.GetString("FirstName");
                        user.lastName = reader.GetString("LastName");
                        user.IsAdmin = reader.GetBoolean("Admin");
                        users.Add(user);
                    }
                }
            }

            return users;
        }
        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from employee where UserName=@username and Password=@password";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);

                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
