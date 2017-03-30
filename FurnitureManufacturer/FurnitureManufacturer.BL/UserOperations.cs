using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.DAL;
using FurnitureManufacturer.Models;
using System.Configuration;

namespace FurnitureManufacturer.BL
{
    public class UserOperations
    {
        public User Login(string userName, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(userName);
            if (user!=null)
            {
                Security secure = new Security();
                if(secure.VerifyHash(password, user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }
        public int AddProduct(Product product)
        {
            

            DataAccess dal = new DataAccess();
            return dal.AddProduct(product);
        }
        public int UpdateProduct(Product product)
        {


            DataAccess dal = new DataAccess();
            return dal.UpdateProduct(product);
        }
        public int DeleteProduct(Product product)
        {


            DataAccess dal = new DataAccess();
            return dal.DeleteProduct(product);
        }
        public void AddToHistory(History history)
        {


            DataAccess dal = new DataAccess();
            dal.AddToHistory(history);
        }
        public int AddToOrder(OrderProducts product)
        {


            DataAccess dal = new DataAccess();
            return dal.AddToOrder(product);
        }
        public int AddOrder(Order order)
        {


            DataAccess dal = new DataAccess();
            return dal.AddOrder(order);
        }
        public int UpdateOrder(Order order)
        {


            DataAccess dal = new DataAccess();
            return dal.UpdateOrder(order);
        }
        public int DeleteFromOrder(OrderProducts product)
        {


            DataAccess dal = new DataAccess();
            return dal.DeleteFromOrder(product);
        }
        public void DeleteUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccess dal = new DataAccess();
            dal.DeleteUser(user);
        }
        public void UpdateUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccess dal = new DataAccess();
            dal.UpdateUser(user);
        }
        public IList<Product> ListProduct(Product product)
        {
            IList<Product> products = new List<Product>();


            DataAccess dal = new DataAccess();
            products = dal.ListProduct(product.ID);

            return products;
        }
        public IList<Order> ListOrder(Order order)
        {
            IList<Order> orders = new List<Order>();


            DataAccess dal = new DataAccess();
            orders = dal.ListOrder(order.ID);

            return orders;
        }
        public IList<OrderProducts> ListOrderProducts(Order order)
        {
            IList<OrderProducts> orders = new List<OrderProducts>();


            DataAccess dal = new DataAccess();
            orders = dal.ListOrderProducts(order.ID);

            return orders;
        }
        public IList<User> ListUser(User user)
        {
            IList<User> users = new List<User>();


            DataAccess dal = new DataAccess();
            users=dal.ListUser(user.UserName);

            return users;
        }
        public IList<History> ListHistory(int id)
        {
            IList<History> history = new List<History>();


            DataAccess dal = new DataAccess();
            history = dal.ListHistory(id);

            return history;
        }

    }
}
