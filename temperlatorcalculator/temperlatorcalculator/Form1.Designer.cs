namespace temperlatorcalculator
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
            this.bottonconvert = new System.Windows.Forms.Button();
            this.labelC = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.buttonconver2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottonconvert
            // 
            this.bottonconvert.Location = new System.Drawing.Point(207, 48);
            this.bottonconvert.Name = "bottonconvert";
            this.bottonconvert.Size = new System.Drawing.Size(94, 29);
            this.bottonconvert.TabIndex = 0;
            this.bottonconvert.Text = "Convert";
            this.bottonconvert.UseVisualStyleBackColor = true;
            this.bottonconvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(182, 48);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(18, 20);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(183, 91);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(16, 20);
            this.labelF.TabIndex = 3;
            this.labelF.Text = "F";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(52, 50);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(125, 27);
            this.textBoxC.TabIndex = 5;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(52, 83);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(125, 27);
            this.textBoxF.TabIndex = 6;
            // 
            // buttonconver2
            // 
            this.buttonconver2.Location = new System.Drawing.Point(205, 87);
            this.buttonconver2.Name = "buttonconver2";
            this.buttonconver2.Size = new System.Drawing.Size(94, 29);
            this.buttonconver2.TabIndex = 7;
            this.buttonconver2.Text = "convert";
            this.buttonconver2.UseVisualStyleBackColor = true;
            this.buttonconver2.Click += new System.EventHandler(this.buttonconver2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(305, 48);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 68);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 545);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonconver2);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.bottonconvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bottonconvert;
        private Button button2;
        private Label labelC;
        private Label labelF;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Button buttonconver2;
        private Button buttonClear;
    }
}