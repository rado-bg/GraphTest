namespace GraphTest
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
            this.components = new System.ComponentModel.Container();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile_btn = new System.Windows.Forms.Button();
            this.CreateFile_btn = new System.Windows.Forms.Button();
            this.CreateFile_txt = new System.Windows.Forms.TextBox();
            this.OpenFile_txt = new System.Windows.Forms.TextBox();
            this.lowLimit_txt = new System.Windows.Forms.TextBox();
            this.highLimit_txt = new System.Windows.Forms.TextBox();
            this.maxIteration_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l9 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.Max_lbl = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.Min_lbl = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Values_lb = new System.Windows.Forms.ListBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile_btn.Location = new System.Drawing.Point(29, 134);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(106, 32);
            this.OpenFile_btn.TabIndex = 0;
            this.OpenFile_btn.Text = "Open File";
            this.OpenFile_btn.UseVisualStyleBackColor = true;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // CreateFile_btn
            // 
            this.CreateFile_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateFile_btn.Location = new System.Drawing.Point(27, 75);
            this.CreateFile_btn.Name = "CreateFile_btn";
            this.CreateFile_btn.Size = new System.Drawing.Size(107, 33);
            this.CreateFile_btn.TabIndex = 1;
            this.CreateFile_btn.Text = "Create File";
            this.CreateFile_btn.UseVisualStyleBackColor = true;
            this.CreateFile_btn.Click += new System.EventHandler(this.CreateFile_btn_Click);
            // 
            // CreateFile_txt
            // 
            this.CreateFile_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateFile_txt.Location = new System.Drawing.Point(140, 82);
            this.CreateFile_txt.Name = "CreateFile_txt";
            this.CreateFile_txt.Size = new System.Drawing.Size(524, 26);
            this.CreateFile_txt.TabIndex = 2;
            // 
            // OpenFile_txt
            // 
            this.OpenFile_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenFile_txt.Location = new System.Drawing.Point(141, 140);
            this.OpenFile_txt.Name = "OpenFile_txt";
            this.OpenFile_txt.Size = new System.Drawing.Size(522, 26);
            this.OpenFile_txt.TabIndex = 3;
            // 
            // lowLimit_txt
            // 
            this.lowLimit_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lowLimit_txt.Location = new System.Drawing.Point(220, 50);
            this.lowLimit_txt.Name = "lowLimit_txt";
            this.lowLimit_txt.Size = new System.Drawing.Size(74, 26);
            this.lowLimit_txt.TabIndex = 4;
            this.lowLimit_txt.Text = "9.1";
            // 
            // highLimit_txt
            // 
            this.highLimit_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highLimit_txt.Location = new System.Drawing.Point(406, 50);
            this.highLimit_txt.Name = "highLimit_txt";
            this.highLimit_txt.Size = new System.Drawing.Size(87, 26);
            this.highLimit_txt.TabIndex = 5;
            this.highLimit_txt.Text = "14.4";
            // 
            // maxIteration_txt
            // 
            this.maxIteration_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxIteration_txt.Location = new System.Drawing.Point(589, 50);
            this.maxIteration_txt.Name = "maxIteration_txt";
            this.maxIteration_txt.Size = new System.Drawing.Size(74, 26);
            this.maxIteration_txt.TabIndex = 6;
            this.maxIteration_txt.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Low Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(322, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "High Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(518, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iteration";
            // 
            // status_txt
            // 
            this.status_txt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status_txt.ForeColor = System.Drawing.Color.Red;
            this.status_txt.Location = new System.Drawing.Point(140, 188);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status_txt.Size = new System.Drawing.Size(524, 73);
            this.status_txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(518, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = " [0..100]";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(59, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 271);
            this.panel1.TabIndex = 12;
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l9.Location = new System.Drawing.Point(11, 296);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(0, 15);
            this.l9.TabIndex = 24;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l1.Location = new System.Drawing.Point(11, 496);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 15);
            this.l1.TabIndex = 23;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l2.Location = new System.Drawing.Point(11, 471);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 15);
            this.l2.TabIndex = 22;
            // 
            // Max_lbl
            // 
            this.Max_lbl.AutoSize = true;
            this.Max_lbl.ForeColor = System.Drawing.Color.Red;
            this.Max_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Max_lbl.Location = new System.Drawing.Point(11, 271);
            this.Max_lbl.Name = "Max_lbl";
            this.Max_lbl.Size = new System.Drawing.Size(0, 15);
            this.Max_lbl.TabIndex = 15;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l8.Location = new System.Drawing.Point(11, 321);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(0, 15);
            this.l8.TabIndex = 21;
            // 
            // Min_lbl
            // 
            this.Min_lbl.AutoSize = true;
            this.Min_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Min_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Min_lbl.Location = new System.Drawing.Point(11, 521);
            this.Min_lbl.Name = "Min_lbl";
            this.Min_lbl.Size = new System.Drawing.Size(0, 15);
            this.Min_lbl.TabIndex = 16;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l3.Location = new System.Drawing.Point(11, 446);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 15);
            this.l3.TabIndex = 20;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l7.Location = new System.Drawing.Point(11, 346);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(0, 15);
            this.l7.TabIndex = 17;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l4.Location = new System.Drawing.Point(11, 421);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(0, 15);
            this.l4.TabIndex = 18;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l6.Location = new System.Drawing.Point(11, 371);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(0, 15);
            this.l6.TabIndex = 18;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l5.Location = new System.Drawing.Point(11, 396);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(0, 15);
            this.l5.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Info Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(670, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(670, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Min";
            // 
            // Values_lb
            // 
            this.Values_lb.Enabled = false;
            this.Values_lb.FormattingEnabled = true;
            this.Values_lb.ItemHeight = 15;
            this.Values_lb.Location = new System.Drawing.Point(741, 56);
            this.Values_lb.Name = "Values_lb";
            this.Values_lb.Size = new System.Drawing.Size(100, 484);
            this.Values_lb.TabIndex = 27;
            this.Values_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Values_lb_MouseClick);
            // 
            // myTimer
            // 
            this.myTimer.Interval = 150;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 584);
            this.Controls.Add(this.Values_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Max_lbl);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Min_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.maxIteration_txt);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.highLimit_txt);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.lowLimit_txt);
            this.Controls.Add(this.OpenFile_txt);
            this.Controls.Add(this.CreateFile_txt);
            this.Controls.Add(this.CreateFile_btn);
            this.Controls.Add(this.OpenFile_btn);
            this.Name = "Form1";
            this.Text = "Graph Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private Button OpenFile_btn;
        private Button CreateFile_btn;
        private TextBox CreateFile_txt;
        private TextBox OpenFile_txt;
        private TextBox lowLimit_txt;
        private TextBox highLimit_txt;
        private TextBox maxIteration_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox status_txt;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label Min_lbl;
        private Label Max_lbl;
        private Label l9;
        private Label l1;
        private Label l2;
        private Label l8;
        private Label l3;
        private Label l7;
        private Label l4;
        private Label l6;
        private Label l5;
        private Label label6;
        private Label label7;
        private ListBox Values_lb;
        private System.Windows.Forms.Timer myTimer;
    }
}