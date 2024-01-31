
namespace odaexclusive4
{
    partial class ScreenMain
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
            this.Login = new System.Windows.Forms.Button();
            this.Siginup = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Login.Location = new System.Drawing.Point(30, 252);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(319, 178);
            this.Login.TabIndex = 0;
            this.Login.Text = "ログイン";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.LoginClick);
            // 
            // Siginup
            // 
            this.Siginup.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Siginup.Location = new System.Drawing.Point(456, 252);
            this.Siginup.Name = "Siginup";
            this.Siginup.Size = new System.Drawing.Size(319, 178);
            this.Siginup.TabIndex = 2;
            this.Siginup.Text = "新規登録";
            this.Siginup.UseVisualStyleBackColor = true;
            this.Siginup.Click += new System.EventHandler(this.SiginupClick);
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.End.Location = new System.Drawing.Point(861, 252);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(319, 178);
            this.End.TabIndex = 3;
            this.End.Text = "終了";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.EndClick);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(336, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(584, 93);
            this.Title.TabIndex = 5;
            this.Title.Text = "ODA筋トレクラブ";
            // 
            // Screenmain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1214, 552);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Siginup);
            this.Controls.Add(this.Login);
            this.Name = "Screenmain2";
            this.Text = "Screenmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Siginup;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label Title;
    }
}

