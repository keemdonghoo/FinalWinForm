﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                FormUtility.OpenForm(formName, this);
            }
        }

        //메인폼으로 돌아가기
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm != null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string ordername = txtOrderName.Text;

        }
    }
}
