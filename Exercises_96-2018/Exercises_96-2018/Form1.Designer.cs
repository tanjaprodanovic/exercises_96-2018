namespace Exercises_96_2018
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
            this.listBoxExerciseResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxExerciseResult
            // 
            this.listBoxExerciseResult.FormattingEnabled = true;
            this.listBoxExerciseResult.ItemHeight = 15;
            this.listBoxExerciseResult.Location = new System.Drawing.Point(23, 11);
            this.listBoxExerciseResult.Name = "listBoxExerciseResult";
            this.listBoxExerciseResult.Size = new System.Drawing.Size(541, 274);
            this.listBoxExerciseResult.TabIndex = 0;
            this.listBoxExerciseResult.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxExerciseResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResult;
    }
}

