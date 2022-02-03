namespace Activity_14
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateCbx = new System.Windows.Forms.CheckBox();
            this.nameCbx = new System.Windows.Forms.CheckBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.DrawRes = new System.Windows.Forms.RichTextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.FillRbtn = new System.Windows.Forms.RadioButton();
            this.OutlineRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.listBox1.Location = new System.Drawing.Point(30, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 100);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutlineRbtn);
            this.groupBox1.Controls.Add(this.FillRbtn);
            this.groupBox1.Location = new System.Drawing.Point(30, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select fill mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateCbx);
            this.groupBox2.Controls.Add(this.nameCbx);
            this.groupBox2.Location = new System.Drawing.Point(30, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select details";
            // 
            // dateCbx
            // 
            this.dateCbx.AutoSize = true;
            this.dateCbx.Location = new System.Drawing.Point(6, 56);
            this.dateCbx.Name = "dateCbx";
            this.dateCbx.Size = new System.Drawing.Size(58, 20);
            this.dateCbx.TabIndex = 1;
            this.dateCbx.Text = "Date";
            this.dateCbx.UseVisualStyleBackColor = true;
            // 
            // nameCbx
            // 
            this.nameCbx.AutoSize = true;
            this.nameCbx.Location = new System.Drawing.Point(6, 21);
            this.nameCbx.Name = "nameCbx";
            this.nameCbx.Size = new System.Drawing.Size(66, 20);
            this.nameCbx.TabIndex = 0;
            this.nameCbx.Text = "Name";
            this.nameCbx.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // DrawRes
            // 
            this.DrawRes.Location = new System.Drawing.Point(257, 22);
            this.DrawRes.Name = "DrawRes";
            this.DrawRes.Size = new System.Drawing.Size(678, 505);
            this.DrawRes.TabIndex = 3;
            this.DrawRes.Text = "";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(592, 530);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(36, 16);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "Date";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(592, 546);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(44, 16);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(141, 401);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(89, 32);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FillRbtn
            // 
            this.FillRbtn.AutoSize = true;
            this.FillRbtn.Location = new System.Drawing.Point(10, 21);
            this.FillRbtn.Name = "FillRbtn";
            this.FillRbtn.Size = new System.Drawing.Size(45, 20);
            this.FillRbtn.TabIndex = 0;
            this.FillRbtn.TabStop = true;
            this.FillRbtn.Text = "Fill";
            this.FillRbtn.UseVisualStyleBackColor = true;
            // 
            // OutlineRbtn
            // 
            this.OutlineRbtn.AutoSize = true;
            this.OutlineRbtn.Location = new System.Drawing.Point(10, 56);
            this.OutlineRbtn.Name = "OutlineRbtn";
            this.OutlineRbtn.Size = new System.Drawing.Size(69, 20);
            this.OutlineRbtn.TabIndex = 1;
            this.OutlineRbtn.TabStop = true;
            this.OutlineRbtn.Text = "Outline";
            this.OutlineRbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 571);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.DrawRes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Shape Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox dateCbx;
        private System.Windows.Forms.CheckBox nameCbx;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox DrawRes;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.RadioButton OutlineRbtn;
        private System.Windows.Forms.RadioButton FillRbtn;
    }
}

