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
            this.print = new System.Windows.Forms.Button();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختار الجهة ";
            // 
            // name_of_dep
            // 
            this.name_of_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_dep.FormattingEnabled = true;
            this.name_of_dep.ItemHeight = 20;
            this.name_of_dep.Location = new System.Drawing.Point(148, 79);
            this.name_of_dep.Name = "name_of_dep";
            this.name_of_dep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_of_dep.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.name_of_dep.Size = new System.Drawing.Size(551, 244);
            this.name_of_dep.TabIndex = 1;
            this.name_of_dep.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(357, 350);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(98, 42);
            this.print.TabIndex = 2;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(245, 26);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDept.Size = new System.Drawing.Size(369, 28);
            this.comboBoxDept.TabIndex = 3;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(148, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "اضافة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear_all
            // 
            this.clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_all.Location = new System.Drawing.Point(229, 350);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(91, 42);
            this.clear_all.TabIndex = 0;
            this.clear_all.Text = "حذف الكل";
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(12, 360);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(55, 32);
            this.exit.TabIndex = 5;
            this.exit.Text = "خروج";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.print);
            this.Controls.Add(this.name_of_dep);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

