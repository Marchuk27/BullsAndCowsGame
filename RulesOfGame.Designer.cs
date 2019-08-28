namespace BullsAndCowsGame
{
    partial class RulesOfGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesOfGame));
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoButton.Enabled = false;
            this.InfoButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.Location = new System.Drawing.Point(0, -2);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(372, 397);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.UseVisualStyleBackColor = false;
            // 
            // RulesOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 342);
            this.Controls.Add(this.InfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesOfGame";
            this.Text = "Правила игры";
            this.Load += new System.EventHandler(this.RulesOfGame_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button InfoButton;
    }
}