using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
/// <summary>
///ログイン画面
///
/// 作成日　2023/12/7
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    public partial class ScreenPassword : Form
    {
        public ScreenPassword()
        {
            InitializeComponent();
        }
        private void NextClick(object sender, EventArgs e)
        {
            //ログインするためにパスワードと氏名を記入
            string name = NameText.Text;
            string password = PasswordText.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("ユーザー名とパスワードを入力してください。");
                return;
            }

            if (CheckLogin(name, password))
            {
                MessageBox.Show("ログイン成功！");
                MessageBox.Show(Convert.ToString(LoginUser_Info.CD));
                //ここでメインフォームなどに遷移する処理を追加
                ScreenMymeny menu = new ScreenMymeny();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ログイン失敗。ユーザー名またはパスワードが正しくありません。");
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //ログイン又は新規登録選択画面にシーン遷移
            ScreenMain SM = new ScreenMain();
            SM.Visible = true;
            this.Hide();
        }
        private bool CheckLogin(string username, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();
                //stringに入っている自分のデータ読み込み      
                string query = "SELECT CD FROM t_product2 WHERE productname = @productname AND password = @password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@productname", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        LoginUser_Info.CD = Convert.ToInt32(result);
                        return Convert.ToInt32(result) > 0;
                    }
                    else
                    {
                        // もしくはエラー処理を追加
                        return false;
                    }

                }
            }
        }

        private void ScreenPassword2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                //DataTableを作成します。
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product2", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
