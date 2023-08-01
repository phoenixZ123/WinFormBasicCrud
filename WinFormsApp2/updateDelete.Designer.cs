namespace WinFormsApp2
{
    partial class updateDelete
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
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDisplay = new Button();
            txtDeleteName = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdInsert = new TextBox();
            label5 = new Label();
            txtNameInsert = new TextBox();
            btnInsert = new Button();
            btnCount = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlDark;
            btnUpdate.ForeColor = Color.SaddleBrown;
            btnUpdate.Location = new Point(241, 323);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 52);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveCaption;
            btnDelete.Location = new Point(463, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.ActiveCaption;
            btnDisplay.ForeColor = Color.Red;
            btnDisplay.Location = new Point(623, 359);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(131, 55);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // txtDeleteName
            // 
            txtDeleteName.Location = new Point(464, 168);
            txtDeleteName.Name = "txtDeleteName";
            txtDeleteName.Size = new Size(125, 27);
            txtDeleteName.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 267);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(241, 155);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 101);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 221);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 121);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 8;
            label3.Text = " To Delete Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 101);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 10;
            label4.Text = "Id";
            // 
            // txtIdInsert
            // 
            txtIdInsert.Location = new Point(43, 155);
            txtIdInsert.Name = "txtIdInsert";
            txtIdInsert.Size = new Size(143, 27);
            txtIdInsert.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 213);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Name";
            // 
            // txtNameInsert
            // 
            txtNameInsert.Location = new Point(43, 267);
            txtNameInsert.Name = "txtNameInsert";
            txtNameInsert.Size = new Size(143, 27);
            txtNameInsert.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Chartreuse;
            btnInsert.ForeColor = Color.Maroon;
            btnInsert.Location = new Point(43, 325);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(126, 52);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Save";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += button1_Click;
            // 
            // btnCount
            // 
            btnCount.BackColor = SystemColors.ActiveBorder;
            btnCount.Location = new Point(623, 277);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(131, 48);
            btnCount.TabIndex = 14;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(318, 24);
            label6.Margin = new Padding(10, 3, 2, 1);
            label6.Name = "label6";
            label6.Size = new Size(285, 41);
            label6.TabIndex = 15;
            label6.Text = "Customer Information";
            // 
            // updateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(922, 571);
            Controls.Add(label6);
            Controls.Add(btnCount);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(txtNameInsert);
            Controls.Add(label4);
            Controls.Add(txtIdInsert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtDeleteName);
            Controls.Add(btnDisplay);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Name = "updateDelete";
            Text = "insertDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDisplay;
        private TextBox txtDeleteName;
        private TextBox txtName;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdInsert;
        private Label label5;
        private TextBox txtNameInsert;
        private Button btnInsert;
        private Button btnCount;
        private Label label6;
    }
}