using System;
using BasedOnArray;
using DynamicArray;
using Common;
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
            int size = 0;
            int numb = 0;
            int capacity = 1;


            while (!int.TryParse(add_data.Text, out size))
            {
                MessageBox.Show("Try again...");
                // Console.WriteLine("Try again..");
            }

            while (!int.TryParse(NumberOfElements.Text, out numb))
            {
                MessageBox.Show("Try again...");
                // Console.WriteLine("Try again..");
            }

            Stopwatch watchArrayQueueAdd = new Stopwatch();
            Stopwatch watchArrayStackPush = new Stopwatch();
            Stopwatch watchDynamicQueueAdd = new Stopwatch();
            Stopwatch watchDynamicStackPush = new Stopwatch();
            //Stopwatch watchLinkedListStackAdd = new Stopwatch();
            //Stopwatch watchEmbeddedStackAdd = new Stopwatch();

            //Stopwatch watchArrayStackRemove = new Stopwatch();
            //Stopwatch watchDynamicArrayStackRemove = new Stopwatch();
            //Stopwatch watchLinkedListStackRemove = new Stopwatch();
            //Stopwatch watchEmbeddedStackRemove = new Stopwatch();


            /***************************************************/
            /***************** Arrays **************************/
            /***************************************************/
            MyQueue<int> ArrayBasedQueue = new MyQueue<int>(size);
            watchArrayQueueAdd.Start();
            for (int i = 0; i < numb; i++)
                {
                    ArrayBasedQueue.Enqueue(1);
                }
                    watchArrayQueueAdd.Stop();
            ArrayQueueResult.Text= String.Format("{0} ms", watchArrayQueueAdd.ElapsedMilliseconds);

            //Stack
            MyStack<int> ArrayBasedStack = new MyStack<int>(size);
            watchArrayStackPush.Start();
            for (int i = 0; i < numb; i++)
            {
                ArrayBasedStack.Push(1);
            }
            watchArrayStackPush.Stop();
            ArrayStackResults.Text = String.Format("{0} ms", watchArrayStackPush.ElapsedMilliseconds);
            




            /***************************************************/
            /*************** Dymamics **************************/
            /***************************************************/

            DynamicQueue<int> dynamicQueue = new DynamicQueue<int>(capacity);
            watchDynamicQueueAdd.Start();
            for (int i = 0; i < numb; i++)
            {
                dynamicQueue.Equeue(1);
            }
            watchDynamicQueueAdd.Stop();
            DynamicQueueResults.Text = String.Format("{0} ms", watchDynamicQueueAdd.ElapsedMilliseconds);

            //watchDynamicStackPush

            DynamicStack<int> dynamicStack = new DynamicStack<int>(capacity);
            watchDynamicStackPush.Start();
            for (int i = 0; i < numb; i++)
            {
                dynamicQueue.Equeue(1);
            }
            watchDynamicStackPush.Stop();
            DynamicStackResult.Text = String.Format("{0} ms", watchDynamicStackPush.ElapsedMilliseconds);



        }

        private void add_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
