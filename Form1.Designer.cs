namespace Activity_15
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
            this.subButt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.luckNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subButt1
            // 
            this.subButt1.BackColor = System.Drawing.Color.Red;
            this.subButt1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subButt1.ForeColor = System.Drawing.Color.Black;
            this.subButt1.Location = new System.Drawing.Point(12, 172);
            this.subButt1.Name = "subButt1";
            this.subButt1.Size = new System.Drawing.Size(310, 42);
            this.subButt1.TabIndex = 0;
            this.subButt1.Text = "Open Selectors";
            this.subButt1.UseVisualStyleBackColor = false;
            this.subButt1.Click += new System.EventHandler(this.subButt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucky Number Generator";
            // 
            // luckNum
            // 
            this.luckNum.BackColor = System.Drawing.Color.Red;
            this.luckNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.luckNum.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.luckNum.Location = new System.Drawing.Point(12, 39);
            this.luckNum.Multiline = true;
            this.luckNum.Name = "luckNum";
            this.luckNum.Size = new System.Drawing.Size(311, 127);
            this.luckNum.TabIndex = 2;
            this.luckNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(335, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.luckNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subButt1);
            this.Name = "Form1";
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button subButt1;
        private Label label1;
        public TextBox luckNum;
        private Button button1;
    }
}