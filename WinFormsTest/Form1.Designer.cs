namespace WinFormsTest
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            label1 = new Label();
            progressBar2 = new ProgressBar();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(89, 49);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(536, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(319, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 2;
            label1.Text = "Press start to dawnload";
            label1.Click += label1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(89, 136);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(536, 30);
            progressBar2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(319, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 118);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 5;
            label2.Text = "Press start to dawnload";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Label label1;
        private ProgressBar progressBar2;
        private Button button2;
        private Label label2;
    }
}
