namespace ComputerGraphics3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cabinetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cofficientTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Sy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Sx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ScaleBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Sz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.numericUpDownAngleRotate = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tyTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPresp = new System.Windows.Forms.RadioButton();
            this.rbObliq = new System.Windows.Forms.RadioButton();
            this.rbOrth = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(12, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 608);
            this.panel1.TabIndex = 0;
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPath.Location = new System.Drawing.Point(13, 6);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(545, 22);
            this.tbPath.TabIndex = 53;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.browse.Location = new System.Drawing.Point(568, 6);
            this.browse.Margin = new System.Windows.Forms.Padding(4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(104, 27);
            this.browse.TabIndex = 52;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.Location = new System.Drawing.Point(1392, 172);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 39);
            this.button9.TabIndex = 60;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Angle";
            // 
            // cabinetUpDown
            // 
            this.cabinetUpDown.Location = new System.Drawing.Point(215, 92);
            this.cabinetUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.cabinetUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.cabinetUpDown.Name = "cabinetUpDown";
            this.cabinetUpDown.Size = new System.Drawing.Size(61, 22);
            this.cabinetUpDown.TabIndex = 63;
            this.cabinetUpDown.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Coefficient";
            // 
            // cofficientTb
            // 
            this.cofficientTb.Location = new System.Drawing.Point(374, 92);
            this.cofficientTb.Name = "cofficientTb";
            this.cofficientTb.Size = new System.Drawing.Size(42, 22);
            this.cofficientTb.TabIndex = 67;
            this.cofficientTb.Text = "0.6";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(680, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 68;
            this.button2.Text = "Repaint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Repaint_Click);
            // 
            // Sy
            // 
            this.Sy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sy.Location = new System.Drawing.Point(603, 79);
            this.Sy.Margin = new System.Windows.Forms.Padding(4);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(55, 22);
            this.Sy.TabIndex = 77;
            this.Sy.Text = "1.6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(573, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "Sy:";
            // 
            // Sx
            // 
            this.Sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sx.Location = new System.Drawing.Point(503, 82);
            this.Sx.Margin = new System.Windows.Forms.Padding(4);
            this.Sx.Name = "Sx";
            this.Sx.Size = new System.Drawing.Size(55, 22);
            this.Sx.TabIndex = 72;
            this.Sx.Text = "1.6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(473, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "Sx:";
            // 
            // ScaleBtn
            // 
            this.ScaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScaleBtn.Location = new System.Drawing.Point(476, 122);
            this.ScaleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleBtn.Name = "ScaleBtn";
            this.ScaleBtn.Size = new System.Drawing.Size(79, 33);
            this.ScaleBtn.TabIndex = 70;
            this.ScaleBtn.Text = "Scale";
            this.ScaleBtn.UseVisualStyleBackColor = true;
            this.ScaleBtn.Click += new System.EventHandler(this.ScaleBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(471, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Scaling";
            // 
            // Sz
            // 
            this.Sz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sz.Location = new System.Drawing.Point(704, 77);
            this.Sz.Margin = new System.Windows.Forms.Padding(4);
            this.Sz.Name = "Sz";
            this.Sz.Size = new System.Drawing.Size(55, 22);
            this.Sz.TabIndex = 80;
            this.Sz.Text = "1.6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(674, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Sz:";
            // 
            // cmbx
            // 
            this.cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Location = new System.Drawing.Point(855, 71);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(121, 24);
            this.cmbx.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(852, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Rotate By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(854, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Angle:";
            // 
            // RotateBtn
            // 
            this.RotateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RotateBtn.Location = new System.Drawing.Point(857, 172);
            this.RotateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(79, 33);
            this.RotateBtn.TabIndex = 84;
            this.RotateBtn.Text = "Rotate";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // numericUpDownAngleRotate
            // 
            this.numericUpDownAngleRotate.Location = new System.Drawing.Point(915, 123);
            this.numericUpDownAngleRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownAngleRotate.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownAngleRotate.Name = "numericUpDownAngleRotate";
            this.numericUpDownAngleRotate.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownAngleRotate.TabIndex = 85;
            this.numericUpDownAngleRotate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(1035, 136);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 32);
            this.button4.TabIndex = 94;
            this.button4.Text = "left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Left_Btn);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(1127, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 39);
            this.button3.TabIndex = 93;
            this.button3.Text = "down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Down_Btn);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1214, 136);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 32);
            this.button5.TabIndex = 92;
            this.button5.Text = "right";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Right_Btn);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(1127, 107);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 33);
            this.button6.TabIndex = 91;
            this.button6.Text = "up";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Up_Btn);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1035, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Translation";
            // 
            // tyTb
            // 
            this.tyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tyTb.Location = new System.Drawing.Point(1199, 66);
            this.tyTb.Margin = new System.Windows.Forms.Padding(4);
            this.tyTb.Name = "tyTb";
            this.tyTb.Size = new System.Drawing.Size(55, 22);
            this.tyTb.TabIndex = 89;
            this.tyTb.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1035, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tx:";
            // 
            // txTb
            // 
            this.txTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txTb.Location = new System.Drawing.Point(1086, 69);
            this.txTb.Margin = new System.Windows.Forms.Padding(4);
            this.txTb.Name = "txTb";
            this.txTb.Size = new System.Drawing.Size(55, 22);
            this.txTb.TabIndex = 87;
            this.txTb.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1154, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "Ty:";
            // 
            // rbPresp
            // 
            this.rbPresp.AutoSize = true;
            this.rbPresp.Location = new System.Drawing.Point(13, 47);
            this.rbPresp.Name = "rbPresp";
            this.rbPresp.Size = new System.Drawing.Size(103, 21);
            this.rbPresp.TabIndex = 95;
            this.rbPresp.TabStop = true;
            this.rbPresp.Text = "Prespective";
            this.rbPresp.UseVisualStyleBackColor = true;
            this.rbPresp.CheckedChanged += new System.EventHandler(this.Prespec_change);
            // 
            // rbObliq
            // 
            this.rbObliq.AutoSize = true;
            this.rbObliq.Location = new System.Drawing.Point(13, 88);
            this.rbObliq.Name = "rbObliq";
            this.rbObliq.Size = new System.Drawing.Size(78, 21);
            this.rbObliq.TabIndex = 96;
            this.rbObliq.TabStop = true;
            this.rbObliq.Text = "Oblique";
            this.rbObliq.UseVisualStyleBackColor = true;
            this.rbObliq.CheckedChanged += new System.EventHandler(this.rbObliq_Change);
            // 
            // rbOrth
            // 
            this.rbOrth.AutoSize = true;
            this.rbOrth.Location = new System.Drawing.Point(13, 134);
            this.rbOrth.Name = "rbOrth";
            this.rbOrth.Size = new System.Drawing.Size(112, 21);
            this.rbOrth.TabIndex = 97;
            this.rbOrth.TabStop = true;
            this.rbOrth.Text = "Orthographic";
            this.rbOrth.UseVisualStyleBackColor = true;
            this.rbOrth.CheckedChanged += new System.EventHandler(this.Orth_Change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 835);
            this.Controls.Add(this.rbOrth);
            this.Controls.Add(this.rbObliq);
            this.Controls.Add(this.rbPresp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tyTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownAngleRotate);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.Sz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Sx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ScaleBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cofficientTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cabinetUpDown);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cabinetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleRotate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cabinetUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cofficientTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Sx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ScaleBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RotateBtn;
        private System.Windows.Forms.NumericUpDown numericUpDownAngleRotate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tyTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPresp;
        private System.Windows.Forms.RadioButton rbObliq;
        private System.Windows.Forms.RadioButton rbOrth;
    }
}
  
