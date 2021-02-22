
namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.txtPlayerQuestion = new System.Windows.Forms.TextBox();
            this.txtAIAnswer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AiThink = new System.Windows.Forms.Timer(this.components);
            this.txtAIQuestion = new System.Windows.Forms.TextBox();
            this.txtPlayerAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(234, 193);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Start";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // txtPlayerQuestion
            // 
            this.txtPlayerQuestion.Location = new System.Drawing.Point(66, 92);
            this.txtPlayerQuestion.Name = "txtPlayerQuestion";
            this.txtPlayerQuestion.Size = new System.Drawing.Size(203, 20);
            this.txtPlayerQuestion.TabIndex = 1;
            // 
            // txtAIAnswer
            // 
            this.txtAIAnswer.Location = new System.Drawing.Point(66, 138);
            this.txtAIAnswer.Name = "txtAIAnswer";
            this.txtAIAnswer.ReadOnly = true;
            this.txtAIAnswer.Size = new System.Drawing.Size(203, 20);
            this.txtAIAnswer.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "AI-n ev du petqe mtapaheq 1-ic minchev 100 tiv: Khaxti na ov 8 qalic kgtni mtapah" +
    "vac tiv@:";
            // 
            // AiThink
            // 
            this.AiThink.Interval = 5000;
            // 
            // txtAIQuestion
            // 
            this.txtAIQuestion.Location = new System.Drawing.Point(275, 138);
            this.txtAIQuestion.Name = "txtAIQuestion";
            this.txtAIQuestion.ReadOnly = true;
            this.txtAIQuestion.Size = new System.Drawing.Size(203, 20);
            this.txtAIQuestion.TabIndex = 4;
            // 
            // txtPlayerAnswer
            // 
            this.txtPlayerAnswer.Location = new System.Drawing.Point(275, 92);
            this.txtPlayerAnswer.Name = "txtPlayerAnswer";
            this.txtPlayerAnswer.Size = new System.Drawing.Size(203, 20);
            this.txtPlayerAnswer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "ete meca dir >\r\nete poqra dir <\r\nete gtav tiv@ dir =\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "gri 1-ic 100 tiv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "AI";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(215, 251);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(105, 32);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restrat";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerAnswer);
            this.Controls.Add(this.txtAIQuestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAIAnswer);
            this.Controls.Add(this.txtPlayerQuestion);
            this.Controls.Add(this.BtnPlay);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.TextBox txtPlayerQuestion;
        private System.Windows.Forms.TextBox txtAIAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer AiThink;
        private System.Windows.Forms.TextBox txtAIQuestion;
        private System.Windows.Forms.TextBox txtPlayerAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestart;
    }
}

