﻿namespace ProjektLAB3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            positionComboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            ageTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 97);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 149);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 217);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 291);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Stanowisko";
            // 
            // positionComboBox
            // 
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "Stażysta", "Pracownik", "Kierownik" });
            positionComboBox.Location = new Point(173, 287);
            positionComboBox.Margin = new Padding(3, 4, 3, 4);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(138, 28);
            positionComboBox.TabIndex = 4;
            positionComboBox.TextChanged += comboBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(173, 401);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 403);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(173, 93);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(138, 27);
            firstNameTextBox.TabIndex = 7;
            firstNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(173, 145);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(138, 27);
            lastNameTextBox.TabIndex = 8;
            lastNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(173, 207);
            ageTextBox.Margin = new Padding(3, 4, 3, 4);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(138, 27);
            ageTextBox.TabIndex = 9;
            ageTextBox.TextChanged += textBox3_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 516);
            Controls.Add(ageTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(positionComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox positionComboBox;
        private Button button1;
        private Button button2;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox ageTextBox;
    }
}