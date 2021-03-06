﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Startup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IKernel _kernel;

        public App() : base()
        {
            _kernel = new StandardKernel();
            InitKernel();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            StartWpfFrontEnd();
        }

        private void InitKernel()
        {
            
        }

        private void StartWpfFrontEnd()
        {
            var window = _kernel.Get<WpfFrontend.Windows.MainWindow>();
            window.Show();
        }
    }
}
