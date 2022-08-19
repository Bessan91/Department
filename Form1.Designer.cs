namespace dep
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_of_dep = new System.Windows.Forms.ListBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(990, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = ":اختار الجهة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_of_dep
            // 
            this.name_of_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_dep.FormattingEnabled = true;
            this.name_of_dep.ItemHeight = 25;
            this.name_of_dep.Location = new System.Drawing.Point(360, 430);
            this.name_of_dep.Name = "name_of_dep";
            this.name_of_dep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_of_dep.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.name_of_dep.Size = new System.Drawing.Size(582, 229);
            this.name_of_dep.TabIndex = 1;
            this.name_of_dep.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(531, 346);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDept.Size = new System.Drawing.Size(411, 33);
            this.comboBoxDept.TabIndex = 3;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.BackgroundImage = global::dep.Properties.Resources.DvviuXSWwAAoRXD;
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.label2);
            this.header.Location = new System.Drawing.Point(0, 3);
            this.header.Name = "header";
            this.header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.header.Size = new System.Drawing.Size(1600, 275);
            this.header.TabIndex = 7;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(605, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dewan Ministry of Interior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1053, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "ديوان وزارة الداخلية  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::dep.Properties.Resources.download_icon_delete_exit_remove_icon_1320183290543191930_24;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(12, 719);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 54);
            this.exit.TabIndex = 5;
            this.exit.Text = "خروج";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear_all
            // 
            this.clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all.Image = global::dep.Properties.Resources.download_icon_clear_all_24px_131985189927880479_24;
            this.clear_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_all.Location = new System.Drawing.Point(360, 692);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(153, 54);
            this.clear_all.TabIndex = 0;
            this.clear_all.Text = "حذف الكل";
            this.clear_all.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::dep.Properties.Resources.download_icon_add_circle_24px_131985189531127879_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(360, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "اضافة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.White;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Image = global::dep.Properties.Resources.download_icon_print_24px_131985193277910846_24;
            this.print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print.Location = new System.Drawing.Point(812, 692);
            this.print.Name = "print";
            this.print.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.print.Size = new System.Drawing.Size(130, 54);
            this.print.TabIndex = 2;
            this.print.Text = "طباعة";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1596, 775);
            this.Controls.Add(this.header);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.print);
            this.Controls.Add(this.name_of_dep);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox name_of_dep;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

