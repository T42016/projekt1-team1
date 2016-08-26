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
            this.btnStart = new System.Windows.Forms.Button();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.rtbxQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAnsr4 = new System.Windows.Forms.Button();
            this.btnAnsr3 = new System.Windows.Forms.Button();
            this.btnAnsr2 = new System.Windows.Forms.Button();
            this.btnAnsr1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbnQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.tbxAnswer4 = new System.Windows.Forms.TextBox();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tc.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabMenu);
            this.tc.Controls.Add(this.tabQuiz);
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Location = new System.Drawing.Point(1, 2);
            this.tc.Margin = new System.Windows.Forms.Padding(2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(250, 397);
            this.tc.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(2);
            this.tabMenu.Size = new System.Drawing.Size(242, 371);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 324);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(233, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Starta Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabQuiz
            // 
            this.tabQuiz.Controls.Add(this.rtbxQuestion);
            this.tabQuiz.Controls.Add(this.btnAnsr4);
            this.tabQuiz.Controls.Add(this.btnAnsr3);
            this.tabQuiz.Controls.Add(this.btnAnsr2);
            this.tabQuiz.Controls.Add(this.btnAnsr1);
            this.tabQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Padding = new System.Windows.Forms.Padding(2);
            this.tabQuiz.Size = new System.Drawing.Size(242, 371);
            this.tabQuiz.TabIndex = 1;
            this.tabQuiz.Text = "Quiz";
            this.tabQuiz.UseVisualStyleBackColor = true;
            // 
            // rtbxQuestion
            // 
            this.rtbxQuestion.Location = new System.Drawing.Point(6, 6);
            this.rtbxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.rtbxQuestion.Name = "rtbxQuestion";
            this.rtbxQuestion.Size = new System.Drawing.Size(234, 106);
            this.rtbxQuestion.TabIndex = 4;
            this.rtbxQuestion.Text = "";
            // 
            // btnAnsr4
            // 
            this.btnAnsr4.Location = new System.Drawing.Point(135, 218);
            this.btnAnsr4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr4.Name = "btnAnsr4";
            this.btnAnsr4.Size = new System.Drawing.Size(105, 146);
            this.btnAnsr4.TabIndex = 3;
            this.btnAnsr4.Text = "4";
            this.btnAnsr4.UseVisualStyleBackColor = true;
            // 
            // btnAnsr3
            // 
            this.btnAnsr3.Location = new System.Drawing.Point(6, 215);
            this.btnAnsr3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr3.Name = "btnAnsr3";
            this.btnAnsr3.Size = new System.Drawing.Size(124, 151);
            this.btnAnsr3.TabIndex = 2;
            this.btnAnsr3.Text = "3";
            this.btnAnsr3.UseVisualStyleBackColor = true;
            this.btnAnsr3.Click += new System.EventHandler(this.btnAnsr3_Click);
            // 
            // btnAnsr2
            // 
            this.btnAnsr2.Location = new System.Drawing.Point(122, 116);
            this.btnAnsr2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr2.Name = "btnAnsr2";
            this.btnAnsr2.Size = new System.Drawing.Size(120, 94);
            this.btnAnsr2.TabIndex = 1;
            this.btnAnsr2.Text = "2";
            this.btnAnsr2.UseVisualStyleBackColor = true;
            // 
            // btnAnsr1
            // 
            this.btnAnsr1.Location = new System.Drawing.Point(4, 116);
            this.btnAnsr1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr1.Name = "btnAnsr1";
            this.btnAnsr1.Size = new System.Drawing.Size(113, 94);
            this.btnAnsr1.TabIndex = 0;
            this.btnAnsr1.Text = "1";
            this.btnAnsr1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbnQuestion);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblCorrectAnswer);
            this.tabPage1.Controls.Add(this.lblAnswer4);
            this.tabPage1.Controls.Add(this.tbxAnswer4);
            this.tabPage1.Controls.Add(this.lblAnswer3);
            this.tabPage1.Controls.Add(this.tbxAnswer3);
            this.tabPage1.Controls.Add(this.lblAnswer2);
            this.tabPage1.Controls.Add(this.tbxAnswer2);
            this.tabPage1.Controls.Add(this.lblAnswer1);
            this.tabPage1.Controls.Add(this.tbxAnswer1);
            this.tabPage1.Controls.Add(this.lblQuestion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(242, 371);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kia grejor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbnQuestion
            // 
            this.rtbnQuestion.Location = new System.Drawing.Point(70, 20);
            this.rtbnQuestion.Name = "rtbnQuestion";
            this.rtbnQuestion.Size = new System.Drawing.Size(100, 119);
            this.rtbnQuestion.TabIndex = 12;
            this.rtbnQuestion.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(176, 46);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(56, 13);
            this.lblCorrectAnswer.TabIndex = 10;
            this.lblCorrectAnswer.Text = "<-- Correct";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(13, 237);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer4.TabIndex = 9;
            this.lblAnswer4.Text = "Answer 4";
            // 
            // tbxAnswer4
            // 
            this.tbxAnswer4.Location = new System.Drawing.Point(70, 230);
            this.tbxAnswer4.Name = "tbxAnswer4";
            this.tbxAnswer4.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer4.TabIndex = 8;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(13, 207);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer3.TabIndex = 7;
            this.lblAnswer3.Text = "Answer 3";
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Location = new System.Drawing.Point(70, 204);
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer3.TabIndex = 6;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(13, 178);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer2.TabIndex = 5;
            this.lblAnswer2.Text = "Answer 2";
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Location = new System.Drawing.Point(70, 178);
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer2.TabIndex = 4;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(13, 152);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "Answer 1";
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Location = new System.Drawing.Point(70, 152);
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer1.TabIndex = 2;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(7, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 398);
            this.Controls.Add(this.tc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabQuiz.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox tbxAnswer4;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.TextBox tbxAnswer3;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox tbxAnswer2;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.TextBox tbxAnswer1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox rtbnQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCorrectAnswer;
    }
}

