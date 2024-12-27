namespace DBMS.SQL.EmployeeSales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dgvEmployeeSales = new DataGridView();
            dgvOrderList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "พนักงาน";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "รายการใบเสร็จ";
            // 
            // dgvEmployeeSales
            // 
            dgvEmployeeSales.AllowUserToAddRows = false;
            dgvEmployeeSales.AllowUserToDeleteRows = false;
            dgvEmployeeSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeSales.Location = new Point(12, 38);
            dgvEmployeeSales.Name = "dgvEmployeeSales";
            dgvEmployeeSales.ReadOnly = true;
            dgvEmployeeSales.Size = new Size(776, 197);
            dgvEmployeeSales.TabIndex = 3;
            dgvEmployeeSales.CellContentClick += dgvEmployeeSales_CellContentClick;
            dgvEmployeeSales.CellMouseUp += dgvEmployeeSales_CellMouseUp;
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.AllowUserToDeleteRows = false;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(12, 270);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.Size = new Size(776, 174);
            dgvOrderList.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrderList);
            Controls.Add(dgvEmployeeSales);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dgvEmployeeSales;
        private DataGridView dgvOrderList;
    }
}
