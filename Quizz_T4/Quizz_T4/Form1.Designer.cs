﻿namespace Quizz_T4
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
            this.components = new System.ComponentModel.Container();
            this.tc = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.btnChooseQuiz = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnQuizCreator = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.gboxQuiz = new System.Windows.Forms.GroupBox();
            this.gbxQuiz = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.prgBar10s = new System.Windows.Forms.ProgressBar();
            this.rtbxQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAnsr4 = new System.Windows.Forms.Button();
            this.btnAnsr3 = new System.Windows.Forms.Button();
            this.btnAnsr2 = new System.Windows.Forms.Button();
            this.btnAnsr1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblError6 = new System.Windows.Forms.Label();
            this.lblError5 = new System.Windows.Forms.Label();
            this.lblError4 = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxQuizzName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lboxQuiz = new System.Windows.Forms.ListBox();
            this.lboxQuestions = new System.Windows.Forms.ListBox();
            this.rtbnQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.tbxAnswer4 = new System.Windows.Forms.TextBox();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer10s = new System.Windows.Forms.Timer(this.components);
            this.tc.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.gboxQuiz.SuspendLayout();
            this.gbxQuiz.SuspendLayout();
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
            this.tc.Size = new System.Drawing.Size(500, 432);
            this.tc.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnChooseQuiz);
            this.tabMenu.Controls.Add(this.btnResults);
            this.tabMenu.Controls.Add(this.btnQuizCreator);
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(2);
            this.tabMenu.Size = new System.Drawing.Size(492, 406);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // btnChooseQuiz
            // 
            this.btnChooseQuiz.Location = new System.Drawing.Point(227, 276);
            this.btnChooseQuiz.Name = "btnChooseQuiz";
            this.btnChooseQuiz.Size = new System.Drawing.Size(129, 53);
            this.btnChooseQuiz.TabIndex = 3;
            this.btnChooseQuiz.Text = "Choose Quiz";
            this.btnChooseQuiz.UseVisualStyleBackColor = true;
            this.btnChooseQuiz.Click += new System.EventHandler(this.btnChooseQuiz_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(92, 276);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(129, 53);
            this.btnResults.TabIndex = 2;
            this.btnResults.Text = "Previous Result";
            this.btnResults.UseVisualStyleBackColor = true;
            // 
            // btnQuizCreator
            // 
            this.btnQuizCreator.Location = new System.Drawing.Point(227, 214);
            this.btnQuizCreator.Name = "btnQuizCreator";
            this.btnQuizCreator.Size = new System.Drawing.Size(129, 53);
            this.btnQuizCreator.TabIndex = 1;
            this.btnQuizCreator.Text = "Quiz Creator";
            this.btnQuizCreator.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(92, 214);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 53);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabQuiz
            // 
            this.tabQuiz.Controls.Add(this.gboxQuiz);
            this.tabQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Padding = new System.Windows.Forms.Padding(2);
            this.tabQuiz.Size = new System.Drawing.Size(492, 406);
            this.tabQuiz.TabIndex = 1;
            this.tabQuiz.Text = "Quiz";
            this.tabQuiz.UseVisualStyleBackColor = true;
            // 
            // gboxQuiz
            // 
            this.gboxQuiz.Controls.Add(this.gbxQuiz);
            this.gboxQuiz.Location = new System.Drawing.Point(-4, 0);
            this.gboxQuiz.Name = "gboxQuiz";
            this.gboxQuiz.Size = new System.Drawing.Size(512, 410);
            this.gboxQuiz.TabIndex = 0;
            this.gboxQuiz.TabStop = false;
            // 
            // gbxQuiz
            // 
            this.gbxQuiz.Controls.Add(this.lblScore);
            this.gbxQuiz.Controls.Add(this.label1);
            this.gbxQuiz.Controls.Add(this.btnQuit);
            this.gbxQuiz.Controls.Add(this.prgBar10s);
            this.gbxQuiz.Controls.Add(this.rtbxQuestion);
            this.gbxQuiz.Controls.Add(this.btnAnsr4);
            this.gbxQuiz.Controls.Add(this.btnAnsr3);
            this.gbxQuiz.Controls.Add(this.btnAnsr2);
            this.gbxQuiz.Controls.Add(this.btnAnsr1);
            this.gbxQuiz.Location = new System.Drawing.Point(6, 3);
            this.gbxQuiz.Name = "gbxQuiz";
            this.gbxQuiz.Size = new System.Drawing.Size(490, 403);
            this.gbxQuiz.TabIndex = 0;
            this.gbxQuiz.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(43, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Points:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(22, 337);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(95, 53);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "Abort Mission!";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // prgBar10s
            // 
            this.prgBar10s.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prgBar10s.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.prgBar10s.Location = new System.Drawing.Point(138, 341);
            this.prgBar10s.Name = "prgBar10s";
            this.prgBar10s.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prgBar10s.Size = new System.Drawing.Size(237, 23);
            this.prgBar10s.TabIndex = 19;
            // 
            // rtbxQuestion
            // 
            this.rtbxQuestion.Location = new System.Drawing.Point(140, 18);
            this.rtbxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.rtbxQuestion.Name = "rtbxQuestion";
            this.rtbxQuestion.Size = new System.Drawing.Size(234, 106);
            this.rtbxQuestion.TabIndex = 18;
            this.rtbxQuestion.Text = "";
            // 
            // btnAnsr4
            // 
            this.btnAnsr4.Location = new System.Drawing.Point(264, 226);
            this.btnAnsr4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr4.Name = "btnAnsr4";
            this.btnAnsr4.Size = new System.Drawing.Size(111, 94);
            this.btnAnsr4.TabIndex = 17;
            this.btnAnsr4.Text = "4";
            this.btnAnsr4.UseVisualStyleBackColor = true;
            this.btnAnsr4.Click += new System.EventHandler(this.btnAnsr4_Click);
            // 
            // btnAnsr3
            // 
            this.btnAnsr3.Location = new System.Drawing.Point(138, 226);
            this.btnAnsr3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr3.Name = "btnAnsr3";
            this.btnAnsr3.Size = new System.Drawing.Size(113, 94);
            this.btnAnsr3.TabIndex = 16;
            this.btnAnsr3.Text = "3";
            this.btnAnsr3.UseVisualStyleBackColor = true;
            this.btnAnsr3.Click += new System.EventHandler(this.btnAnsr3_Click);
            // 
            // btnAnsr2
            // 
            this.btnAnsr2.Location = new System.Drawing.Point(264, 128);
            this.btnAnsr2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr2.Name = "btnAnsr2";
            this.btnAnsr2.Size = new System.Drawing.Size(110, 94);
            this.btnAnsr2.TabIndex = 15;
            this.btnAnsr2.Text = "2";
            this.btnAnsr2.UseVisualStyleBackColor = true;
            this.btnAnsr2.Click += new System.EventHandler(this.btnAnsr2_Click);
            // 
            // btnAnsr1
            // 
            this.btnAnsr1.BackColor = System.Drawing.Color.Transparent;
            this.btnAnsr1.Location = new System.Drawing.Point(138, 128);
            this.btnAnsr1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsr1.Name = "btnAnsr1";
            this.btnAnsr1.Size = new System.Drawing.Size(113, 94);
            this.btnAnsr1.TabIndex = 14;
            this.btnAnsr1.Text = "1";
            this.btnAnsr1.UseVisualStyleBackColor = false;
            this.btnAnsr1.Click += new System.EventHandler(this.btnAnsr1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblError6);
            this.tabPage1.Controls.Add(this.lblError5);
            this.tabPage1.Controls.Add(this.lblError4);
            this.tabPage1.Controls.Add(this.lblError3);
            this.tabPage1.Controls.Add(this.lblError2);
            this.tabPage1.Controls.Add(this.lblError1);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.tbxQuizzName);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.lboxQuiz);
            this.tabPage1.Controls.Add(this.lboxQuestions);
            this.tabPage1.Controls.Add(this.rtbnQuestion);
            this.tabPage1.Controls.Add(this.btnAdd);
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
            this.tabPage1.Size = new System.Drawing.Size(492, 406);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kia grejor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblError6
            // 
            this.lblError6.AutoSize = true;
            this.lblError6.ForeColor = System.Drawing.Color.Red;
            this.lblError6.Location = new System.Drawing.Point(186, 285);
            this.lblError6.Name = "lblError6";
            this.lblError6.Size = new System.Drawing.Size(11, 13);
            this.lblError6.TabIndex = 25;
            this.lblError6.Text = "*";
            this.lblError6.Visible = false;
            // 
            // lblError5
            // 
            this.lblError5.AutoSize = true;
            this.lblError5.ForeColor = System.Drawing.Color.Red;
            this.lblError5.Location = new System.Drawing.Point(186, 259);
            this.lblError5.Name = "lblError5";
            this.lblError5.Size = new System.Drawing.Size(11, 13);
            this.lblError5.TabIndex = 24;
            this.lblError5.Text = "*";
            this.lblError5.Visible = false;
            // 
            // lblError4
            // 
            this.lblError4.AutoSize = true;
            this.lblError4.ForeColor = System.Drawing.Color.Red;
            this.lblError4.Location = new System.Drawing.Point(186, 233);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(11, 13);
            this.lblError4.TabIndex = 23;
            this.lblError4.Text = "*";
            this.lblError4.Visible = false;
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(186, 207);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(11, 13);
            this.lblError3.TabIndex = 22;
            this.lblError3.Text = "*";
            this.lblError3.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(186, 75);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(11, 13);
            this.lblError2.TabIndex = 21;
            this.lblError2.Text = "*";
            this.lblError2.Visible = false;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(186, 23);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(11, 13);
            this.lblError1.TabIndex = 20;
            this.lblError1.Text = "*";
            this.lblError1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Quizz Name:";
            // 
            // tbxQuizzName
            // 
            this.tbxQuizzName.Location = new System.Drawing.Point(80, 20);
            this.tbxQuizzName.Name = "tbxQuizzName";
            this.tbxQuizzName.Size = new System.Drawing.Size(100, 20);
            this.tbxQuizzName.TabIndex = 18;
            this.tbxQuizzName.TextChanged += new System.EventHandler(this.tbxQuizzName_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add quiz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Remove question";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(365, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove quiz";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lboxQuiz
            // 
            this.lboxQuiz.FormattingEnabled = true;
            this.lboxQuiz.Location = new System.Drawing.Point(365, 20);
            this.lboxQuiz.Name = "lboxQuiz";
            this.lboxQuiz.Size = new System.Drawing.Size(110, 238);
            this.lboxQuiz.TabIndex = 14;
            // 
            // lboxQuestions
            // 
            this.lboxQuestions.FormattingEnabled = true;
            this.lboxQuestions.Location = new System.Drawing.Point(238, 20);
            this.lboxQuestions.Name = "lboxQuestions";
            this.lboxQuestions.Size = new System.Drawing.Size(110, 238);
            this.lboxQuestions.TabIndex = 13;
            // 
            // rtbnQuestion
            // 
            this.rtbnQuestion.Location = new System.Drawing.Point(80, 75);
            this.rtbnQuestion.Name = "rtbnQuestion";
            this.rtbnQuestion.Size = new System.Drawing.Size(100, 119);
            this.rtbnQuestion.TabIndex = 12;
            this.rtbnQuestion.Text = "";
            this.rtbnQuestion.TextChanged += new System.EventHandler(this.rtbnQuestion_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(7, 285);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer4.TabIndex = 9;
            this.lblAnswer4.Text = "Answer 4";
            // 
            // tbxAnswer4
            // 
            this.tbxAnswer4.Location = new System.Drawing.Point(80, 285);
            this.tbxAnswer4.Name = "tbxAnswer4";
            this.tbxAnswer4.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer4.TabIndex = 8;
            this.tbxAnswer4.TextChanged += new System.EventHandler(this.tbxAnswer4_TextChanged);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(7, 259);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer3.TabIndex = 7;
            this.lblAnswer3.Text = "Answer 3";
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Location = new System.Drawing.Point(80, 259);
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer3.TabIndex = 6;
            this.tbxAnswer3.TextChanged += new System.EventHandler(this.tbxAnswer3_TextChanged);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(7, 233);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer2.TabIndex = 5;
            this.lblAnswer2.Text = "Answer 2";
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Location = new System.Drawing.Point(80, 233);
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer2.TabIndex = 4;
            this.tbxAnswer2.TextChanged += new System.EventHandler(this.tbxAnswer2_TextChanged);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(7, 207);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(51, 13);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "Answer 1";
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Location = new System.Drawing.Point(80, 207);
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer1.TabIndex = 2;
            this.tbxAnswer1.Text = "Correct Answer";
            this.tbxAnswer1.Click += new System.EventHandler(this.tbxAnswer1_Click);
            this.tbxAnswer1.TextChanged += new System.EventHandler(this.tbxAnswer1_TextChanged);
            this.tbxAnswer1.Leave += new System.EventHandler(this.tbxAnswer1_Leave);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(7, 75);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // timer10s
            // 
            this.timer10s.Interval = 10;
            this.timer10s.Tick += new System.EventHandler(this.timer10s_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 435);
            this.Controls.Add(this.tc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabQuiz.ResumeLayout(false);
            this.gboxQuiz.ResumeLayout(false);
            this.gbxQuiz.ResumeLayout(false);
            this.gbxQuiz.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.Button btnStart;
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
        private System.Windows.Forms.Timer timer10s;
        private System.Windows.Forms.Button btnChooseQuiz;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnQuizCreator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lboxQuiz;
        private System.Windows.Forms.ListBox lboxQuestions;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxQuizzName;
        private System.Windows.Forms.Label lblError6;
        private System.Windows.Forms.Label lblError5;
        private System.Windows.Forms.Label lblError4;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.GroupBox gboxQuiz;
        private System.Windows.Forms.GroupBox gbxQuiz;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ProgressBar prgBar10s;
        private System.Windows.Forms.RichTextBox rtbxQuestion;
        private System.Windows.Forms.Button btnAnsr4;
        private System.Windows.Forms.Button btnAnsr3;
        private System.Windows.Forms.Button btnAnsr2;
        private System.Windows.Forms.Button btnAnsr1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
    }
}

