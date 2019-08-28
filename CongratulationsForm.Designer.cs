namespace BullsAndCowsGame
{
    partial class CongratulationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongratulationsForm));
            this.CongratLabel = new System.Windows.Forms.Label();
            this.PlayOneMoreTimeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AnswerNumLabel = new System.Windows.Forms.Label();
            this.fvthPlayerResultLabel = new System.Windows.Forms.Label();
            this.frthPlayerResultLabel = new System.Windows.Forms.Label();
            this.fvthPlayerNameLabel = new System.Windows.Forms.Label();
            this.frthPlayerNameLabel = new System.Windows.Forms.Label();
            this.fvthRank = new System.Windows.Forms.Label();
            this.frthRank = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thrdRank = new System.Windows.Forms.Label();
            this.scndRank = new System.Windows.Forms.Label();
            this.fstRank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thrdPlayerResultLabel = new System.Windows.Forms.Label();
            this.thrdPlayerNameLabel = new System.Windows.Forms.Label();
            this.scndPlayerResultLabel = new System.Windows.Forms.Label();
            this.scndPlayerNameLabel = new System.Windows.Forms.Label();
            this.fstPlayerResultLabel = new System.Windows.Forms.Label();
            this.fstPlayerNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CongratLabel
            // 
            this.CongratLabel.AutoSize = true;
            this.CongratLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.CongratLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CongratLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratLabel.Location = new System.Drawing.Point(161, 20);
            this.CongratLabel.Name = "CongratLabel";
            this.CongratLabel.Size = new System.Drawing.Size(230, 32);
            this.CongratLabel.TabIndex = 0;
            this.CongratLabel.Text = "Вы угадали число!";
            // 
            // PlayOneMoreTimeButton
            // 
            this.PlayOneMoreTimeButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayOneMoreTimeButton.Location = new System.Drawing.Point(98, 99);
            this.PlayOneMoreTimeButton.Name = "PlayOneMoreTimeButton";
            this.PlayOneMoreTimeButton.Size = new System.Drawing.Size(94, 25);
            this.PlayOneMoreTimeButton.TabIndex = 1;
            this.PlayOneMoreTimeButton.Text = "Сыграть еще ";
            this.PlayOneMoreTimeButton.UseVisualStyleBackColor = true;
            this.PlayOneMoreTimeButton.Click += new System.EventHandler(this.PlayOneMoreTimeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(363, 99);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AnswerNumLabel
            // 
            this.AnswerNumLabel.AutoSize = true;
            this.AnswerNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnswerNumLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerNumLabel.Location = new System.Drawing.Point(235, 65);
            this.AnswerNumLabel.Name = "AnswerNumLabel";
            this.AnswerNumLabel.Size = new System.Drawing.Size(81, 34);
            this.AnswerNumLabel.TabIndex = 3;
            this.AnswerNumLabel.Text = "label1";
            // 
            // fvthPlayerResultLabel
            // 
            this.fvthPlayerResultLabel.AutoSize = true;
            this.fvthPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fvthPlayerResultLabel.Location = new System.Drawing.Point(310, 330);
            this.fvthPlayerResultLabel.Name = "fvthPlayerResultLabel";
            this.fvthPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.fvthPlayerResultLabel.TabIndex = 40;
            this.fvthPlayerResultLabel.Text = "рез5";
            this.fvthPlayerResultLabel.Visible = false;
            // 
            // frthPlayerResultLabel
            // 
            this.frthPlayerResultLabel.AutoSize = true;
            this.frthPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frthPlayerResultLabel.Location = new System.Drawing.Point(310, 302);
            this.frthPlayerResultLabel.Name = "frthPlayerResultLabel";
            this.frthPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.frthPlayerResultLabel.TabIndex = 39;
            this.frthPlayerResultLabel.Text = "рез4";
            this.frthPlayerResultLabel.Visible = false;
            // 
            // fvthPlayerNameLabel
            // 
            this.fvthPlayerNameLabel.AutoSize = true;
            this.fvthPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fvthPlayerNameLabel.Location = new System.Drawing.Point(228, 329);
            this.fvthPlayerNameLabel.Name = "fvthPlayerNameLabel";
            this.fvthPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.fvthPlayerNameLabel.TabIndex = 38;
            this.fvthPlayerNameLabel.Text = "ник5";
            this.fvthPlayerNameLabel.Visible = false;
            // 
            // frthPlayerNameLabel
            // 
            this.frthPlayerNameLabel.AutoSize = true;
            this.frthPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frthPlayerNameLabel.Location = new System.Drawing.Point(228, 302);
            this.frthPlayerNameLabel.Name = "frthPlayerNameLabel";
            this.frthPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.frthPlayerNameLabel.TabIndex = 37;
            this.frthPlayerNameLabel.Text = "ник4";
            this.frthPlayerNameLabel.Visible = false;
            // 
            // fvthRank
            // 
            this.fvthRank.AutoSize = true;
            this.fvthRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fvthRank.Location = new System.Drawing.Point(189, 329);
            this.fvthRank.Name = "fvthRank";
            this.fvthRank.Size = new System.Drawing.Size(15, 17);
            this.fvthRank.TabIndex = 36;
            this.fvthRank.Text = "5";
            this.fvthRank.Visible = false;
            // 
            // frthRank
            // 
            this.frthRank.AutoSize = true;
            this.frthRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frthRank.Location = new System.Drawing.Point(189, 302);
            this.frthRank.Name = "frthRank";
            this.frthRank.Size = new System.Drawing.Size(15, 17);
            this.frthRank.TabIndex = 35;
            this.frthRank.Text = "4";
            this.frthRank.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(299, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Попытки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Имя";
            // 
            // thrdRank
            // 
            this.thrdRank.AutoSize = true;
            this.thrdRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thrdRank.Location = new System.Drawing.Point(189, 275);
            this.thrdRank.Name = "thrdRank";
            this.thrdRank.Size = new System.Drawing.Size(15, 17);
            this.thrdRank.TabIndex = 32;
            this.thrdRank.Text = "3";
            this.thrdRank.Visible = false;
            // 
            // scndRank
            // 
            this.scndRank.AutoSize = true;
            this.scndRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scndRank.Location = new System.Drawing.Point(189, 250);
            this.scndRank.Name = "scndRank";
            this.scndRank.Size = new System.Drawing.Size(15, 17);
            this.scndRank.TabIndex = 31;
            this.scndRank.Text = "2";
            this.scndRank.Visible = false;
            // 
            // fstRank
            // 
            this.fstRank.AutoSize = true;
            this.fstRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fstRank.Location = new System.Drawing.Point(189, 226);
            this.fstRank.Name = "fstRank";
            this.fstRank.Size = new System.Drawing.Size(15, 17);
            this.fstRank.TabIndex = 30;
            this.fstRank.Text = "1";
            this.fstRank.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(174, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "ТАБЛИЦА РЕКОРДОВ";
            // 
            // thrdPlayerResultLabel
            // 
            this.thrdPlayerResultLabel.AutoSize = true;
            this.thrdPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrdPlayerResultLabel.Location = new System.Drawing.Point(310, 276);
            this.thrdPlayerResultLabel.Name = "thrdPlayerResultLabel";
            this.thrdPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.thrdPlayerResultLabel.TabIndex = 28;
            this.thrdPlayerResultLabel.Text = "рез3";
            this.thrdPlayerResultLabel.Visible = false;
            // 
            // thrdPlayerNameLabel
            // 
            this.thrdPlayerNameLabel.AutoSize = true;
            this.thrdPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thrdPlayerNameLabel.Location = new System.Drawing.Point(228, 276);
            this.thrdPlayerNameLabel.Name = "thrdPlayerNameLabel";
            this.thrdPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.thrdPlayerNameLabel.TabIndex = 27;
            this.thrdPlayerNameLabel.Text = "ник3";
            this.thrdPlayerNameLabel.Visible = false;
            // 
            // scndPlayerResultLabel
            // 
            this.scndPlayerResultLabel.AutoSize = true;
            this.scndPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndPlayerResultLabel.Location = new System.Drawing.Point(310, 251);
            this.scndPlayerResultLabel.Name = "scndPlayerResultLabel";
            this.scndPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.scndPlayerResultLabel.TabIndex = 26;
            this.scndPlayerResultLabel.Text = "рез2";
            this.scndPlayerResultLabel.Visible = false;
            // 
            // scndPlayerNameLabel
            // 
            this.scndPlayerNameLabel.AutoSize = true;
            this.scndPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scndPlayerNameLabel.Location = new System.Drawing.Point(228, 251);
            this.scndPlayerNameLabel.Name = "scndPlayerNameLabel";
            this.scndPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.scndPlayerNameLabel.TabIndex = 25;
            this.scndPlayerNameLabel.Text = "ник2";
            this.scndPlayerNameLabel.Visible = false;
            // 
            // fstPlayerResultLabel
            // 
            this.fstPlayerResultLabel.AutoSize = true;
            this.fstPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstPlayerResultLabel.Location = new System.Drawing.Point(310, 226);
            this.fstPlayerResultLabel.Name = "fstPlayerResultLabel";
            this.fstPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.fstPlayerResultLabel.TabIndex = 24;
            this.fstPlayerResultLabel.Text = "рез1";
            this.fstPlayerResultLabel.Visible = false;
            // 
            // fstPlayerNameLabel
            // 
            this.fstPlayerNameLabel.AutoSize = true;
            this.fstPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fstPlayerNameLabel.Location = new System.Drawing.Point(228, 226);
            this.fstPlayerNameLabel.Name = "fstPlayerNameLabel";
            this.fstPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.fstPlayerNameLabel.TabIndex = 23;
            this.fstPlayerNameLabel.Text = "ник1";
            this.fstPlayerNameLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(166, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 193);
            this.button1.TabIndex = 41;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CongratulationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 365);
            this.ControlBox = false;
            this.Controls.Add(this.fvthPlayerResultLabel);
            this.Controls.Add(this.frthPlayerResultLabel);
            this.Controls.Add(this.fvthPlayerNameLabel);
            this.Controls.Add(this.frthPlayerNameLabel);
            this.Controls.Add(this.fvthRank);
            this.Controls.Add(this.frthRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thrdRank);
            this.Controls.Add(this.scndRank);
            this.Controls.Add(this.fstRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thrdPlayerResultLabel);
            this.Controls.Add(this.thrdPlayerNameLabel);
            this.Controls.Add(this.scndPlayerResultLabel);
            this.Controls.Add(this.scndPlayerNameLabel);
            this.Controls.Add(this.fstPlayerResultLabel);
            this.Controls.Add(this.fstPlayerNameLabel);
            this.Controls.Add(this.AnswerNumLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayOneMoreTimeButton);
            this.Controls.Add(this.CongratLabel);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CongratulationsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CongratulationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CongratLabel;
        private System.Windows.Forms.Button PlayOneMoreTimeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label AnswerNumLabel;
        private System.Windows.Forms.Label fvthPlayerResultLabel;
        private System.Windows.Forms.Label frthPlayerResultLabel;
        private System.Windows.Forms.Label fvthPlayerNameLabel;
        private System.Windows.Forms.Label frthPlayerNameLabel;
        private System.Windows.Forms.Label fvthRank;
        private System.Windows.Forms.Label frthRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label thrdRank;
        private System.Windows.Forms.Label scndRank;
        private System.Windows.Forms.Label fstRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label thrdPlayerResultLabel;
        private System.Windows.Forms.Label thrdPlayerNameLabel;
        private System.Windows.Forms.Label scndPlayerResultLabel;
        private System.Windows.Forms.Label scndPlayerNameLabel;
        private System.Windows.Forms.Label fstPlayerResultLabel;
        private System.Windows.Forms.Label fstPlayerNameLabel;
        private System.Windows.Forms.Button button1;
    }
}