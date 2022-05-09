﻿using EmployeesMonitoringSystem.Ui.Controllers;
using System;
using System.Windows.Forms;

namespace EmployeesMonitoringSystem.Ui.Forms
{
    public partial class LogInForm : Form
    {
        private LogInController Ctrl;

        public LogInForm(LogInController ctrl)
        {
            Ctrl = ctrl;
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            try
            {
                Ctrl.LogIn(username, password);
                switch (Ctrl.CrtEmployee.Jobtitle)
                {
                    case Model.JobTitle.ADMIN:
                        AdminController ctrl = new AdminController(Ctrl.Service, Ctrl.CrtEmployee);
                        AdminForm form = new AdminForm(ctrl);
                        form.Text = "Admin";
                        form.Show();
                        this.Hide();
                        break;
                    case Model.JobTitle.BOSS:
                        throw new NotImplementedException();
                    case Model.JobTitle.WORKER:
                        throw new NotImplementedException();
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Log in error " + ex.Message);
                return;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e) { }
    }
}
