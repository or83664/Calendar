namespace mid
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
            this.GiveUp = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.showPickTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GiveUp
            // 
            this.GiveUp.Location = new System.Drawing.Point(1, 344);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(75, 30);
            this.GiveUp.TabIndex = 0;
            this.GiveUp.Text = "Give up ";
            this.GiveUp.UseVisualStyleBackColor = true;
            this.GiveUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(1, 282);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 30);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.button2_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(388, 344);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 30);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.button3_Click);
            // 
            // showPickTime
            // 
            this.showPickTime.AutoSize = true;
            this.showPickTime.Location = new System.Drawing.Point(12, 9);
            this.showPickTime.Name = "showPickTime";
            this.showPickTime.Size = new System.Drawing.Size(0, 18);
            this.showPickTime.TabIndex = 4;
            this.showPickTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1, 39);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(462, 124);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(184, 333);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(110, 41);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 386);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPickTime);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.GiveUp);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GiveUp;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label showPickTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
    }
}