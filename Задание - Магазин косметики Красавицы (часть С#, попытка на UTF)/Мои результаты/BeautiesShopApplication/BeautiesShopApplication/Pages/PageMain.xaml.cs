﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BeautiesShopApplication.AppDataFile;
using BeautiesShopApplication.Pages;

namespace BeautiesShopApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btnProbuct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageProduct());
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAddProduct());
        }
    }
}
