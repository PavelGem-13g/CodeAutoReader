
namespace CodeAutoReader
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
            this.button = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.extensions = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(102, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Choose directory";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(120, 12);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(316, 201);
            this.result.TabIndex = 1;
            // 
            // extensions
            // 
            this.extensions.Location = new System.Drawing.Point(13, 42);
            this.extensions.Name = "extensions";
            this.extensions.Size = new System.Drawing.Size(100, 20);
            this.extensions.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy to clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.extensions);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "CAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox extensions;
        private System.Windows.Forms.Button button1;
    }
}

