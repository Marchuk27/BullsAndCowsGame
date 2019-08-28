namespace BullsAndCowsGame
{
    partial class GameMediumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMediumForm));
            this.EnterNumLabel = new System.Windows.Forms.Label();
            this.EnterNumTextBox = new System.Windows.Forms.TextBox();
            this.CheckResultButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Step1Label = new System.Windows.Forms.Label();
            this.Granitsa = new System.Windows.Forms.Button();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.BullAmount1 = new System.Windows.Forms.Label();
            this.CowAmount1 = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Step3Label = new System.Windows.Forms.Label();
            this.Step4Label = new System.Windows.Forms.Label();
            this.Step5Label = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num3 = new System.Windows.Forms.Label();
            this.Num4 = new System.Windows.Forms.Label();
            this.Num5 = new System.Windows.Forms.Label();
            this.BullAmount2 = new System.Windows.Forms.Label();
            this.BullAmount3 = new System.Windows.Forms.Label();
            this.BullAmount4 = new System.Windows.Forms.Label();
            this.BullAmount5 = new System.Windows.Forms.Label();
            this.CowAmount2 = new System.Windows.Forms.Label();
            this.CowAmount3 = new System.Windows.Forms.Label();
            this.CowAmount4 = new System.Windows.Forms.Label();
            this.CowAmount5 = new System.Windows.Forms.Label();
            this.TrueNumLabel = new System.Windows.Forms.Label();
            this.Step6Label = new System.Windows.Forms.Label();
            this.Num6 = new System.Windows.Forms.Label();
            this.BullAmount6 = new System.Windows.Forms.Label();
            this.CowAmount6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SoundButton = new System.Windows.Forms.Button();
            this.NumLogoButton = new System.Windows.Forms.Button();
            this.CowLogoButton = new System.Windows.Forms.Button();
            this.BullLogoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EnterNicknameLabel = new System.Windows.Forms.Label();
            this.EnterNicknameTextBox = new System.Windows.Forms.TextBox();
            this.EnterNicknameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterNumLabel
            // 
            this.EnterNumLabel.AutoSize = true;
            this.EnterNumLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNumLabel.Location = new System.Drawing.Point(38, 9);
            this.EnterNumLabel.Name = "EnterNumLabel";
            this.EnterNumLabel.Size = new System.Drawing.Size(151, 25);
            this.EnterNumLabel.TabIndex = 0;
            this.EnterNumLabel.Text = "Введите число:";
            this.EnterNumLabel.Visible = false;
            // 
            // EnterNumTextBox
            // 
            this.EnterNumTextBox.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNumTextBox.Location = new System.Drawing.Point(60, 54);
            this.EnterNumTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterNumTextBox.Name = "EnterNumTextBox";
            this.EnterNumTextBox.Size = new System.Drawing.Size(108, 29);
            this.EnterNumTextBox.TabIndex = 1;
            this.EnterNumTextBox.Visible = false;
            this.EnterNumTextBox.TextChanged += new System.EventHandler(this.EnterNumTextBox_TextChanged);
            this.EnterNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterNumTextBox_KeyPress);
            // 
            // CheckResultButton
            // 
            this.CheckResultButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckResultButton.Location = new System.Drawing.Point(43, 106);
            this.CheckResultButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckResultButton.Name = "CheckResultButton";
            this.CheckResultButton.Size = new System.Drawing.Size(146, 67);
            this.CheckResultButton.TabIndex = 2;
            this.CheckResultButton.Text = "Проверить результат";
            this.CheckResultButton.UseVisualStyleBackColor = true;
            this.CheckResultButton.Visible = false;
            this.CheckResultButton.Click += new System.EventHandler(this.CheckResultButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(450, 9);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(151, 30);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Результаты";
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step1Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step1Label.Location = new System.Drawing.Point(240, 152);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(106, 27);
            this.Step1Label.TabIndex = 6;
            this.Step1Label.Text = "Попытка 1";
            this.Step1Label.Visible = false;
            // 
            // Granitsa
            // 
            this.Granitsa.Enabled = false;
            this.Granitsa.Location = new System.Drawing.Point(218, 1);
            this.Granitsa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Granitsa.Name = "Granitsa";
            this.Granitsa.Size = new System.Drawing.Size(14, 497);
            this.Granitsa.TabIndex = 8;
            this.Granitsa.UseVisualStyleBackColor = true;
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num1Label.Location = new System.Drawing.Point(411, 153);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(0, 20);
            this.Num1Label.TabIndex = 9;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(414, 160);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(52, 21);
            this.Num1.TabIndex = 10;
            this.Num1.Text = "label1";
            this.Num1.Visible = false;
            // 
            // BullAmount1
            // 
            this.BullAmount1.AutoSize = true;
            this.BullAmount1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount1.Location = new System.Drawing.Point(514, 160);
            this.BullAmount1.Name = "BullAmount1";
            this.BullAmount1.Size = new System.Drawing.Size(52, 21);
            this.BullAmount1.TabIndex = 11;
            this.BullAmount1.Text = "label2";
            this.BullAmount1.Visible = false;
            // 
            // CowAmount1
            // 
            this.CowAmount1.AutoSize = true;
            this.CowAmount1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount1.Location = new System.Drawing.Point(609, 160);
            this.CowAmount1.Name = "CowAmount1";
            this.CowAmount1.Size = new System.Drawing.Size(52, 21);
            this.CowAmount1.TabIndex = 12;
            this.CowAmount1.Text = "label3";
            this.CowAmount1.Visible = false;
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step2Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step2Label.Location = new System.Drawing.Point(240, 212);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(106, 27);
            this.Step2Label.TabIndex = 13;
            this.Step2Label.Text = "Попытка 2";
            this.Step2Label.Visible = false;
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step3Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step3Label.Location = new System.Drawing.Point(240, 269);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(106, 27);
            this.Step3Label.TabIndex = 14;
            this.Step3Label.Text = "Попытка 3";
            this.Step3Label.Visible = false;
            // 
            // Step4Label
            // 
            this.Step4Label.AutoSize = true;
            this.Step4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step4Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step4Label.Location = new System.Drawing.Point(240, 328);
            this.Step4Label.Name = "Step4Label";
            this.Step4Label.Size = new System.Drawing.Size(106, 27);
            this.Step4Label.TabIndex = 15;
            this.Step4Label.Text = "Попытка 4";
            this.Step4Label.Visible = false;
            // 
            // Step5Label
            // 
            this.Step5Label.AutoSize = true;
            this.Step5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step5Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step5Label.Location = new System.Drawing.Point(240, 390);
            this.Step5Label.Name = "Step5Label";
            this.Step5Label.Size = new System.Drawing.Size(106, 27);
            this.Step5Label.TabIndex = 16;
            this.Step5Label.Text = "Попытка 5";
            this.Step5Label.Visible = false;
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(415, 220);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(52, 21);
            this.Num2.TabIndex = 17;
            this.Num2.Text = "label1";
            this.Num2.Visible = false;
            // 
            // Num3
            // 
            this.Num3.AutoSize = true;
            this.Num3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(415, 277);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(52, 21);
            this.Num3.TabIndex = 18;
            this.Num3.Text = "label1";
            this.Num3.Visible = false;
            // 
            // Num4
            // 
            this.Num4.AutoSize = true;
            this.Num4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(415, 336);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(52, 21);
            this.Num4.TabIndex = 19;
            this.Num4.Text = "label1";
            this.Num4.Visible = false;
            // 
            // Num5
            // 
            this.Num5.AutoSize = true;
            this.Num5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(415, 394);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(52, 21);
            this.Num5.TabIndex = 20;
            this.Num5.Text = "label1";
            this.Num5.Visible = false;
            // 
            // BullAmount2
            // 
            this.BullAmount2.AutoSize = true;
            this.BullAmount2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount2.Location = new System.Drawing.Point(514, 220);
            this.BullAmount2.Name = "BullAmount2";
            this.BullAmount2.Size = new System.Drawing.Size(52, 21);
            this.BullAmount2.TabIndex = 21;
            this.BullAmount2.Text = "label2";
            this.BullAmount2.Visible = false;
            // 
            // BullAmount3
            // 
            this.BullAmount3.AutoSize = true;
            this.BullAmount3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount3.Location = new System.Drawing.Point(514, 277);
            this.BullAmount3.Name = "BullAmount3";
            this.BullAmount3.Size = new System.Drawing.Size(52, 21);
            this.BullAmount3.TabIndex = 22;
            this.BullAmount3.Text = "label2";
            this.BullAmount3.Visible = false;
            // 
            // BullAmount4
            // 
            this.BullAmount4.AutoSize = true;
            this.BullAmount4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount4.Location = new System.Drawing.Point(514, 336);
            this.BullAmount4.Name = "BullAmount4";
            this.BullAmount4.Size = new System.Drawing.Size(52, 21);
            this.BullAmount4.TabIndex = 23;
            this.BullAmount4.Text = "label3";
            this.BullAmount4.Visible = false;
            // 
            // BullAmount5
            // 
            this.BullAmount5.AutoSize = true;
            this.BullAmount5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount5.Location = new System.Drawing.Point(514, 394);
            this.BullAmount5.Name = "BullAmount5";
            this.BullAmount5.Size = new System.Drawing.Size(52, 21);
            this.BullAmount5.TabIndex = 24;
            this.BullAmount5.Text = "label4";
            this.BullAmount5.Visible = false;
            // 
            // CowAmount2
            // 
            this.CowAmount2.AutoSize = true;
            this.CowAmount2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount2.Location = new System.Drawing.Point(609, 220);
            this.CowAmount2.Name = "CowAmount2";
            this.CowAmount2.Size = new System.Drawing.Size(52, 21);
            this.CowAmount2.TabIndex = 25;
            this.CowAmount2.Text = "label3";
            this.CowAmount2.Visible = false;
            // 
            // CowAmount3
            // 
            this.CowAmount3.AutoSize = true;
            this.CowAmount3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount3.Location = new System.Drawing.Point(609, 277);
            this.CowAmount3.Name = "CowAmount3";
            this.CowAmount3.Size = new System.Drawing.Size(52, 21);
            this.CowAmount3.TabIndex = 26;
            this.CowAmount3.Text = "label3";
            this.CowAmount3.Visible = false;
            // 
            // CowAmount4
            // 
            this.CowAmount4.AutoSize = true;
            this.CowAmount4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount4.Location = new System.Drawing.Point(609, 336);
            this.CowAmount4.Name = "CowAmount4";
            this.CowAmount4.Size = new System.Drawing.Size(52, 21);
            this.CowAmount4.TabIndex = 27;
            this.CowAmount4.Text = "label3";
            this.CowAmount4.Visible = false;
            // 
            // CowAmount5
            // 
            this.CowAmount5.AutoSize = true;
            this.CowAmount5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount5.Location = new System.Drawing.Point(609, 394);
            this.CowAmount5.Name = "CowAmount5";
            this.CowAmount5.Size = new System.Drawing.Size(52, 21);
            this.CowAmount5.TabIndex = 28;
            this.CowAmount5.Text = "label3";
            this.CowAmount5.Visible = false;
            // 
            // TrueNumLabel
            // 
            this.TrueNumLabel.AutoSize = true;
            this.TrueNumLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueNumLabel.Location = new System.Drawing.Point(78, 340);
            this.TrueNumLabel.Name = "TrueNumLabel";
            this.TrueNumLabel.Size = new System.Drawing.Size(50, 20);
            this.TrueNumLabel.TabIndex = 29;
            this.TrueNumLabel.Text = "label2";
            this.TrueNumLabel.Visible = false;
            // 
            // Step6Label
            // 
            this.Step6Label.AutoSize = true;
            this.Step6Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Step6Label.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step6Label.Location = new System.Drawing.Point(240, 455);
            this.Step6Label.Name = "Step6Label";
            this.Step6Label.Size = new System.Drawing.Size(106, 27);
            this.Step6Label.TabIndex = 30;
            this.Step6Label.Text = "Попытка 6";
            this.Step6Label.Visible = false;
            // 
            // Num6
            // 
            this.Num6.AutoSize = true;
            this.Num6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(415, 459);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(52, 21);
            this.Num6.TabIndex = 31;
            this.Num6.Text = "label1";
            this.Num6.Visible = false;
            // 
            // BullAmount6
            // 
            this.BullAmount6.AutoSize = true;
            this.BullAmount6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BullAmount6.Location = new System.Drawing.Point(514, 459);
            this.BullAmount6.Name = "BullAmount6";
            this.BullAmount6.Size = new System.Drawing.Size(52, 21);
            this.BullAmount6.TabIndex = 32;
            this.BullAmount6.Text = "label4";
            this.BullAmount6.Visible = false;
            // 
            // CowAmount6
            // 
            this.CowAmount6.AutoSize = true;
            this.CowAmount6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowAmount6.Location = new System.Drawing.Point(609, 459);
            this.CowAmount6.Name = "CowAmount6";
            this.CowAmount6.Size = new System.Drawing.Size(52, 21);
            this.CowAmount6.TabIndex = 33;
            this.CowAmount6.Text = "label3";
            this.CowAmount6.Visible = false;
            // 
            // SoundButton
            // 
            this.SoundButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundButton.BackgroundImage")));
            this.SoundButton.Location = new System.Drawing.Point(240, 6);
            this.SoundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.Size = new System.Drawing.Size(34, 34);
            this.SoundButton.TabIndex = 0;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // NumLogoButton
            // 
            this.NumLogoButton.BackgroundImage = global::BullsAndCowsGame.Properties.Resources.NumLogo;
            this.NumLogoButton.Enabled = false;
            this.NumLogoButton.Location = new System.Drawing.Point(409, 66);
            this.NumLogoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumLogoButton.Name = "NumLogoButton";
            this.NumLogoButton.Size = new System.Drawing.Size(57, 59);
            this.NumLogoButton.TabIndex = 7;
            this.NumLogoButton.UseVisualStyleBackColor = true;
            // 
            // CowLogoButton
            // 
            this.CowLogoButton.BackgroundImage = global::BullsAndCowsGame.Properties.Resources.CowLogo;
            this.CowLogoButton.Enabled = false;
            this.CowLogoButton.Location = new System.Drawing.Point(603, 68);
            this.CowLogoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CowLogoButton.Name = "CowLogoButton";
            this.CowLogoButton.Size = new System.Drawing.Size(58, 58);
            this.CowLogoButton.TabIndex = 5;
            this.CowLogoButton.UseVisualStyleBackColor = true;
            // 
            // BullLogoButton
            // 
            this.BullLogoButton.BackgroundImage = global::BullsAndCowsGame.Properties.Resources.s1200;
            this.BullLogoButton.Enabled = false;
            this.BullLogoButton.Location = new System.Drawing.Point(506, 67);
            this.BullLogoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BullLogoButton.Name = "BullLogoButton";
            this.BullLogoButton.Size = new System.Drawing.Size(60, 59);
            this.BullLogoButton.TabIndex = 4;
            this.BullLogoButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 10000;
            this.errorProvider1.ContainerControl = this;
            // 
            // EnterNicknameLabel
            // 
            this.EnterNicknameLabel.AutoSize = true;
            this.EnterNicknameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNicknameLabel.Location = new System.Drawing.Point(38, 9);
            this.EnterNicknameLabel.Name = "EnterNicknameLabel";
            this.EnterNicknameLabel.Size = new System.Drawing.Size(130, 25);
            this.EnterNicknameLabel.TabIndex = 35;
            this.EnterNicknameLabel.Text = "Введите ник:";
            // 
            // EnterNicknameTextBox
            // 
            this.EnterNicknameTextBox.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNicknameTextBox.Location = new System.Drawing.Point(60, 54);
            this.EnterNicknameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterNicknameTextBox.Name = "EnterNicknameTextBox";
            this.EnterNicknameTextBox.Size = new System.Drawing.Size(108, 29);
            this.EnterNicknameTextBox.TabIndex = 36;
            // 
            // EnterNicknameButton
            // 
            this.EnterNicknameButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNicknameButton.Location = new System.Drawing.Point(43, 106);
            this.EnterNicknameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterNicknameButton.Name = "EnterNicknameButton";
            this.EnterNicknameButton.Size = new System.Drawing.Size(146, 67);
            this.EnterNicknameButton.TabIndex = 37;
            this.EnterNicknameButton.Text = "Ввести";
            this.EnterNicknameButton.UseVisualStyleBackColor = true;
            this.EnterNicknameButton.Click += new System.EventHandler(this.EnterNikButton_Click);
            this.EnterNicknameButton.Enter += new System.EventHandler(this.EnterNumTextBox_TextChanged);
            // 
            // GameMediumForm
            // 
            this.AcceptButton = this.CheckResultButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 502);
            this.Controls.Add(this.EnterNicknameButton);
            this.Controls.Add(this.EnterNicknameTextBox);
            this.Controls.Add(this.EnterNicknameLabel);
            this.Controls.Add(this.CowAmount6);
            this.Controls.Add(this.BullAmount6);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Step6Label);
            this.Controls.Add(this.SoundButton);
            this.Controls.Add(this.TrueNumLabel);
            this.Controls.Add(this.CowAmount5);
            this.Controls.Add(this.CowAmount4);
            this.Controls.Add(this.CowAmount3);
            this.Controls.Add(this.CowAmount2);
            this.Controls.Add(this.BullAmount5);
            this.Controls.Add(this.BullAmount4);
            this.Controls.Add(this.BullAmount3);
            this.Controls.Add(this.BullAmount2);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Step5Label);
            this.Controls.Add(this.Step4Label);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.CowAmount1);
            this.Controls.Add(this.BullAmount1);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.Granitsa);
            this.Controls.Add(this.NumLogoButton);
            this.Controls.Add(this.Step1Label);
            this.Controls.Add(this.CowLogoButton);
            this.Controls.Add(this.BullLogoButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CheckResultButton);
            this.Controls.Add(this.EnterNumTextBox);
            this.Controls.Add(this.EnterNumLabel);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(738, 541);
            this.MinimumSize = new System.Drawing.Size(738, 541);
            this.Name = "GameMediumForm";
            this.ShowInTaskbar = false;
            this.Text = "Угадайте число от 100 до 999";
            this.Load += new System.EventHandler(this.GameActiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNumLabel;
        private System.Windows.Forms.TextBox EnterNumTextBox;
        private System.Windows.Forms.Button CheckResultButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CowLogoButton;
        private System.Windows.Forms.Button BullLogoButton;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.Button NumLogoButton;
        private System.Windows.Forms.Button Granitsa;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label BullAmount1;
        private System.Windows.Forms.Label CowAmount1;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.Label Step4Label;
        private System.Windows.Forms.Label Step5Label;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num3;
        private System.Windows.Forms.Label Num4;
        private System.Windows.Forms.Label Num5;
        private System.Windows.Forms.Label BullAmount2;
        private System.Windows.Forms.Label BullAmount3;
        private System.Windows.Forms.Label BullAmount4;
        private System.Windows.Forms.Label BullAmount5;
        private System.Windows.Forms.Label CowAmount2;
        private System.Windows.Forms.Label CowAmount3;
        private System.Windows.Forms.Label CowAmount4;
        private System.Windows.Forms.Label CowAmount5;
        private System.Windows.Forms.Label TrueNumLabel;
        private System.Windows.Forms.Button SoundButton;
        private System.Windows.Forms.Label Step6Label;
        private System.Windows.Forms.Label Num6;
        private System.Windows.Forms.Label BullAmount6;
        private System.Windows.Forms.Label CowAmount6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label EnterNicknameLabel;
        private System.Windows.Forms.TextBox EnterNicknameTextBox;
        private System.Windows.Forms.Button EnterNicknameButton;
    }
}