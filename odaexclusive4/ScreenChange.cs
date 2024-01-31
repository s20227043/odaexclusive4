using System;
using System.Windows.Forms;
using System.Data.SQLite;
/// <summary>
///ユーザーの情報変更画面
///
/// 作成日　2023/12/8
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    public partial class ScreenChange : Form
    {
        public ScreenChange()
        {
            InitializeComponent();
        }
        private void NextClick(object sender, EventArgs e)
        {
            //using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            //{
            //    con.Open();
            //    using (SQLiteTransaction trans = con.BeginTransaction())
            //    {
            //        using (SQLiteCommand cmd = con.CreateCommand())
            //        {
            //            // インサート
            //            // 名前、電話番号、パスワード、身長、体重
            //            cmd.CommandText =
            //                "UPDATE t_product2 " +
            //                "SET productname = @productname, telephone = @telephone" +
            //                "password = @password, height = @height, weight = @weight WHERE CD = @CD";

            //            // パラメータセット
            //            cmd.Parameters.Add(new SQLiteParameter("@productname", System.Data.DbType.String));
            //            cmd.Parameters.Add(new SQLiteParameter("@telephone", System.Data.DbType.Int64));
            //            cmd.Parameters.Add(new SQLiteParameter("@password", System.Data.DbType.Int64));
            //            cmd.Parameters.Add(new SQLiteParameter("@height", System.Data.DbType.Int16));
            //            cmd.Parameters.Add(new SQLiteParameter("@weight", System.Data.DbType.Int16));
            //            cmd.Parameters.Add(new SQLiteParameter("@CD", System.Data.DbType.Int64));

            //            // データ追加
            //            cmd.Parameters["@productname"].Value = NameText.Text;
            //            cmd.Parameters["@telephone"].Value = long.Parse(TelephoneText.Text);
            //            cmd.Parameters["@password"].Value = long.Parse(PasswordText.Text);
            //            cmd.Parameters["@height"].Value = short.Parse(HeightText.Text);
            //            cmd.Parameters["@weight"].Value = short.Parse(WeightText.Text);
            //            cmd.Parameters["@CD"].Value = long.Parse(CdText.Text);

            //            cmd.ExecuteNonQuery();

            //            // コミット
            //            trans.Commit();
            //        }
            //        //ログイン又は新規登録選択画面
            //        Screenmain2 SM = new Screenmain2();
            //        SM.Show();
            //        this.Hide();
            //    }
            //}

            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db;Version=3;"))
            {
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        // UPDATE クエリ
                        cmd.CommandText =
                            "UPDATE t_product2 SET productname = @productname, telephone = @telephone, password = @password, height = @height, weight = @weight WHERE CD = @CD";

                        // パラメータセット
                        cmd.Parameters.Add(new SQLiteParameter("@productname", System.Data.DbType.String));
                        cmd.Parameters.Add(new SQLiteParameter("@telephone", System.Data.DbType.Int64));
                        cmd.Parameters.Add(new SQLiteParameter("@password", System.Data.DbType.Int64));
                        cmd.Parameters.Add(new SQLiteParameter("@height", System.Data.DbType.Int16));
                        cmd.Parameters.Add(new SQLiteParameter("@weight", System.Data.DbType.Int16));
                        cmd.Parameters.Add(new SQLiteParameter("@CD", System.Data.DbType.Int64));

                        // パラメータに値を設定
                        cmd.Parameters["@productname"].Value = NameText.Text;
                        cmd.Parameters["@telephone"].Value = long.Parse(TelephoneText.Text);
                        cmd.Parameters["@password"].Value = long.Parse(PasswordText.Text);
                        cmd.Parameters["@height"].Value = short.Parse(HeightText.Text);
                        cmd.Parameters["@weight"].Value = short.Parse(WeightText.Text);
                        cmd.Parameters["@CD"].Value = long.Parse(CdText.Text);

                        // クエリの実行
                        cmd.ExecuteNonQuery();

                        // コミット
                        trans.Commit();
                    }
                }

                // ログイン又は新規登録選択画面
                ScreenMain SM = new ScreenMain();
                SM.Show();
                this.Hide();

            }
        }
        private void BackClick(object sender, EventArgs e)
        {
            //ログイン又は新規登録選択画面
            ScreenMain SM = new ScreenMain();
            SM.Show();
            this.Hide();
        }  
    }
}
