using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///ユーザーの情報保持
///
/// 作成日　2023/12/7
/// 作成者　織田晃豪
/// </summary>
namespace odaexclusive4
{
    //ログイン状態を保持する
    static class LoginUser_Info
    {
        private static int cd;

        public static int CD
        {
            get { return cd; }
            set { cd = value; }
        }
    }
}
