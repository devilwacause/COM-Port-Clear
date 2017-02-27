namespace COMPort_Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnF2Decline = new System.Windows.Forms.Button();
            this.btnF2Accept = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtF2Warning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnF2Decline
            // 
            this.btnF2Decline.Location = new System.Drawing.Point(325, 197);
            this.btnF2Decline.Name = "btnF2Decline";
            this.btnF2Decline.Size = new System.Drawing.Size(75, 23);
            this.btnF2Decline.TabIndex = 0;
            this.btnF2Decline.Text = "I Decline";
            this.btnF2Decline.UseVisualStyleBackColor = true;
            this.btnF2Decline.Click += new System.EventHandler(this.btnF2Decline_Click);
            // 
            // btnF2Accept
            // 
            this.btnF2Accept.Location = new System.Drawing.Point(183, 196);
            this.btnF2Accept.Name = "btnF2Accept";
            this.btnF2Accept.Size = new System.Drawing.Size(75, 23);
            this.btnF2Accept.TabIndex = 1;
            this.btnF2Accept.Text = "I Accept";
            this.btnF2Accept.UseVisualStyleBackColor = true;
            this.btnF2Accept.Click += new System.EventHandler(this.btnF2Accept_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(415, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "I accept all responsibility for using this software to reset COM ports via the Re" +
    "gistry.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtF2Warning
            // 
            this.txtF2Warning.Location = new System.Drawing.Point(84, 31);
            this.txtF2Warning.Multiline = true;
            this.txtF2Warning.Name = "txtF2Warning";
            this.txtF2Warning.ReadOnly = true;
            this.txtF2Warning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtF2Warning.Size = new System.Drawing.Size(415, 109);
            this.txtF2Warning.TabIndex = 3;
            this.txtF2Warning.Text = resources.GetString("txtF2Warning.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 261);
            this.ControlBox = false;
            this.Controls.Add(this.txtF2Warning);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnF2Accept);
            this.Controls.Add(this.btnF2Decline);
            this.Name = "Form2";
            this.Text = "User Responsibility Agreement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF2Decline;
        private System.Windows.Forms.Button btnF2Accept;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtF2Warning;
    }
}