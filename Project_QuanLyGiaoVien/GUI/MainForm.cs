﻿using QuanLyLichDay.DAO;
using QuanLyLichDay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDay.GUI
{
    public partial class MainForm : Form
    {
        private Account account;
        public MainForm(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void xemLịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
