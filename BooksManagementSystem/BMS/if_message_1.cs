﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class if_message_1 : Form
    {
        public if_message_1()
        {
            InitializeComponent();
            label2.Text = get_number_llm.str_message;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PayForOverdue f1 = new PayForOverdue(get_number_llm.cardnum);
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
