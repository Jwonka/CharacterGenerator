namespace CharacterGenerator
{
    partial class CharacterGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            raceLabel = new Label();
            ageLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            statsGroupBox = new GroupBox();
            rollButton = new Button();
            chaLabel = new Label();
            conLabel = new Label();
            dexLabel = new Label();
            wisLabel = new Label();
            intLabel = new Label();
            strLabel = new Label();
            chaDescLabel = new Label();
            conDescLabel = new Label();
            dexDescLabel = new Label();
            wisDescLabel = new Label();
            intDescLabel = new Label();
            strDescLabel = new Label();
            generateButton = new Button();
            outputLabel = new Label();
            nameButton = new Button();
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            heightTextBox = new TextBox();
            weightTextBox = new TextBox();
            raceComboBox = new ComboBox();
            statsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 23);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new Point(17, 132);
            raceLabel.Margin = new Padding(4, 0, 4, 0);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(53, 25);
            raceLabel.TabIndex = 1;
            raceLabel.Text = "Race:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(17, 190);
            ageLabel.Margin = new Padding(4, 0, 4, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(48, 25);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(17, 252);
            heightLabel.Margin = new Padding(4, 0, 4, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(69, 25);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(17, 312);
            weightLabel.Margin = new Padding(4, 0, 4, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(72, 25);
            weightLabel.TabIndex = 4;
            weightLabel.Text = "Weight:";
            // 
            // statsGroupBox
            // 
            statsGroupBox.Controls.Add(rollButton);
            statsGroupBox.Controls.Add(chaLabel);
            statsGroupBox.Controls.Add(conLabel);
            statsGroupBox.Controls.Add(dexLabel);
            statsGroupBox.Controls.Add(wisLabel);
            statsGroupBox.Controls.Add(intLabel);
            statsGroupBox.Controls.Add(strLabel);
            statsGroupBox.Controls.Add(chaDescLabel);
            statsGroupBox.Controls.Add(conDescLabel);
            statsGroupBox.Controls.Add(dexDescLabel);
            statsGroupBox.Controls.Add(wisDescLabel);
            statsGroupBox.Controls.Add(intDescLabel);
            statsGroupBox.Controls.Add(strDescLabel);
            statsGroupBox.Location = new Point(263, 15);
            statsGroupBox.Margin = new Padding(4, 5, 4, 5);
            statsGroupBox.Name = "statsGroupBox";
            statsGroupBox.Padding = new Padding(4, 5, 4, 5);
            statsGroupBox.Size = new Size(187, 347);
            statsGroupBox.TabIndex = 5;
            statsGroupBox.TabStop = false;
            statsGroupBox.Text = "Stats";
            // 
            // rollButton
            // 
            rollButton.BackColor = Color.FromArgb(224, 224, 224);
            rollButton.ForeColor = Color.Black;
            rollButton.Location = new Point(31, 295);
            rollButton.Margin = new Padding(4, 5, 4, 5);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(107, 38);
            rollButton.TabIndex = 15;
            rollButton.Text = "Roll Stats";
            rollButton.UseVisualStyleBackColor = false;
            rollButton.Click += rollButton_Click;
            // 
            // chaLabel
            // 
            chaLabel.AutoSize = true;
            chaLabel.Location = new Point(71, 255);
            chaLabel.Margin = new Padding(4, 0, 4, 0);
            chaLabel.Name = "chaLabel";
            chaLabel.Size = new Size(20, 25);
            chaLabel.TabIndex = 14;
            chaLabel.Text = "*";
            // 
            // conLabel
            // 
            conLabel.AutoSize = true;
            conLabel.Location = new Point(74, 212);
            conLabel.Margin = new Padding(4, 0, 4, 0);
            conLabel.Name = "conLabel";
            conLabel.Size = new Size(20, 25);
            conLabel.TabIndex = 13;
            conLabel.Text = "*";
            // 
            // dexLabel
            // 
            dexLabel.AutoSize = true;
            dexLabel.Location = new Point(74, 160);
            dexLabel.Margin = new Padding(4, 0, 4, 0);
            dexLabel.Name = "dexLabel";
            dexLabel.Size = new Size(20, 25);
            dexLabel.TabIndex = 11;
            dexLabel.Text = "*";
            // 
            // wisLabel
            // 
            wisLabel.AutoSize = true;
            wisLabel.Location = new Point(74, 117);
            wisLabel.Margin = new Padding(4, 0, 4, 0);
            wisLabel.Name = "wisLabel";
            wisLabel.Size = new Size(20, 25);
            wisLabel.TabIndex = 10;
            wisLabel.Text = "*";
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Location = new Point(74, 72);
            intLabel.Margin = new Padding(4, 0, 4, 0);
            intLabel.Name = "intLabel";
            intLabel.Size = new Size(20, 25);
            intLabel.TabIndex = 9;
            intLabel.Text = "*";
            // 
            // strLabel
            // 
            strLabel.AutoSize = true;
            strLabel.Location = new Point(74, 32);
            strLabel.Margin = new Padding(4, 0, 4, 0);
            strLabel.Name = "strLabel";
            strLabel.Size = new Size(20, 25);
            strLabel.TabIndex = 8;
            strLabel.Text = "*";
            // 
            // chaDescLabel
            // 
            chaDescLabel.AutoSize = true;
            chaDescLabel.Location = new Point(7, 255);
            chaDescLabel.Margin = new Padding(4, 0, 4, 0);
            chaDescLabel.Name = "chaDescLabel";
            chaDescLabel.Size = new Size(48, 25);
            chaDescLabel.TabIndex = 7;
            chaDescLabel.Text = "CHA";
            // 
            // conDescLabel
            // 
            conDescLabel.AutoSize = true;
            conDescLabel.Location = new Point(9, 212);
            conDescLabel.Margin = new Padding(4, 0, 4, 0);
            conDescLabel.Name = "conDescLabel";
            conDescLabel.Size = new Size(50, 25);
            conDescLabel.TabIndex = 6;
            conDescLabel.Text = "CON";
            // 
            // dexDescLabel
            // 
            dexDescLabel.AutoSize = true;
            dexDescLabel.Location = new Point(7, 160);
            dexDescLabel.Margin = new Padding(4, 0, 4, 0);
            dexDescLabel.Name = "dexDescLabel";
            dexDescLabel.Size = new Size(45, 25);
            dexDescLabel.TabIndex = 5;
            dexDescLabel.Text = "DEX";
            // 
            // wisDescLabel
            // 
            wisDescLabel.AutoSize = true;
            wisDescLabel.Location = new Point(9, 117);
            wisDescLabel.Margin = new Padding(4, 0, 4, 0);
            wisDescLabel.Name = "wisDescLabel";
            wisDescLabel.Size = new Size(44, 25);
            wisDescLabel.TabIndex = 4;
            wisDescLabel.Text = "WIS";
            // 
            // intDescLabel
            // 
            intDescLabel.AutoSize = true;
            intDescLabel.Location = new Point(9, 72);
            intDescLabel.Margin = new Padding(4, 0, 4, 0);
            intDescLabel.Name = "intDescLabel";
            intDescLabel.Size = new Size(39, 25);
            intDescLabel.TabIndex = 3;
            intDescLabel.Text = "INT";
            // 
            // strDescLabel
            // 
            strDescLabel.AutoSize = true;
            strDescLabel.Location = new Point(9, 32);
            strDescLabel.Margin = new Padding(4, 0, 4, 0);
            strDescLabel.Name = "strDescLabel";
            strDescLabel.Size = new Size(42, 25);
            strDescLabel.TabIndex = 2;
            strDescLabel.Text = "STR";
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.FromArgb(224, 224, 224);
            generateButton.ForeColor = Color.Black;
            generateButton.Location = new Point(17, 380);
            generateButton.Margin = new Padding(4, 5, 4, 5);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(433, 38);
            generateButton.TabIndex = 16;
            generateButton.Text = "Generate Character";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(17, 431);
            outputLabel.Margin = new Padding(4, 0, 4, 0);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(433, 117);
            outputLabel.TabIndex = 17;
            // 
            // nameButton
            // 
            nameButton.BackColor = Color.FromArgb(224, 224, 224);
            nameButton.ForeColor = Color.Black;
            nameButton.Location = new Point(17, 77);
            nameButton.Margin = new Padding(4, 5, 4, 5);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(225, 38);
            nameButton.TabIndex = 18;
            nameButton.Text = "Create Random Name";
            nameButton.UseVisualStyleBackColor = false;
            nameButton.Click += nameButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(86, 23);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(156, 31);
            nameTextBox.TabIndex = 19;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(86, 190);
            ageTextBox.Margin = new Padding(4, 5, 4, 5);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(156, 31);
            ageTextBox.TabIndex = 20;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(86, 252);
            heightTextBox.Margin = new Padding(4, 5, 4, 5);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(156, 31);
            heightTextBox.TabIndex = 21;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(86, 307);
            weightTextBox.Margin = new Padding(4, 5, 4, 5);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(156, 31);
            weightTextBox.TabIndex = 22;
            // 
            // raceComboBox
            // 
            raceComboBox.FormattingEnabled = true;
            raceComboBox.Location = new Point(87, 130);
            raceComboBox.Margin = new Padding(4, 5, 4, 5);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(155, 33);
            raceComboBox.TabIndex = 23;
            // 
            // CharacterGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(463, 557);
            Controls.Add(raceComboBox);
            Controls.Add(weightTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(nameButton);
            Controls.Add(outputLabel);
            Controls.Add(generateButton);
            Controls.Add(statsGroupBox);
            Controls.Add(weightLabel);
            Controls.Add(heightLabel);
            Controls.Add(ageLabel);
            Controls.Add(raceLabel);
            Controls.Add(nameLabel);
            ForeColor = Color.White;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CharacterGeneratorForm";
            Text = "Character Generator";
            Load += CharacterGeneratorform_Load;
            statsGroupBox.ResumeLayout(false);
            statsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label raceLabel;
        private Label ageLabel;
        private Label heightLabel;
        private Label weightLabel;
        private GroupBox statsGroupBox;
        private Button rollButton;
        private Label chaLabel;
        private Label conLabel;
        private Label dexLabel;
        private Label wisLabel;
        private Label intLabel;
        private Label strLabel;
        private Label chaDescLabel;
        private Label conDescLabel;
        private Label dexDescLabel;
        private Label wisDescLabel;
        private Label intDescLabel;
        private Label strDescLabel;
        private Button generateButton;
        private Label outputLabel;
        private Button nameButton;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox heightTextBox;
        private TextBox weightTextBox;
        private ComboBox raceComboBox;
    }
}