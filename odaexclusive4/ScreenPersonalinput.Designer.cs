
namespace odaexclusive4
{
    partial class ScreenPersonalinput
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
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(276, 485);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(170, 70);
            this.Back.TabIndex = 0;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Next.Location = new System.Drawing.Point(773, 485);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(170, 70);
            this.Next.TabIndex = 1;
            this.Next.Text = "次へ";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.NextClick);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameLabel.Location = new System.Drawing.Point(240, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(134, 47);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "氏名";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(193, 128);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(193, 22);
            this.NameText.TabIndex = 3;
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TelephoneLabel.Location = new System.Drawing.Point(522, 49);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(241, 47);
            this.TelephoneLabel.TabIndex = 4;
            this.TelephoneLabel.Text = "電話番号";
            // 
            // TelephoneText
            // 
            this.TelephoneText.Location = new System.Drawing.Point(509, 128);
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(202, 22);
            this.TelephoneText.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordLabel.Location = new System.Drawing.Point(851, 49);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(236, 47);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "パスワード";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(845, 128);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(193, 22);
            this.PasswordText.TabIndex = 7;
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(352, 268);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(193, 22);
            this.HeightText.TabIndex = 9;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HeightLabel.Location = new System.Drawing.Point(397, 189);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(148, 47);
            this.HeightLabel.TabIndex = 8;
            this.HeightLabel.Text = "身長";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(675, 268);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(193, 22);
            this.WeightText.TabIndex = 11;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeightLabel.Location = new System.Drawing.Point(723, 189);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(145, 47);
            this.WeightLabel.TabIndex = 10;
            this.WeightLabel.Text = "体重";
            // 
            // ScreenPersonalinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1226, 585);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TelephoneText);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Name = "ScreenPersonalinput";
            this.Text = "ScreenPersonalinput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label WeightLabel;
    }
}