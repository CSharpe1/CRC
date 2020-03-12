namespace Button_Change_Variable
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelVar = new System.Windows.Forms.Label();
            this.ChangeVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // LabelVar
            // 
            this.LabelVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelVar.Location = new System.Drawing.Point(117, 59);
            this.LabelVar.Name = "LabelVar";
            this.LabelVar.Size = new System.Drawing.Size(100, 23);
            this.LabelVar.TabIndex = 5;
            this.LabelVar.Click += new System.EventHandler(this.LabelVar_Click);
            // 
            // ChangeVar
            // 
            this.ChangeVar.Location = new System.Drawing.Point(12, 59);
            this.ChangeVar.Name = "ChangeVar";
            this.ChangeVar.Size = new System.Drawing.Size(99, 23);
            this.ChangeVar.TabIndex = 6;
            this.ChangeVar.Text = "Change Value";
            this.ChangeVar.UseVisualStyleBackColor = true;
            this.ChangeVar.Click += new System.EventHandler(this.ChangeVar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 105);
            this.Controls.Add(this.ChangeVar);
            this.Controls.Add(this.LabelVar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelVar;
        private System.Windows.Forms.Button ChangeVar;
    }
}

