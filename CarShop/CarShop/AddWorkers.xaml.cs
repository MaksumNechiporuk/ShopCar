﻿using ServiceDLL.Concrete;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarShop
{
    /// <summary>
    /// Interaction logic for AddWorkers.xaml
    /// </summary>
    public partial class AddWorkers : Window
    {
        public AddWorkers()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            UserApiService userService = new UserApiService();
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                var res = userService.Login(new UserLoginVM { Email = txtEmail.Text, Password = txtPassword.Text });
                if (res == 1)
                {
                    MessageBox.Show("Ви успішно зареєструвались.");
                }
                else
                {
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                }
            }
        }
    }
}
