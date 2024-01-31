
namespace odaexclusive4
{
    partial class ScreenPassword
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(261, 466);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(204, 55);
            this.Back.TabIndex = 0;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Next.Location = new System.Drawing.Point(720, 466);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(204, 55);
            this.Next.TabIndex = 1;
            this.Next.Text = "次へ";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.NextClick);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameLabel.Location = new System.Drawing.Point(528, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(224, 77);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "氏名";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(452, 169);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(283, 22);
            this.NameText.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordLabel.Location = new System.Drawing.Point(463, 246);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(289, 66);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "パスワード";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(452, 346);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(283, 22);
            this.PasswordText.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "データ読み込み";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(855, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 171);
            this.dataGridView1.TabIndex = 7;
            // 
            // ScreenPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1219, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Name = "ScreenPassword2";
            this.Text = "ScreenPassword2";
            this.Load += new System.EventHandler(this.ScreenPassword2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}