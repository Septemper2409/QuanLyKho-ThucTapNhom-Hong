﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.DAO;
namespace QLKho.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(txtPass.Text) | string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Hãy điền đẩy đủ mật khẩu và tên đăng nhập trước!!");
                return;
            }
            else
            {
                userDAO user = new userDAO();
                int result  =  user.login(txtUser.Text, txtPass.Text);
                if (result != 0)
                {
                    frmmenu frmmenu = new frmmenu();
                    frmmenu.Show();
                }
                //show loi
            }
        }

        private void chkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienthi.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
