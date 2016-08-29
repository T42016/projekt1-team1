namespace Test_some_sound
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
            this.btnSound = new System.Windows.Forms.Button();
            this.btnPlaySound2 = new System.Windows.Forms.Button();
            this.btnPlaySound3 = new System.Windows.Forms.Button();
            this.btnPlaySound4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(12, 82);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(110, 47);
            this.btnSound.TabIndex = 0;
            this.btnSound.TabStop = false;
            this.btnSound.Text = "Play sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnPlaySound2
            // 
            this.btnPlaySound2.Location = new System.Drawing.Point(151, 82);
            this.btnPlaySound2.Name = "btnPlaySound2";
            this.btnPlaySound2.Size = new System.Drawing.Size(110, 47);
            this.btnPlaySound2.TabIndex = 1;
            this.btnPlaySound2.TabStop = false;
            this.btnPlaySound2.Text = "Play sound";
            this.btnPlaySound2.UseVisualStyleBackColor = true;
            this.btnPlaySound2.Click += new System.EventHandler(this.btnPlaySound2_Click);
            // 
            // btnPlaySound3
            // 
            this.btnPlaySound3.Location = new System.Drawing.Point(12, 156);
            this.btnPlaySound3.Name = "btnPlaySound3";
            this.btnPlaySound3.Size = new System.Drawing.Size(110, 47);
            this.btnPlaySound3.TabIndex = 2;
            this.btnPlaySound3.TabStop = false;
            this.btnPlaySound3.Text = "Play sound";
            this.btnPlaySound3.UseVisualStyleBackColor = true;
            this.btnPlaySound3.Click += new System.EventHandler(this.btnPlaySound3_Click);
            // 
            // btnPlaySound4
            // 
            this.btnPlaySound4.Location = new System.Drawing.Point(151, 156);
            this.btnPlaySound4.Name = "btnPlaySound4";
            this.btnPlaySound4.Size = new System.Drawing.Size(110, 47);
            this.btnPlaySound4.TabIndex = 3;
            this.btnPlaySound4.TabStop = false;
            this.btnPlaySound4.Text = "Play sound";
            this.btnPlaySound4.UseVisualStyleBackColor = true;
            this.btnPlaySound4.Click += new System.EventHandler(this.btnPlaySound4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPlaySound4);
            this.Controls.Add(this.btnPlaySound3);
            this.Controls.Add(this.btnPlaySound2);
            this.Controls.Add(this.btnSound);
            this.Name = "Form1";
            this.Text = "SOUND";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnPlaySound2;
        private System.Windows.Forms.Button btnPlaySound3;
        private System.Windows.Forms.Button btnPlaySound4;
    }
}

