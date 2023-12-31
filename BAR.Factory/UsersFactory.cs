﻿using BAR.Core.Classes;
using BAR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Factory
{
    public class UsersFactory
    {
        ApplicationDbContext _dbContext;
        public UsersFactory()
        {
            _dbContext = new ApplicationDbContext();
        }
        public bool IsAuthorized(User user)
        {
            user.Password = DataEncryption.Encrypt(user.Password, DataEncryption.CryptoKey);

            //var userData = _dbContext.Users.FirstOrDefault(p => p.UserName == user.UserName);
            var userData = (from u in _dbContext.Users
                            where u.UserName == user.UserName && u.Password == user.Password
                            select u
                            ).FirstOrDefault();

            if (userData != null)
            {
                if (!userData.IsActive)
                    return false;
                else
                {
                    RuntimeInfo.UserName = userData.UserName;
                    RuntimeInfo.Name = string.Format("{0} {1} {2}", userData.FirstName, userData.MiddleName.Substring(0, 1) + ".", userData.LastName);
                    RuntimeInfo.isAdmin = userData.IsAdmin;

                    if (userData.IsAdmin)
                        RuntimeInfo.Menu = (from m in _dbContext.MenuNavigations
                                            where m.IsForAdmin == true select m).ToList();
                    else
                        RuntimeInfo.Menu = (from m in _dbContext.MenuNavigations
                                            where m.IsForClient == true
                                            select m).ToList();

                    return true;
                }
            }
            else
                return false;

        }

        public void CreateInitialData()
        {
            return;
            //User user = new User()
            //{
            //    IsActive = true,
            //    IsAdmin = true,
            //    CreatedBy = "1",
            //    CreatedDate = DateTime.Now,
            //    FirstName = "Jiks",
            //    Grade = "",
            //    LastLoginDate = DateTime.Now,
            //    LastModifiedBy = "1",
            //    LastModifiedDate = DateTime.Now,
            //    LastName = "Dannug",
            //    LastPasswordChange = DateTime.Now,
            //    MiddleName = "Moralla",
            //    Password = DataEncryption.Encrypt("123456", DataEncryption.CryptoKey),
            //    Phone = "09750874910",
            //    Position = "Teacher",
            //    ProfileImagePath = "",
            //    Section = "I",
            //    UserName = "admin"
            //};

            //_dbContext.Users.Add(user);

            MenuNavigation m = new MenuNavigation(){
            IsForAdmin = true,
             isDeleted = false,
             IsForClient = true,
             MenuOrder = _dbContext.MenuNavigations.Max(p => p.MenuOrder) + 1,
             ParentId = 0,
             Title = "Quizlet"
            };

            _dbContext.MenuNavigations.Add(m);

            _dbContext.SaveChanges();

        }
    }
}
