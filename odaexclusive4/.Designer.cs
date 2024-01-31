
namespace odaexclusive
{
    partial class Screen_Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Endbutton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Signupbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Loginbutton.Location = new System.Drawing.Point(151, 219);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(200, 83);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "ログイン";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.button_Click);
            // 
            // Endbutton
            // 
            this.Endbutton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Endbutton.Location = new System.Drawing.Point(651, 219);
            this.Endbutton.Name = "Endbutton";
            this.Endbutton.Size = new System.Drawing.Size(200, 83);
            this.Endbutton.TabIndex = 3;
            this.Endbutton.Text = "終了";
            this.Endbutton.UseVisualStyleBackColor = true;
            this.Endbutton.Click += new System.EventHandler(this.end_button_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Title.Location = new System.Drawing.Point(381, 108);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(241, 34);
            this.Title.TabIndex = 4;
            this.Title.Text = "ODA筋トレクラブ";
            // 
            // Signupbutton
            // 
            this.Signupbutton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Signupbutton.Location = new System.Drawing.Point(403, 219);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(200, 83);
            this.Signupbutton.TabIndex = 5;
            this.Signupbutton.Text = "新規登録";
            this.Signupbutton.UseVisualStyleBackColor = true;
            this.Signupbutton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "テーブル生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(887, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "テーブル破壊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(722, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "データ読み込み";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(857, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(263, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Screen_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1167, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Endbutton);
            this.Controls.Add(this.Loginbutton);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Name = "Screen_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Endbutton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

