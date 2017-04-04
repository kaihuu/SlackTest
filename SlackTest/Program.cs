using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlackTest
{
    class Program
    {
        static string WEBHOOK_URL = "https://hooks.slack.com/services/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";

        static void Main(string[] args)
        {
            var wc = new WebClient();

            var data = DynamicJson.Serialize(new
            {
                text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                icon_emoji = ":ghost:", //アイコンを動的に変更する
                username = "投稿テスト用Bot"  //名前を動的に変更する
            });

            wc.Headers.Add(HttpRequestHeader.ContentType, "application/json;charset=UTF-8");
            wc.Encoding = Encoding.UTF8;


            wc.UploadString(WEBHOOK_URL, data);
        }
    }
}
