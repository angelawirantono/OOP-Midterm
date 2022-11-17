namespace mid_mock
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_mat = new System.Windows.Forms.ComboBox();
            this.mat_density_txt = new System.Windows.Forms.TextBox();
            this.mat_density_lbl = new System.Windows.Forms.Label();
            this.mat_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_geo = new System.Windows.Forms.ComboBox();
            this.geo2_txt = new System.Windows.Forms.TextBox();
            this.geo1_txt = new System.Windows.Forms.TextBox();
            this.geo2_lbl = new System.Windows.Forms.Label();
            this.geo1_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pyramid_txt = new System.Windows.Forms.TextBox();
            this.cylinder_txt = new System.Windows.Forms.TextBox();
            this.cube_txt = new System.Windows.Forms.TextBox();
            this.ball_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_shape_add = new System.Windows.Forms.Button();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbx_sort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.ascent = new System.Windows.Forms.RadioButton();
            this.descent = new System.Windows.Forms.RadioButton();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.sort_txt = new System.Windows.Forms.TextBox();
            this.btn_roll = new System.Windows.Forms.Button();
            this.roll_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_mat);
            this.groupBox1.Controls.Add(this.mat_density_txt);
            this.groupBox1.Controls.Add(this.mat_density_lbl);
            this.groupBox1.Controls.Add(this.mat_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // cbx_mat
            // 
            this.cbx_mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mat.FormattingEnabled = true;
            this.cbx_mat.Items.AddRange(new object[] {
            "Aluminium",
            "Iron",
            "Lead"});
            this.cbx_mat.Location = new System.Drawing.Point(133, 41);
            this.cbx_mat.Name = "cbx_mat";
            this.cbx_mat.Size = new System.Drawing.Size(196, 24);
            this.cbx_mat.TabIndex = 3;
            this.cbx_mat.SelectedIndexChanged += new System.EventHandler(this.cbx_mat_SelectedIndexChanged);
            // 
            // mat_density_txt
            // 
            this.mat_density_txt.Location = new System.Drawing.Point(133, 90);
            this.mat_density_txt.Name = "mat_density_txt";
            this.mat_density_txt.Size = new System.Drawing.Size(196, 22);
            this.mat_density_txt.TabIndex = 2;
            // 
            // mat_density_lbl
            // 
            this.mat_density_lbl.AutoSize = true;
            this.mat_density_lbl.Location = new System.Drawing.Point(35, 90);
            this.mat_density_lbl.Name = "mat_density_lbl";
            this.mat_density_lbl.Size = new System.Drawing.Size(55, 17);
            this.mat_density_lbl.TabIndex = 1;
            this.mat_density_lbl.Text = "Density";
            // 
            // mat_lbl
            // 
            this.mat_lbl.AutoSize = true;
            this.mat_lbl.Location = new System.Drawing.Point(35, 41);
            this.mat_lbl.Name = "mat_lbl";
            this.mat_lbl.Size = new System.Drawing.Size(58, 17);
            this.mat_lbl.TabIndex = 0;
            this.mat_lbl.Text = "Material";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_geo);
            this.groupBox2.Controls.Add(this.geo2_txt);
            this.groupBox2.Controls.Add(this.geo1_txt);
            this.groupBox2.Controls.Add(this.geo2_lbl);
            this.groupBox2.Controls.Add(this.geo1_lbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 153);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geometry";
            // 
            // cbx_geo
            // 
            this.cbx_geo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_geo.FormattingEnabled = true;
            this.cbx_geo.Items.AddRange(new object[] {
            "Ball",
            "Cube",
            "Cylinder",
            "Pyramid"});
            this.cbx_geo.Location = new System.Drawing.Point(133, 35);
            this.cbx_geo.Name = "cbx_geo";
            this.cbx_geo.Size = new System.Drawing.Size(196, 24);
            this.cbx_geo.TabIndex = 4;
            this.cbx_geo.SelectedIndexChanged += new System.EventHandler(this.cbx_geo_SelectedIndexChanged);
            // 
            // geo2_txt
            // 
            this.geo2_txt.Location = new System.Drawing.Point(133, 113);
            this.geo2_txt.Name = "geo2_txt";
            this.geo2_txt.Size = new System.Drawing.Size(196, 22);
            this.geo2_txt.TabIndex = 7;
            // 
            // geo1_txt
            // 
            this.geo1_txt.Location = new System.Drawing.Point(133, 77);
            this.geo1_txt.Name = "geo1_txt";
            this.geo1_txt.Size = new System.Drawing.Size(196, 22);
            this.geo1_txt.TabIndex = 4;
            // 
            // geo2_lbl
            // 
            this.geo2_lbl.AutoSize = true;
            this.geo2_lbl.Location = new System.Drawing.Point(35, 116);
            this.geo2_lbl.Name = "geo2_lbl";
            this.geo2_lbl.Size = new System.Drawing.Size(86, 17);
            this.geo2_lbl.TabIndex = 6;
            this.geo2_lbl.Text = "Parameter 2";
            // 
            // geo1_lbl
            // 
            this.geo1_lbl.AutoSize = true;
            this.geo1_lbl.Location = new System.Drawing.Point(35, 80);
            this.geo1_lbl.Name = "geo1_lbl";
            this.geo1_lbl.Size = new System.Drawing.Size(86, 17);
            this.geo1_lbl.TabIndex = 5;
            this.geo1_lbl.Text = "Parameter 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geometry";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pyramid_txt);
            this.groupBox3.Controls.Add(this.cylinder_txt);
            this.groupBox3.Controls.Add(this.cube_txt);
            this.groupBox3.Controls.Add(this.ball_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_shape_add);
            this.groupBox3.Controls.Add(this.total_txt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 173);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount of Shape";
            // 
            // pyramid_txt
            // 
            this.pyramid_txt.Location = new System.Drawing.Point(312, 135);
            this.pyramid_txt.Name = "pyramid_txt";
            this.pyramid_txt.Size = new System.Drawing.Size(68, 22);
            this.pyramid_txt.TabIndex = 16;
            // 
            // cylinder_txt
            // 
            this.cylinder_txt.Location = new System.Drawing.Point(219, 135);
            this.cylinder_txt.Name = "cylinder_txt";
            this.cylinder_txt.Size = new System.Drawing.Size(68, 22);
            this.cylinder_txt.TabIndex = 15;
            // 
            // cube_txt
            // 
            this.cube_txt.Location = new System.Drawing.Point(118, 135);
            this.cube_txt.Name = "cube_txt";
            this.cube_txt.Size = new System.Drawing.Size(68, 22);
            this.cube_txt.TabIndex = 14;
            // 
            // ball_txt
            // 
            this.ball_txt.Location = new System.Drawing.Point(18, 135);
            this.ball_txt.Name = "ball_txt";
            this.ball_txt.Size = new System.Drawing.Size(68, 22);
            this.ball_txt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pyramid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cylinder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ball";
            // 
            // btn_shape_add
            // 
            this.btn_shape_add.Location = new System.Drawing.Point(18, 47);
            this.btn_shape_add.Name = "btn_shape_add";
            this.btn_shape_add.Size = new System.Drawing.Size(75, 23);
            this.btn_shape_add.TabIndex = 8;
            this.btn_shape_add.Text = "Add";
            this.btn_shape_add.UseVisualStyleBackColor = true;
            this.btn_shape_add.Click += new System.EventHandler(this.btn_shape_add_Click);
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(133, 48);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(196, 22);
            this.total_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.roll_txt);
            this.groupBox4.Controls.Add(this.btn_roll);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txt_message);
            this.groupBox4.Location = new System.Drawing.Point(423, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 618);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sort_txt);
            this.groupBox5.Controls.Add(this.btn_confirm);
            this.groupBox5.Controls.Add(this.descent);
            this.groupBox5.Controls.Add(this.ascent);
            this.groupBox5.Controls.Add(this.cbx_sort);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(16, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 227);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort";
            // 
            // cbx_sort
            // 
            this.cbx_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sort.FormattingEnabled = true;
            this.cbx_sort.Items.AddRange(new object[] {
            "Shape",
            "Material",
            "Volume",
            "Weight"});
            this.cbx_sort.Location = new System.Drawing.Point(90, 38);
            this.cbx_sort.Name = "cbx_sort";
            this.cbx_sort.Size = new System.Drawing.Size(192, 24);
            this.cbx_sort.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sort By";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(16, 32);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(583, 151);
            this.txt_message.TabIndex = 2;
            // 
            // ascent
            // 
            this.ascent.AutoSize = true;
            this.ascent.Checked = true;
            this.ascent.Location = new System.Drawing.Point(288, 41);
            this.ascent.Name = "ascent";
            this.ascent.Size = new System.Drawing.Size(72, 21);
            this.ascent.TabIndex = 4;
            this.ascent.Text = "Ascent";
            this.ascent.UseVisualStyleBackColor = true;
            // 
            // descent
            // 
            this.descent.AutoSize = true;
            this.descent.Location = new System.Drawing.Point(379, 41);
            this.descent.Name = "descent";
            this.descent.Size = new System.Drawing.Size(81, 21);
            this.descent.TabIndex = 5;
            this.descent.Text = "Descent";
            this.descent.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(487, 38);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 17;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // sort_txt
            // 
            this.sort_txt.Location = new System.Drawing.Point(6, 72);
            this.sort_txt.Multiline = true;
            this.sort_txt.Name = "sort_txt";
            this.sort_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sort_txt.Size = new System.Drawing.Size(571, 149);
            this.sort_txt.TabIndex = 5;
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(22, 422);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(109, 23);
            this.btn_roll.TabIndex = 18;
            this.btn_roll.Text = "Roll Contest";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // roll_txt
            // 
            this.roll_txt.Location = new System.Drawing.Point(22, 451);
            this.roll_txt.Multiline = true;
            this.roll_txt.Name = "roll_txt";
            this.roll_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roll_txt.Size = new System.Drawing.Size(583, 151);
            this.roll_txt.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mat_density_lbl;
        private System.Windows.Forms.Label mat_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_mat;
        private System.Windows.Forms.TextBox mat_density_txt;
        private System.Windows.Forms.ComboBox cbx_geo;
        private System.Windows.Forms.TextBox geo2_txt;
        private System.Windows.Forms.TextBox geo1_txt;
        private System.Windows.Forms.Label geo2_lbl;
        private System.Windows.Forms.Label geo1_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox pyramid_txt;
        private System.Windows.Forms.TextBox cylinder_txt;
        private System.Windows.Forms.TextBox cube_txt;
        private System.Windows.Forms.TextBox ball_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_shape_add;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbx_sort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roll_txt;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.TextBox sort_txt;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.RadioButton descent;
        private System.Windows.Forms.RadioButton ascent;
    }
}