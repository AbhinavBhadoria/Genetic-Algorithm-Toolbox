﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void FunctionMaximizeLB_Click(object sender, EventArgs e)
        {
            Form userForm = new UserInput();
            userForm.Show();
        }

        
        private void TspLB_Click(object sender, EventArgs e)
        {
            Form tspInputForm = new TSPInput();
            tspInputForm.Show();
        }
    }
}
