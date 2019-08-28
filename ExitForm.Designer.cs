namespace BullsAndCowsGame
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.YesExitButton = new System.Windows.Forms.Button();
            this.NoExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите покинуть игру?";
            // 
            // YesExitButton
            // 
            this.YesExitButton.Location = new System.Drawing.Point(57, 30);
            this.YesExitButton.Name = "YesExitButton";
            this.YesExitButton.Size = new System.Drawing.Size(67, 26);
            this.YesExitButton.TabIndex = 1;
            this.YesExitButton.Text = "Да";
            this.YesExitButton.UseVisualStyleBackColor = true;
            this.YesExitButton.Click += new System.EventHandler(this.YesExitButton_Click);
            // 
            // NoExitButton
            // 
            this.NoExitButton.Location = new System.Drawing.Point(214, 30);
            this.NoExitButton.Name = "NoExitButton";
            this.NoExitButton.Size = new System.Drawing.Size(67, 26);
            this.NoExitButton.TabIndex = 2;
            this.NoExitButton.Text = "Нет";
            this.NoExitButton.UseVisualStyleBackColor = true;
            this.NoExitButton.Click += new System.EventHandler(this.NoExitButton_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 68);
            this.Controls.Add(this.NoExitButton);
            this.Controls.Add(this.YesExitButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesExitButton;
        private System.Windows.Forms.Button NoExitButton;
    }
}