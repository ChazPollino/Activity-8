namespace Activity_8
{
    partial class ActivityForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FatsLabel = new System.Windows.Forms.Label();
            this.CarbsLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CarbsTextbox = new System.Windows.Forms.TextBox();
            this.FatsTextbox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DescritionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TitleLabel.Location = new System.Drawing.Point(215, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1023, 100);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Convert Fats And Carbs To Calories";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FatsLabel
            // 
            this.FatsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FatsLabel.Location = new System.Drawing.Point(113, 226);
            this.FatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FatsLabel.Name = "FatsLabel";
            this.FatsLabel.Size = new System.Drawing.Size(494, 58);
            this.FatsLabel.TabIndex = 1;
            this.FatsLabel.Text = "Enter Number Of Fats Consumed";
            this.FatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarbsLabel
            // 
            this.CarbsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CarbsLabel.Location = new System.Drawing.Point(113, 411);
            this.CarbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CarbsLabel.Name = "CarbsLabel";
            this.CarbsLabel.Size = new System.Drawing.Size(596, 57);
            this.CarbsLabel.TabIndex = 2;
            this.CarbsLabel.Text = "Enter Number Of Carbohydrates Consumed";
            this.CarbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ConvertButton.Location = new System.Drawing.Point(546, 536);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(316, 91);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarbsTextbox
            // 
            this.CarbsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CarbsTextbox.Location = new System.Drawing.Point(1065, 406);
            this.CarbsTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarbsTextbox.Multiline = true;
            this.CarbsTextbox.Name = "CarbsTextbox";
            this.CarbsTextbox.Size = new System.Drawing.Size(223, 57);
            this.CarbsTextbox.TabIndex = 4;
            // 
            // FatsTextbox
            // 
            this.FatsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FatsTextbox.Location = new System.Drawing.Point(1065, 222);
            this.FatsTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FatsTextbox.Multiline = true;
            this.FatsTextbox.Name = "FatsTextbox";
            this.FatsTextbox.Size = new System.Drawing.Size(223, 58);
            this.FatsTextbox.TabIndex = 5;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ClearButton.Location = new System.Drawing.Point(43, 538);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(316, 91);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ExitButton.Location = new System.Drawing.Point(1025, 540);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(316, 90);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DescritionLabel
            // 
            this.DescritionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescritionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescritionLabel.Location = new System.Drawing.Point(91, 700);
            this.DescritionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescritionLabel.Name = "DescritionLabel";
            this.DescritionLabel.Size = new System.Drawing.Size(583, 58);
            this.DescritionLabel.TabIndex = 8;
            this.DescritionLabel.Text = "This Is Your Daily Calories";
            this.DescritionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnswerLabel.Location = new System.Drawing.Point(934, 694);
            this.AnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(288, 64);
            this.AnswerLabel.TabIndex = 9;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1398, 894);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.DescritionLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FatsTextbox);
            this.Controls.Add(this.CarbsTextbox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.CarbsLabel);
            this.Controls.Add(this.FatsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ActivityForm";
            this.Text = "Convert Fats And Carbs To Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FatsLabel;
        private System.Windows.Forms.Label CarbsLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox CarbsTextbox;
        private System.Windows.Forms.TextBox FatsTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DescritionLabel;
        private System.Windows.Forms.Label AnswerLabel;
    }
}

