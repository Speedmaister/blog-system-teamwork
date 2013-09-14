﻿using BlogSystemClient.Commands;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogSystemClient.ViewModels
{
    public class UserViewModel : UserModel
    {
        private ICommand loginCommand;
        public string SessionKey { get; set; }

        public ICommand Login
        {
            get
            {
                if (this.loginCommand == null)
                {
                    this.loginCommand = new RelayCommand(this.HandleLoginCommand);
                }

                return this.loginCommand;
            }
        }

        private void HandleLoginCommand(object obj)
        {

        }
    }
}