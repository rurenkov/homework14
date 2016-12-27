namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Data_add = new System.Windows.Forms.Label();
            this.add_data = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ArrayBased = new System.Windows.Forms.GroupBox();
            this.TestingArrays = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.AmountElements = new System.Windows.Forms.Label();
            this.NumberOfElements = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.ArrayQueueResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrayStackResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DynamicArrayBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.ArrayBased.SuspendLayout();
            this.TestingArrays.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DynamicArrayBox.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Data_add);
            this.flowLayoutPanel1.Controls.Add(this.add_data);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Data_add
            // 
            this.Data_add.AutoSize = true;
            this.Data_add.Location = new System.Drawing.Point(8, 5);
            this.Data_add.Margin = new System.Windows.Forms.Padding(8, 5, 16, 0);
            this.Data_add.Name = "Data_add";
            this.Data_add.Size = new System.Drawing.Size(73, 13);
            this.Data_add.TabIndex = 0;
            this.Data_add.Text = "Size of Buffer:";
            this.Data_add.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_data
            // 
            this.add_data.Location = new System.Drawing.Point(132, 3);
            this.add_data.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.add_data.Name = "add_data";
            this.add_data.Size = new System.Drawing.Size(100, 20);
            this.add_data.TabIndex = 1;
            this.add_data.Text = "100000";
            this.add_data.TextChanged += new System.EventHandler(this.add_data_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Add);
            this.flowLayoutPanel2.Controls.Add(this.Exit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(816, 49);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(94, 88);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(10, 10);
            this.Add.Margin = new System.Windows.Forms.Padding(10);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(10, 53);
            this.Exit.Margin = new System.Windows.Forms.Padding(10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ArrayBased
            // 
            this.ArrayBased.Controls.Add(this.flowLayoutPanel4);
            this.ArrayBased.Controls.Add(this.flowLayoutPanel5);
            this.ArrayBased.Location = new System.Drawing.Point(11, 19);
            this.ArrayBased.Name = "ArrayBased";
            this.ArrayBased.Size = new System.Drawing.Size(228, 129);
            this.ArrayBased.TabIndex = 4;
            this.ArrayBased.TabStop = false;
            this.ArrayBased.Text = "ArrayBased";
            this.ArrayBased.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TestingArrays
            // 
            this.TestingArrays.Controls.Add(this.groupBox1);
            this.TestingArrays.Controls.Add(this.flowLayoutPanel3);
            this.TestingArrays.Controls.Add(this.flowLayoutPanel2);
            this.TestingArrays.Controls.Add(this.flowLayoutPanel1);
            this.TestingArrays.Location = new System.Drawing.Point(12, 12);
            this.TestingArrays.Name = "TestingArrays";
            this.TestingArrays.Size = new System.Drawing.Size(948, 566);
            this.TestingArrays.TabIndex = 2;
            this.TestingArrays.TabStop = false;
            this.TestingArrays.Text = "TestingArrays";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.AmountElements);
            this.flowLayoutPanel3.Controls.Add(this.NumberOfElements);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(32, 104);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(265, 33);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // AmountElements
            // 
            this.AmountElements.AutoSize = true;
            this.AmountElements.Location = new System.Drawing.Point(8, 5);
            this.AmountElements.Margin = new System.Windows.Forms.Padding(8, 5, 16, 0);
            this.AmountElements.Name = "AmountElements";
            this.AmountElements.Size = new System.Drawing.Size(104, 13);
            this.AmountElements.TabIndex = 0;
            this.AmountElements.Text = "Number of elements:";
            // 
            // NumberOfElements
            // 
            this.NumberOfElements.Location = new System.Drawing.Point(131, 3);
            this.NumberOfElements.Name = "NumberOfElements";
            this.NumberOfElements.Size = new System.Drawing.Size(100, 20);
            this.NumberOfElements.TabIndex = 1;
            this.NumberOfElements.Text = "1000000";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArrayQueueResult";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ArrayQueueResult
            // 
            this.ArrayQueueResult.AutoSize = true;
            this.ArrayQueueResult.Location = new System.Drawing.Point(102, 10);
            this.ArrayQueueResult.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ArrayQueueResult.Name = "ArrayQueueResult";
            this.ArrayQueueResult.Size = new System.Drawing.Size(0, 13);
            this.ArrayQueueResult.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.ArrayQueueResult);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(26, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(179, 34);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Controls.Add(this.ArrayStackResult);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(26, 74);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(179, 34);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ArrayStackResult";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArrayStackResult
            // 
            this.ArrayStackResult.AutoSize = true;
            this.ArrayStackResult.Location = new System.Drawing.Point(105, 10);
            this.ArrayStackResult.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.ArrayStackResult.Name = "ArrayStackResult";
            this.ArrayStackResult.Size = new System.Drawing.Size(0, 13);
            this.ArrayStackResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DynamicArrayBox);
            this.groupBox1.Controls.Add(this.ArrayBased);
            this.groupBox1.Location = new System.Drawing.Point(32, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Results";
            // 
            // DynamicArrayBox
            // 
            this.DynamicArrayBox.Controls.Add(this.flowLayoutPanel6);
            this.DynamicArrayBox.Controls.Add(this.flowLayoutPanel7);
            this.DynamicArrayBox.Location = new System.Drawing.Point(269, 19);
            this.DynamicArrayBox.Name = "DynamicArrayBox";
            this.DynamicArrayBox.Size = new System.Drawing.Size(228, 129);
            this.DynamicArrayBox.TabIndex = 5;
            this.DynamicArrayBox.TabStop = false;
            this.DynamicArrayBox.Text = "DynamicArrayBased";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(26, 19);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(179, 34);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DynamicQueueResult";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.label6);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(26, 74);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(179, 34);
            this.flowLayoutPanel7.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DynamicStackResult";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 612);
            this.Controls.Add(this.TestingArrays);
            this.Name = "Form1";
            this.Text = "Mega App";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ArrayBased.ResumeLayout(false);
            this.TestingArrays.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.DynamicArrayBox.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Data_add;
        private System.Windows.Forms.TextBox add_data;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox ArrayBased;
        public System.Windows.Forms.GroupBox TestingArrays;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label AmountElements;
        private System.Windows.Forms.TextBox NumberOfElements;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArrayQueueResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ArrayStackResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DynamicArrayBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

