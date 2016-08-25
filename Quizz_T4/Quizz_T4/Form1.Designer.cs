namespace Quizz_T4
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAnsr1 = new System.Windows.Forms.Button();
            this.btnAnsr2 = new System.Windows.Forms.Button();
            this.btnAnsr3 = new System.Windows.Forms.Button();
            this.btnAnsr4 = new System.Windows.Forms.Button();
            this.rtbxQuestion = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tc.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabMenu);
            this.tc.Controls.Add(this.tabQuiz);
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Location = new System.Drawing.Point(1, 2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(333, 489);
            this.tc.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(325, 460);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // tabQuiz
            // 
            this.tabQuiz.Controls.Add(this.rtbxQuestion);
            this.tabQuiz.Controls.Add(this.btnAnsr4);
            this.tabQuiz.Controls.Add(this.btnAnsr3);
            this.tabQuiz.Controls.Add(this.btnAnsr2);
            this.tabQuiz.Controls.Add(this.btnAnsr1);
            this.tabQuiz.Location = new System.Drawing.Point(4, 25);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuiz.Size = new System.Drawing.Size(325, 460);
            this.tabQuiz.TabIndex = 1;
            this.tabQuiz.Text = "Quiz";
            this.tabQuiz.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(311, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Starta Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAnsr1
            // 
            this.btnAnsr1.Location = new System.Drawing.Point(6, 143);
            this.btnAnsr1.Name = "btnAnsr1";
            this.btnAnsr1.Size = new System.Drawing.Size(151, 116);
            this.btnAnsr1.TabIndex = 0;
            this.btnAnsr1.Text = "1";
            this.btnAnsr1.UseVisualStyleBackColor = true;
            // 
            // btnAnsr2
            // 
            this.btnAnsr2.Location = new System.Drawing.Point(163, 143);
            this.btnAnsr2.Name = "btnAnsr2";
            this.btnAnsr2.Size = new System.Drawing.Size(160, 116);
            this.btnAnsr2.TabIndex = 1;
            this.btnAnsr2.Text = "2";
            this.btnAnsr2.UseVisualStyleBackColor = true;
            // 
            // btnAnsr3
            // 
            this.btnAnsr3.Location = new System.Drawing.Point(8, 265);
            this.btnAnsr3.Name = "btnAnsr3";
            this.btnAnsr3.Size = new System.Drawing.Size(166, 186);
            this.btnAnsr3.TabIndex = 2;
            this.btnAnsr3.Text = "3";
            this.btnAnsr3.UseVisualStyleBackColor = true;
            this.btnAnsr3.Click += new System.EventHandler(this.btnAnsr3_Click);
            // 
            // btnAnsr4
            // 
            this.btnAnsr4.Location = new System.Drawing.Point(180, 268);
            this.btnAnsr4.Name = "btnAnsr4";
            this.btnAnsr4.Size = new System.Drawing.Size(140, 180);
            this.btnAnsr4.TabIndex = 3;
            this.btnAnsr4.Text = "4";
            this.btnAnsr4.UseVisualStyleBackColor = true;
            // 
            // rtbxQuestion
            // 
            this.rtbxQuestion.Location = new System.Drawing.Point(8, 7);
            this.rtbxQuestion.Name = "rtbxQuestion";
            this.rtbxQuestion.Size = new System.Drawing.Size(311, 130);
            this.rtbxQuestion.TabIndex = 4;
            this.rtbxQuestion.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 460);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kia grejor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 490);
            this.Controls.Add(this.tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabQuiz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbxQuestion;
        private System.Windows.Forms.Button btnAnsr4;
        private System.Windows.Forms.Button btnAnsr3;
        private System.Windows.Forms.Button btnAnsr2;
        private System.Windows.Forms.Button btnAnsr1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

