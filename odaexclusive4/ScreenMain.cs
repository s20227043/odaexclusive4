using System;
using System.Windows.Forms;
using System.Data.SQLite;
/// <summary>
///ログイン又は新規登録選択画面
///
/// 作成日　2023/12/7
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    
    public partial class ScreenMain : Form
    {
        public ScreenMain()
        {
            InitializeComponent();
        }
        private void LoginClick(object sender, EventArgs e)
        {
            //氏名とパスワードの入力画面に遷移する
            ScreenPassword SP = new ScreenPassword();
            SP.Show();
            this.Hide();
        }
     
        private void SiginupClick(object sender, EventArgs e)
        {
            //テーブルの作成(t_product2)
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "CREATE TABLE IF NOT EXISTS t_product2(CD INTEGER PRIMARY KEY AUTOINCREMENT," +
                                          "productname TEXT, telephone TEXT, password TEXT, height TEXT, weight TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            ScreenPersonalinput SP = new ScreenPersonalinput();
            SP.Visible = true;
            this.Hide();
        }
        private void EndClick(object sender, EventArgs e)
        {
            //システムを終了
            Application.Exit();
        }
    }
}
