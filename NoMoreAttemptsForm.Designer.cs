namespace BullsAndCowsGame
{
    partial class NoMoreAttemptsForm
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
            this.NoMoreAttemptsLabel = new System.Windows.Forms.Label();
            this.PlayOneMoreTimeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AnswerNumLabel = new System.Windows.Forms.Label();
            this.fstPlayerNameLabel = new System.Windows.Forms.Label();
            this.fstPlayerResultLabel = new System.Windows.Forms.Label();
            this.scndPlayerNameLabel = new System.Windows.Forms.Label();
            this.scndPlayerResultLabel = new System.Windows.Forms.Label();
            this.thrdPlayerNameLabel = new System.Windows.Forms.Label();
            this.thrdPlayerResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fstRank = new System.Windows.Forms.Label();
            this.scndRank = new System.Windows.Forms.Label();
            this.thrdRank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frthRank = new System.Windows.Forms.Label();
            this.fvthRank = new System.Windows.Forms.Label();
            this.frthPlayerNameLabel = new System.Windows.Forms.Label();
            this.fvthPlayerNameLabel = new System.Windows.Forms.Label();
            this.frthPlayerResultLabel = new System.Windows.Forms.Label();
            this.fvthPlayerResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoMoreAttemptsLabel
            // 
            this.NoMoreAttemptsLabel.AutoSize = true;
            this.NoMoreAttemptsLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoMoreAttemptsLabel.Location = new System.Drawing.Point(129, 11);
            this.NoMoreAttemptsLabel.Name = "NoMoreAttemptsLabel";
            this.NoMoreAttemptsLabel.Size = new System.Drawing.Size(230, 20);
            this.NoMoreAttemptsLabel.TabIndex = 0;
            this.NoMoreAttemptsLabel.Text = "ПОПЫТКИ ЗАКОНЧИЛИСЬ";
            // 
            // PlayOneMoreTimeButton
            // 
            this.PlayOneMoreTimeButton.Location = new System.Drawing.Point(51, 97);
            this.PlayOneMoreTimeButton.Name = "PlayOneMoreTimeButton";
            this.PlayOneMoreTimeButton.Size = new System.Drawing.Size(119, 28);
            this.PlayOneMoreTimeButton.TabIndex = 2;
            this.PlayOneMoreTimeButton.Text = "Сыграть еще ";
            this.PlayOneMoreTimeButton.UseVisualStyleBackColor = true;
            this.PlayOneMoreTimeButton.Click += new System.EventHandler(this.PlayOneMoreTimeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(274, 97);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 29);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AnswerNumLabel
            // 
            this.AnswerNumLabel.AutoSize = true;
            this.AnswerNumLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerNumLabel.Location = new System.Drawing.Point(129, 51);
            this.AnswerNumLabel.Name = "AnswerNumLabel";
            this.AnswerNumLabel.Size = new System.Drawing.Size(19, 21);
            this.AnswerNumLabel.TabIndex = 4;
            this.AnswerNumLabel.Text = "1";
            // 
            // fstPlayerNameLabel
            // 
            this.fstPlayerNameLabel.AutoSize = true;
            this.fstPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fstPlayerNameLabel.Location = new System.Drawing.Point(170, 232);
            this.fstPlayerNameLabel.Name = "fstPlayerNameLabel";
            this.fstPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.fstPlayerNameLabel.TabIndex = 5;
            this.fstPlayerNameLabel.Text = "ник1";
            this.fstPlayerNameLabel.Visible = false;
            // 
            // fstPlayerResultLabel
            // 
            this.fstPlayerResultLabel.AutoSize = true;
            this.fstPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstPlayerResultLabel.Location = new System.Drawing.Point(252, 232);
            this.fstPlayerResultLabel.Name = "fstPlayerResultLabel";
            this.fstPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.fstPlayerResultLabel.TabIndex = 6;
            this.fstPlayerResultLabel.Text = "рез1";
            this.fstPlayerResultLabel.Visible = false;
            // 
            // scndPlayerNameLabel
            // 
            this.scndPlayerNameLabel.AutoSize = true;
            this.scndPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scndPlayerNameLabel.Location = new System.Drawing.Point(170, 257);
            this.scndPlayerNameLabel.Name = "scndPlayerNameLabel";
            this.scndPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.scndPlayerNameLabel.TabIndex = 7;
            this.scndPlayerNameLabel.Text = "ник2";
            this.scndPlayerNameLabel.Visible = false;
            // 
            // scndPlayerResultLabel
            // 
            this.scndPlayerResultLabel.AutoSize = true;
            this.scndPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndPlayerResultLabel.Location = new System.Drawing.Point(252, 257);
            this.scndPlayerResultLabel.Name = "scndPlayerResultLabel";
            this.scndPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.scndPlayerResultLabel.TabIndex = 8;
            this.scndPlayerResultLabel.Text = "рез2";
            this.scndPlayerResultLabel.Visible = false;
            // 
            // thrdPlayerNameLabel
            // 
            this.thrdPlayerNameLabel.AutoSize = true;
            this.thrdPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thrdPlayerNameLabel.Location = new System.Drawing.Point(170, 282);
            this.thrdPlayerNameLabel.Name = "thrdPlayerNameLabel";
            this.thrdPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.thrdPlayerNameLabel.TabIndex = 9;
            this.thrdPlayerNameLabel.Text = "ник3";
            this.thrdPlayerNameLabel.Visible = false;
            // 
            // thrdPlayerResultLabel
            // 
            this.thrdPlayerResultLabel.AutoSize = true;
            this.thrdPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrdPlayerResultLabel.Location = new System.Drawing.Point(252, 282);
            this.thrdPlayerResultLabel.Name = "thrdPlayerResultLabel";
            this.thrdPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.thrdPlayerResultLabel.TabIndex = 10;
            this.thrdPlayerResultLabel.Text = "рез3";
            this.thrdPlayerResultLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(127, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ТАБЛИЦА РЕКОРДОВ";
            // 
            // fstRank
            // 
            this.fstRank.AutoSize = true;
            this.fstRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fstRank.Location = new System.Drawing.Point(142, 232);
            this.fstRank.Name = "fstRank";
            this.fstRank.Size = new System.Drawing.Size(15, 17);
            this.fstRank.TabIndex = 12;
            this.fstRank.Text = "1";
            this.fstRank.Visible = false;
            // 
            // scndRank
            // 
            this.scndRank.AutoSize = true;
            this.scndRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scndRank.Location = new System.Drawing.Point(142, 256);
            this.scndRank.Name = "scndRank";
            this.scndRank.Size = new System.Drawing.Size(15, 17);
            this.scndRank.TabIndex = 13;
            this.scndRank.Text = "2";
            this.scndRank.Visible = false;
            // 
            // thrdRank
            // 
            this.thrdRank.AutoSize = true;
            this.thrdRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thrdRank.Location = new System.Drawing.Point(142, 281);
            this.thrdRank.Name = "thrdRank";
            this.thrdRank.Size = new System.Drawing.Size(15, 17);
            this.thrdRank.TabIndex = 14;
            this.thrdRank.Text = "3";
            this.thrdRank.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(241, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Попытки";
            // 
            // frthRank
            // 
            this.frthRank.AutoSize = true;
            this.frthRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frthRank.Location = new System.Drawing.Point(142, 308);
            this.frthRank.Name = "frthRank";
            this.frthRank.Size = new System.Drawing.Size(15, 17);
            this.frthRank.TabIndex = 17;
            this.frthRank.Text = "4";
            this.frthRank.Visible = false;
            // 
            // fvthRank
            // 
            this.fvthRank.AutoSize = true;
            this.fvthRank.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fvthRank.Location = new System.Drawing.Point(142, 335);
            this.fvthRank.Name = "fvthRank";
            this.fvthRank.Size = new System.Drawing.Size(15, 17);
            this.fvthRank.TabIndex = 18;
            this.fvthRank.Text = "5";
            this.fvthRank.Visible = false;
            // 
            // frthPlayerNameLabel
            // 
            this.frthPlayerNameLabel.AutoSize = true;
            this.frthPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frthPlayerNameLabel.Location = new System.Drawing.Point(170, 308);
            this.frthPlayerNameLabel.Name = "frthPlayerNameLabel";
            this.frthPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.frthPlayerNameLabel.TabIndex = 19;
            this.frthPlayerNameLabel.Text = "ник4";
            this.frthPlayerNameLabel.Visible = false;
            // 
            // fvthPlayerNameLabel
            // 
            this.fvthPlayerNameLabel.AutoSize = true;
            this.fvthPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fvthPlayerNameLabel.Location = new System.Drawing.Point(170, 335);
            this.fvthPlayerNameLabel.Name = "fvthPlayerNameLabel";
            this.fvthPlayerNameLabel.Size = new System.Drawing.Size(38, 16);
            this.fvthPlayerNameLabel.TabIndex = 20;
            this.fvthPlayerNameLabel.Text = "ник5";
            this.fvthPlayerNameLabel.Visible = false;
            // 
            // frthPlayerResultLabel
            // 
            this.frthPlayerResultLabel.AutoSize = true;
            this.frthPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frthPlayerResultLabel.Location = new System.Drawing.Point(252, 308);
            this.frthPlayerResultLabel.Name = "frthPlayerResultLabel";
            this.frthPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.frthPlayerResultLabel.TabIndex = 21;
            this.frthPlayerResultLabel.Text = "рез4";
            this.frthPlayerResultLabel.Visible = false;
            // 
            // fvthPlayerResultLabel
            // 
            this.fvthPlayerResultLabel.AutoSize = true;
            this.fvthPlayerResultLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fvthPlayerResultLabel.Location = new System.Drawing.Point(252, 336);
            this.fvthPlayerResultLabel.Name = "fvthPlayerResultLabel";
            this.fvthPlayerResultLabel.Size = new System.Drawing.Size(39, 17);
            this.fvthPlayerResultLabel.TabIndex = 22;
            this.fvthPlayerResultLabel.Text = "рез5";
            this.fvthPlayerResultLabel.Visible = false;
            // 
            // NoMoreAttemptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 373);
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
            this.Controls.Add(this.NoMoreAttemptsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoMoreAttemptsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NoMoreAttemptsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoMoreAttemptsLabel;
        private System.Windows.Forms.Button PlayOneMoreTimeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label AnswerNumLabel;
        private System.Windows.Forms.Label fstPlayerNameLabel;
        private System.Windows.Forms.Label fstPlayerResultLabel;
        private System.Windows.Forms.Label scndPlayerNameLabel;
        private System.Windows.Forms.Label scndPlayerResultLabel;
        private System.Windows.Forms.Label thrdPlayerNameLabel;
        private System.Windows.Forms.Label thrdPlayerResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fstRank;
        private System.Windows.Forms.Label scndRank;
        private System.Windows.Forms.Label thrdRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label frthRank;
        private System.Windows.Forms.Label fvthRank;
        private System.Windows.Forms.Label frthPlayerNameLabel;
        private System.Windows.Forms.Label fvthPlayerNameLabel;
        private System.Windows.Forms.Label frthPlayerResultLabel;
        private System.Windows.Forms.Label fvthPlayerResultLabel;
    }
}