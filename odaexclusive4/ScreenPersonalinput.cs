using System;
using System.Windows.Forms;
using System.Data.SQLite;
/// <summary>
///新規登録画面
///
/// 作成日　2023/12/7
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    public partial class ScreenPersonalinput : Form
    {
        public ScreenPersonalinput()
        {
            InitializeComponent();
        }

        private void NextClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート
                    cmd.CommandText =
                        "INSERT INTO t_product2(productname, telephone, password, height, weight) " +
                        "VALUES (@name, @telephone, @password, @height, @weight)";

                    // パラメータセット
                    cmd.Parameters.Add(new SQLiteParameter("@name", System.Data.DbType.String));
                    cmd.Parameters.Add(new SQLiteParameter("@telephone", System.Data.DbType.Int64));
                    cmd.Parameters.Add(new SQLiteParameter("@password", System.Data.DbType.Int64));
                    cmd.Parameters.Add(new SQLiteParameter("@height", System.Data.DbType.Int16));
                    cmd.Parameters.Add(new SQLiteParameter("@weight", System.Data.DbType.Int16));

                    // データ追加
                    cmd.Parameters["@name"].Value = NameText.Text;
                    cmd.Parameters["@telephone"].Value = long.Parse(TelephoneText.Text);
                    cmd.Parameters["@password"].Value = long.Parse(PasswordText.Text);
                    cmd.Parameters["@height"].Value = short.Parse(HeightText.Text);
                    cmd.Parameters["@weight"].Value = short.Parse(WeightText.Text);

                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
            }
            //ログイン又は新規登録選択画面にシーン遷移
            ScreenMain SM = new ScreenMain();
            SM.Show();
            this.Hide();
        }

        private void BackClick(object sender, EventArgs e)
        {
            //ログイン又は新規登録選択画面にシーン遷移
            ScreenMain SL = new ScreenMain();
            SL.Show();
            this.Hide();
        }
    }
}
