using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data.SQLite;
/// <summary>
///メイン画面
///
/// 作成日　2023/12/8
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    public partial class ScreenMymeny : Form
    {
        private List<string> sentences;
        private Random random;
        public ScreenMymeny()
        {
            InitializeComponent();

            // 手動で追加する初期化コード
            sentences = new List<string>
            {
                "腕立て伏せ20回", "腹筋20回", "背筋20回", "体幹5分", "バービージャンプ20回", "ランニング1時間"
            };

            // その他の初期化コードや処理

            // ランダムオブジェクトの初期化
            random = new Random();

            // ラベルにランダムな文章を表示
            DisplayRandomSentences();

            //ラベルにログインしたユーザー情報を表示する
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "SELECT productname, height, weight FROM t_product2 WHERE CD = @CD";
                    // パラメータセット
                    cmd.Parameters.AddWithValue("@CD", LoginUser_Info.CD);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // データが存在する場合、各フィールドの値を取得してUI要素にセットする
                            NameText.Text = reader["productname"].ToString();
                            WeightText.Text = reader["weight"].ToString();
                            HeightText.Text = reader["height"].ToString();


                        }
                    }

                    // コミット
                    trans.Commit();
                }
            }
        }


        private void ChangeButtonClick(object sender, EventArgs e)
        {
            ScreenChange SC = new ScreenChange();
            SC.Visible = true;
            this.Hide();
        }
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "DELETE FROM t_product2 WHERE CD = @CD;";
                    //パラメータセット
                    cmd.Parameters.Add("CD", System.Data.DbType.Int64);
                    //データ削除
                    cmd.Parameters["CD"].Value = int.Parse(DeleteText.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
                MessageBox.Show("削除が完了しました。");
            }
            //ログイン又は新規登録選択画面
            ScreenMain SP = new ScreenMain();
            SP.Visible = true;
            this.Hide();
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            //ログイン又は新規登録選択画面
            ScreenMain SP = new ScreenMain();
            SP.Visible = true;
            this.Hide();
        }
        private void ScreenMymeny2Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=user.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT weight, height FROM t_product2 WHERE CD = @CD";
                    cmd.Parameters.AddWithValue("@CD", LoginUser_Info.CD);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ログイン状態のユーザー情報から体重と身長を取得
                            double weight = Convert.ToDouble(reader["weight"]);
                            double height = Convert.ToDouble(reader["height"]);
                            height = height / 100;

                            // BMIを計算
                            double bmi = weight / (height * height);

                            // BMIを表示する
                            BmiText.Text = $"{bmi:f2}";
                        }
                        else
                        {
                            // データが存在しない場合の処理
                            BmiText.Text = "データなし";
                        }
                    }

                    // コミット
                    trans.Commit();
                }
            }
        }

        private void TrainingLabelClick()
        {
            // ランダムな文章をリストから取得して表示
            if (sentences != null && sentences.Count > 0)
            {
                TrainingText.Text = GetRandomSentence();
                TrainingText2.Text = GetRandomSentence();
                TrainingText3.Text = GetRandomSentence();
            }
            else
            {
                TrainingText.Text = "No data available.";
                TrainingText2.Text = "No data available.";
                TrainingText3.Text = "No data available.";
            }
        }
        private void DisplayRandomSentences()
        {
            // ランダムな文章をリストから取得して表示
            List<string> shuffledSentences = sentences.OrderBy(x => random.Next()).ToList();

            TrainingText.Text = shuffledSentences[0];
            TrainingText2.Text = shuffledSentences[1];
            TrainingText3.Text = shuffledSentences[2];
        }
        private string GetRandomSentence()
        {
            // ランダムな文章を取得
            if (sentences != null && sentences.Count > 0)
            {
                int randomIndex = random.Next(sentences.Count);
                return sentences[randomIndex];
            }

            return "No data available.";
        }

        private void TrainingresetbuttonClick(object sender, EventArgs e)
        {
            // ボタンをクリックしたときに新しいランダムな文字列を生成して表示
            TrainingLabelClick();
        }
        
    }
}
