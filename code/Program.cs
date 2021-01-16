/**
 * MIT Licence
 * 2021 code-raisan.
 * @link https://github.com/code-raisan
 */

using System;
using System.Text;
using System.Diagnostics;
using static System.Web.HttpUtility;

namespace ggr
{
    class Program
    {
        private static string words;
        private static string rp;
        private static bool c = false;

        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.Write("検索キーワードが入力されていません");
            }
            else
            {
                if(args[0] == "@add--path")
                {
                    string CurrentDC = Environment.CurrentDirectory;
                    Console.WriteLine("[ " + CurrentDC + " ]へPATHを通します。よろしいですか?(この操作には管理者権限が必要になります)");
                    while(c == false){
                        Console.Write("(Y/n)?");
                        rp = Console.ReadLine();
                        if (rp == "y" || rp == "Y")
                        {
                            string command = $"setx /M path \"%path%;{CurrentDC}\"";
                            Console.WriteLine($"[実行ログ]\n>{command}\nコマンドの実行中...");
                            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", $"/k {command} & echo - & echo - & echo もうこのウィンドウを閉じても構いません");
                            processStartInfo.Verb = "RunAs";
                            Process process = Process.Start(processStartInfo);
                            process.Close();
                            Console.WriteLine("プロセスが終了しました。ログは別ウィンドウをご確認ください");
                            c = true;
                        }
                        else if(rp == "n" || rp == "N")
                        {
                            c = true;
                            Console.WriteLine("キャンセルされました。");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < args.Length; ++i)
                    {
                        if(args.Length - 1 == i)
                        {
                            words += args[i];
                        }
                        else
                        {
                            words += args[i] + " ";
                        }
                    }
                    
                    Console.WriteLine(words + "の検索結果をブラウザで表示します\nブラウザを起動しています...");
                    string query = UrlEncode(words, Encoding.UTF8);
                    Process.Start("https://www.google.co.jp/search?q=" + query);
                }
            }
        }
    }
}
