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
            this.add_data = new System.Windows.Forms.TextBox();
            this.Data_add = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ArrayBased = new System.Windows.Forms.GroupBox();
            this.TestingArrays = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.TestingArrays.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Data_add);
            this.flowLayoutPanel1.Controls.Add(this.add_data);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(523, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // add_data
            // 
            this.add_data.Location = new System.Drawing.Point(81, 3);
            this.add_data.Name = "add_data";
            this.add_data.Size = new System.Drawing.Size(100, 20);
            this.add_data.TabIndex = 1;
            this.add_data.TextChanged += new System.EventHandler(this.add_data_TextChanged);
            // 
            // Data_add
            // 
            this.Data_add.AutoSize = true;
            this.Data_add.Location = new System.Drawing.Point(8, 5);
            this.Data_add.Margin = new System.Windows.Forms.Padding(8, 5, 16, 0);
            this.Data_add.Name = "Data_add";
            this.Data_add.Size = new System.Drawing.Size(54, 13);
            this.Data_add.TabIndex = 0;
            this.Data_add.Text = "Data_add";
            this.Data_add.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Add);
            this.flowLayoutPanel2.Controls.Add(this.Exit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(699, 471);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 28);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(84, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(3, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ArrayBased
            // 
            this.ArrayBased.Location = new System.Drawing.Point(32, 103);
            this.ArrayBased.Name = "ArrayBased";
            this.ArrayBased.Size = new System.Drawing.Size(602, 101);
            this.ArrayBased.TabIndex = 4;
            this.ArrayBased.TabStop = false;
            this.ArrayBased.Text = "ArrayBased";
            this.ArrayBased.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TestingArrays
            // 
            this.TestingArrays.Controls.Add(this.ArrayBased);
            this.TestingArrays.Controls.Add(this.flowLayoutPanel2);
            this.TestingArrays.Controls.Add(this.flowLayoutPanel1);
            this.TestingArrays.Location = new System.Drawing.Point(12, 12);
            this.TestingArrays.Name = "TestingArrays";
            this.TestingArrays.Size = new System.Drawing.Size(883, 524);
            this.TestingArrays.TabIndex = 2;
            this.TestingArrays.TabStop = false;
            this.TestingArrays.Text = "TestingArrays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.TestingArrays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.TestingArrays.ResumeLayout(false);
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
    }
}

