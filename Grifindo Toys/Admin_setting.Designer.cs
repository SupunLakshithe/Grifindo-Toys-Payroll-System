namespace Grifindo_Toys
{
    partial class Admin_setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_setting));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.cmb_emp_branch = new System.Windows.Forms.GroupBox();
            this.chk_b_enble_duration = new System.Windows.Forms.CheckBox();
            this.date_t_end = new System.Windows.Forms.DateTimePicker();
            this.date_t_start = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tax_rate = new System.Windows.Forms.TextBox();
            this.txt_max_abcent = new System.Windows.Forms.TextBox();
            this.txt_max_leaves = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_cycle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_emp_branch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "End day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duration";
            // 
            // txt_duration
            // 
            this.txt_duration.Enabled = false;
            this.txt_duration.Location = new System.Drawing.Point(125, 130);
            this.txt_duration.MaxLength = 2;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(42, 26);
            this.txt_duration.TabIndex = 9;
            this.txt_duration.Text = "30";
            // 
            // cmb_emp_branch
            // 
            this.cmb_emp_branch.BackColor = System.Drawing.Color.Transparent;
            this.cmb_emp_branch.Controls.Add(this.chk_b_enble_duration);
            this.cmb_emp_branch.Controls.Add(this.date_t_end);
            this.cmb_emp_branch.Controls.Add(this.date_t_start);
            this.cmb_emp_branch.Controls.Add(this.txt_duration);
            this.cmb_emp_branch.Controls.Add(this.label4);
            this.cmb_emp_branch.Controls.Add(this.label3);
            this.cmb_emp_branch.Controls.Add(this.label2);
            this.cmb_emp_branch.ForeColor = System.Drawing.Color.Yellow;
            this.cmb_emp_branch.Location = new System.Drawing.Point(23, 29);
            this.cmb_emp_branch.Name = "cmb_emp_branch";
            this.cmb_emp_branch.Size = new System.Drawing.Size(318, 170);
            this.cmb_emp_branch.TabIndex = 3;
            this.cmb_emp_branch.TabStop = false;
            this.cmb_emp_branch.Text = "Salary Cycle";
            // 
            // chk_b_enble_duration
            // 
            this.chk_b_enble_duration.AutoSize = true;
            this.chk_b_enble_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_b_enble_duration.Location = new System.Drawing.Point(197, 135);
            this.chk_b_enble_duration.Name = "chk_b_enble_duration";
            this.chk_b_enble_duration.Size = new System.Drawing.Size(101, 20);
            this.chk_b_enble_duration.TabIndex = 20;
            this.chk_b_enble_duration.Text = "add duration";
            this.chk_b_enble_duration.UseVisualStyleBackColor = true;
            this.chk_b_enble_duration.CheckedChanged += new System.EventHandler(this.chk_b_enble_duration_CheckedChanged);
            // 
            // date_t_end
            // 
            this.date_t_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_t_end.Location = new System.Drawing.Point(125, 87);
            this.date_t_end.Name = "date_t_end";
            this.date_t_end.Size = new System.Drawing.Size(129, 26);
            this.date_t_end.TabIndex = 19;
            // 
            // date_t_start
            // 
            this.date_t_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_t_start.Location = new System.Drawing.Point(125, 47);
            this.date_t_start.Name = "date_t_start";
            this.date_t_start.Size = new System.Drawing.Size(129, 26);
            this.date_t_start.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(347, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 137);
            this.button1.TabIndex = 17;
            this.button1.Text = "SET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tax_rate);
            this.groupBox1.Controls.Add(this.txt_max_abcent);
            this.groupBox1.Controls.Add(this.txt_max_leaves);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(23, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limits";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(78, -23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "%";
            // 
            // txt_tax_rate
            // 
            this.txt_tax_rate.Location = new System.Drawing.Point(179, 106);
            this.txt_tax_rate.MaxLength = 5;
            this.txt_tax_rate.Name = "txt_tax_rate";
            this.txt_tax_rate.Size = new System.Drawing.Size(57, 26);
            this.txt_tax_rate.TabIndex = 23;
            // 
            // txt_max_abcent
            // 
            this.txt_max_abcent.Location = new System.Drawing.Point(179, 69);
            this.txt_max_abcent.MaxLength = 2;
            this.txt_max_abcent.Name = "txt_max_abcent";
            this.txt_max_abcent.Size = new System.Drawing.Size(57, 26);
            this.txt_max_abcent.TabIndex = 22;
            // 
            // txt_max_leaves
            // 
            this.txt_max_leaves.Location = new System.Drawing.Point(179, 33);
            this.txt_max_leaves.MaxLength = 2;
            this.txt_max_leaves.Name = "txt_max_leaves";
            this.txt_max_leaves.Size = new System.Drawing.Size(57, 26);
            this.txt_max_leaves.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tax rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Maximum Abcent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Maximum Leaves";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button5.Location = new System.Drawing.Point(390, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 42);
            this.button5.TabIndex = 15;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(390, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(463, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 139);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(306, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 139);
            this.button2.TabIndex = 18;
            this.button2.Text = "SET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grifindo_Toys.Properties.Resources.big_logo_to_edit_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(327, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_cycle
            // 
            this.lbl_cycle.AutoSize = true;
            this.lbl_cycle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cycle.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_cycle.Location = new System.Drawing.Point(414, 21);
            this.lbl_cycle.Name = "lbl_cycle";
            this.lbl_cycle.Size = new System.Drawing.Size(52, 55);
            this.lbl_cycle.TabIndex = 20;
            this.lbl_cycle.Text = "0";
            this.lbl_cycle.Click += new System.EventHandler(this.lbl_cycle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(386, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Current cycle";
            // 
            // Admin_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Grifindo_Toys.Properties.Resources.pexels_markus_spfgiske_214241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 398);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_cycle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_emp_branch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_setting";
            this.Opacity = 0.97D;
            this.Text = " Admin_setting";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Admin_setting_Load);
            this.cmb_emp_branch.ResumeLayout(false);
            this.cmb_emp_branch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.GroupBox cmb_emp_branch;
        private System.Windows.Forms.CheckBox chk_b_enble_duration;
        private System.Windows.Forms.DateTimePicker date_t_end;
        private System.Windows.Forms.DateTimePicker date_t_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_max_abcent;
        private System.Windows.Forms.TextBox txt_max_leaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tax_rate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_cycle;
        private System.Windows.Forms.Label label8;
    }
}