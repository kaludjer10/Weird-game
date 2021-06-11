namespace игор
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.дипси = new System.Windows.Forms.PictureBox();
            this.игор = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.дипси)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игор)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(99, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "stub";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(315, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 10);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "stub";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(512, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 10);
            this.panel3.TabIndex = 2;
            this.panel3.Tag = "stub";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(718, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(61, 10);
            this.panel4.TabIndex = 3;
            this.panel4.Tag = "stub";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(916, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 10);
            this.panel5.TabIndex = 4;
            this.panel5.Tag = "stub";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(1149, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 10);
            this.panel6.TabIndex = 5;
            this.panel6.Tag = "stub";
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // дипси
            // 
            this.дипси.Image = global::игор.Properties.Resources.мали_дипси_игор1;
            this.дипси.Location = new System.Drawing.Point(1283, 31);
            this.дипси.Name = "дипси";
            this.дипси.Size = new System.Drawing.Size(100, 50);
            this.дипси.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.дипси.TabIndex = 7;
            this.дипси.TabStop = false;
            // 
            // игор
            // 
            this.игор.Image = global::игор.Properties.Resources.output_onlinepngtools_1_;
            this.игор.Location = new System.Drawing.Point(99, 82);
            this.игор.Name = "игор";
            this.игор.Size = new System.Drawing.Size(50, 70);
            this.игор.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.игор.TabIndex = 6;
            this.игор.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 10000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "убрзање:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "1x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.дипси);
            this.Controls.Add(this.игор);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.дипси)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игор)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox игор;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox дипси;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

