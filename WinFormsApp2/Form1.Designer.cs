namespace WinFormsApp2
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
            btn = new Button();
            txtName = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.ForeColor = Color.IndianRed;
            btn.Location = new Point(461, 262);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 5;
            btn.Text = "Next";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(336, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 167);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(336, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 62);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 7;
            label2.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btn);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private TextBox txtName;
        private Label label1;
        private TextBox txtId;
        private Label label2;
    }
}