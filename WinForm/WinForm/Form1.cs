﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            int d = 0;

            while (!int.TryParse(add_data_TextChanged, out d))
            {
                Console.WriteLine("Try again..");
            }

                       
                Stopwatch watchArrayStackAdd = new Stopwatch();
                //Stopwatch watchDynamicArrayStackAdd = new Stopwatch();
                //Stopwatch watchLinkedListStackAdd = new Stopwatch();
                //Stopwatch watchEmbeddedStackAdd = new Stopwatch();

                //Stopwatch watchArrayStackRemove = new Stopwatch();
                //Stopwatch watchDynamicArrayStackRemove = new Stopwatch();
                //Stopwatch watchLinkedListStackRemove = new Stopwatch();
                //Stopwatch watchEmbeddedStackRemove = new Stopwatch();

                //Array based
                watchArrayStackAdd.Start();
                var newArrayBasedStack = new MyStack<int>(size);
                for (int i = 0; i < size; i++)
                {
                    newArrayBasedStack.Push(123);
                }
                watchArrayStackAdd.Stop();
                resultValueAddArrayBasedStackLabel.Text = String.Format("{0} ms", watchArrayStackAdd.ElapsedMilliseconds);

                watchArrayStackRemove.Start();
                int tempValue1 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue1 = newArrayBasedStack.Pop();
                }
                watchArrayStackRemove.Stop();
                resultValueRemoveArrayBasedStackLabel.Text = String.Format("{0} ms", watchArrayStackRemove.ElapsedMilliseconds);



            }

        private void add_data_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
