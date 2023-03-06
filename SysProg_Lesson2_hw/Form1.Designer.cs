namespace SysProg_Lesson2_hw
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.btn_from = new System.Windows.Forms.Button();
            this.btn_to = new System.Windows.Forms.Button();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pauseResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(65, 9);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(378, 23);
            this.txt_from.TabIndex = 1;
            // 
            // btn_from
            // 
            this.btn_from.Location = new System.Drawing.Point(461, 10);
            this.btn_from.Name = "btn_from";
            this.btn_from.Size = new System.Drawing.Size(81, 23);
            this.btn_from.TabIndex = 2;
            this.btn_from.Text = "Select File";
            this.btn_from.UseVisualStyleBackColor = true;
            this.btn_from.Click += new System.EventHandler(this.btn_from_Click);
            // 
            // btn_to
            // 
            this.btn_to.Location = new System.Drawing.Point(461, 39);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(81, 23);
            this.btn_to.TabIndex = 5;
            this.btn_to.Text = "Select File";
            this.btn_to.UseVisualStyleBackColor = true;
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(65, 38);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(378, 23);
            this.txt_to.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 67);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(313, 23);
            this.progBar.TabIndex = 7;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(461, 67);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(81, 23);
            this.btn_copy.TabIndex = 8;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(396, 67);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(59, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pauseResume
            // 
            this.btn_pauseResume.Location = new System.Drawing.Point(331, 67);
            this.btn_pauseResume.Name = "btn_pauseResume";
            this.btn_pauseResume.Size = new System.Drawing.Size(59, 23);
            this.btn_pauseResume.TabIndex = 10;
            this.btn_pauseResume.Text = "Pause";
            this.btn_pauseResume.UseVisualStyleBackColor = true;
            this.btn_pauseResume.Click += new System.EventHandler(this.btn_pauseResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 100);
            this.Controls.Add(this.btn_pauseResume);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_from);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_from;
        private Button btn_from;
        private Button btn_to;
        private TextBox txt_to;
        private Label label2;
        private ProgressBar progBar;
        private Button btn_copy;
        private Button btn_cancel;
        private Button btn_pauseResume;
    }
}