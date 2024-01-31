
namespace odaexclusive4
{
    partial class ScreenChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.HeightLabe = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(362, 465);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(189, 76);
            this.Back.TabIndex = 0;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Next.Location = new System.Drawing.Point(676, 465);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(189, 76);
            this.Next.TabIndex = 1;
            this.Next.Text = "次へ";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.NextClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "氏名";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(200, 115);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(189, 22);
            this.NameText.TabIndex = 3;
            // 
            // TelephoneText
            // 
            this.TelephoneText.Location = new System.Drawing.Point(515, 115);
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(203, 22);
            this.TelephoneText.TabIndex = 5;
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TelephoneLabel.Location = new System.Drawing.Point(519, 33);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(199, 52);
            this.TelephoneLabel.TabIndex = 4;
            this.TelephoneLabel.Text = "電話番号";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(818, 115);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(189, 22);
            this.PasswordText.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordLabel.Location = new System.Drawing.Point(815, 33);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(192, 52);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "パスワード";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(200, 271);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(189, 22);
            this.HeightText.TabIndex = 9;
            // 
            // HeightLabe
            // 
            this.HeightLabe.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HeightLabe.Location = new System.Drawing.Point(241, 189);
            this.HeightLabe.Name = "HeightLabe";
            this.HeightLabe.Size = new System.Drawing.Size(123, 52);
            this.HeightLabe.TabIndex = 8;
            this.HeightLabe.Text = "身長";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(515, 271);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(203, 22);
            this.WeightText.TabIndex = 11;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeightLabel.Location = new System.Drawing.Point(564, 189);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(122, 52);
            this.WeightLabel.TabIndex = 10;
            this.WeightLabel.Text = "体重";
            // 
            // CdText
            // 
            this.CdText.Location = new System.Drawing.Point(818, 271);
            this.CdText.Name = "CdText";
            this.CdText.Size = new System.Drawing.Size(189, 22);
            this.CdText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(873, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 52);
            this.label2.TabIndex = 12;
            this.label2.Text = "CD";
            // 
            // ScreenChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1185, 574);
            this.Controls.Add(this.CdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.HeightLabe);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TelephoneText);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Name = "ScreenChange";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.Label HeightLabe;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox CdText;
        private System.Windows.Forms.Label label2;
    }
}