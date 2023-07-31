namespace Physio_Therapy_Clinic
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
            this.btresult = new System.Windows.Forms.Button();
            this.btprofile = new System.Windows.Forms.Button();
            this.btinformation = new System.Windows.Forms.Button();
            this.btregistration = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmaxed = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.btmax = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.userControl11 = new Physio_Therapy_Clinic.UserControl1();
            this.frminfo1 = new Physio_Therapy_Clinic.frminfo();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btresult);
            this.panel1.Controls.Add(this.btprofile);
            this.panel1.Controls.Add(this.btinformation);
            this.panel1.Controls.Add(this.btregistration);
            this.panel1.Controls.Add(this.bthome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 678);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btresult
            // 
            this.btresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btresult.FlatAppearance.BorderSize = 0;
            this.btresult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btresult.ForeColor = System.Drawing.Color.White;
            this.btresult.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_exam_48;
            this.btresult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btresult.Location = new System.Drawing.Point(0, 356);
            this.btresult.Name = "btresult";
            this.btresult.Size = new System.Drawing.Size(215, 43);
            this.btresult.TabIndex = 5;
            this.btresult.Text = "Student Result";
            this.btresult.UseVisualStyleBackColor = false;
            this.btresult.Click += new System.EventHandler(this.button5_Click);
            // 
            // btprofile
            // 
            this.btprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btprofile.FlatAppearance.BorderSize = 0;
            this.btprofile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btprofile.ForeColor = System.Drawing.Color.White;
            this.btprofile.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_customer_48;
            this.btprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btprofile.Location = new System.Drawing.Point(0, 307);
            this.btprofile.Name = "btprofile";
            this.btprofile.Size = new System.Drawing.Size(215, 43);
            this.btprofile.TabIndex = 4;
            this.btprofile.Text = "Student Profile";
            this.btprofile.UseVisualStyleBackColor = false;
            this.btprofile.Click += new System.EventHandler(this.button4_Click);
            // 
            // btinformation
            // 
            this.btinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btinformation.FlatAppearance.BorderSize = 0;
            this.btinformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btinformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btinformation.ForeColor = System.Drawing.Color.White;
            this.btinformation.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_information_32;
            this.btinformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btinformation.Location = new System.Drawing.Point(0, 258);
            this.btinformation.Name = "btinformation";
            this.btinformation.Size = new System.Drawing.Size(215, 43);
            this.btinformation.TabIndex = 3;
            this.btinformation.Text = "Information";
            this.btinformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btinformation.UseVisualStyleBackColor = false;
            this.btinformation.Click += new System.EventHandler(this.button3_Click);
            // 
            // btregistration
            // 
            this.btregistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btregistration.FlatAppearance.BorderSize = 0;
            this.btregistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btregistration.ForeColor = System.Drawing.Color.White;
            this.btregistration.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_registration_40;
            this.btregistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btregistration.Location = new System.Drawing.Point(0, 209);
            this.btregistration.Name = "btregistration";
            this.btregistration.Size = new System.Drawing.Size(215, 43);
            this.btregistration.TabIndex = 2;
            this.btregistration.Text = "Registration";
            this.btregistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btregistration.UseVisualStyleBackColor = false;
            this.btregistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // bthome
            // 
            this.bthome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bthome.FlatAppearance.BorderSize = 0;
            this.bthome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.bthome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bthome.ForeColor = System.Drawing.Color.White;
            this.bthome.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_home_40;
            this.bthome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthome.Location = new System.Drawing.Point(0, 160);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(215, 43);
            this.bthome.TabIndex = 1;
            this.bthome.Text = "Home";
            this.bthome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bthome.UseVisualStyleBackColor = false;
            this.bthome.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 154);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Physio_Therapy_Clinic.Properties.Resources._67902;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btmaxed);
            this.panel2.Controls.Add(this.btmin);
            this.panel2.Controls.Add(this.btmax);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 50);
            this.panel2.TabIndex = 1;
            // 
            // btmaxed
            // 
            this.btmaxed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmaxed.FlatAppearance.BorderSize = 0;
            this.btmaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btmaxed.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_maximize_window_32;
            this.btmaxed.Location = new System.Drawing.Point(750, 1);
            this.btmaxed.Name = "btmaxed";
            this.btmaxed.Size = new System.Drawing.Size(32, 28);
            this.btmaxed.TabIndex = 5;
            this.btmaxed.UseVisualStyleBackColor = true;
            this.btmaxed.Click += new System.EventHandler(this.btmaxed_Click);
            // 
            // btmin
            // 
            this.btmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btmin.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_subtract_32;
            this.btmin.Location = new System.Drawing.Point(788, 1);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(32, 28);
            this.btmin.TabIndex = 4;
            this.btmin.UseVisualStyleBackColor = true;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // btmax
            // 
            this.btmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btmax.ForeColor = System.Drawing.Color.White;
            this.btmax.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_restore_down_32;
            this.btmax.Location = new System.Drawing.Point(826, 1);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(37, 28);
            this.btmax.TabIndex = 3;
            this.btmax.UseVisualStyleBackColor = true;
            this.btmax.Click += new System.EventHandler(this.btmax_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Image = global::Physio_Therapy_Clinic.Properties.Resources.icons8_close_window_50;
            this.button6.Location = new System.Drawing.Point(869, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 28);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblH);
            this.panel4.Location = new System.Drawing.Point(302, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 52);
            this.panel4.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(3, 12);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(237, 25);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "Student Addmission Form";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblH.Click += new System.EventHandler(this.label1_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(218, 50);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(905, 628);
            this.userControl11.TabIndex = 2;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // frminfo1
            // 
            this.frminfo1.BackColor = System.Drawing.Color.White;
            this.frminfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frminfo1.Location = new System.Drawing.Point(218, 50);
            this.frminfo1.Name = "frminfo1";
            this.frminfo1.Size = new System.Drawing.Size(905, 628);
            this.frminfo1.TabIndex = 3;
            this.frminfo1.Visible = false;
            this.frminfo1.Load += new System.EventHandler(this.frminfo1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 678);
            this.Controls.Add(this.frminfo1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button bthome;
        private Button btresult;
        private Button btprofile;
        private Button btinformation;
        private Button btregistration;
        private PictureBox pictureBox1;
        private Button button6;
        private Panel panel4;
        private Label lblH;
        private Button btmaxed;
        private Button btmin;
        private Button btmax;
        private UserControl1 userControl11;
        private frminfo frminfo1;
    }
}