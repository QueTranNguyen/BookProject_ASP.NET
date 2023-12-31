﻿using BookStore.Models;
using BusinessObjects;
using DataAccess;
using DatAccess;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public void DeleteUserById(AppUser user) => UserDAO.DeleteUser(user);

        public AppUser GetUserById(string id) => UserDAO.FindUserById(id);

        public List<AppUser> GetUsers() => UserDAO.GetUsers();

        public AppUser SaveUser(AppUser user) => UserDAO.SaveUser(user);

        public AppUser UpdateUser(AppUser user) => UserDAO.UpdateUser(user);     
        public List<Order> GetOrders(string user) => UserDAO.GetOrders(user);     
        public List<OrderDetail> GetOrderDetail(int order, string user) => UserDAO.GetOrderDetails(order, user);     
    }
}
