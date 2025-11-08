using System.Security.AccessControl;

object a = "NHK Trophy";

switch(a)
{
    case int n when n > 10:
        System.Console.WriteLine("Greater than 10");
        break;

    case string s when s.Length > 5:
        System.Console.WriteLine("Long string");
        break;
}

object obj = "Hello, World!";

Console.WriteLine( obj switch 
{ 
    int n when n>10 => "10より大きな整数",
    int n => "10以下の整数",
    string s when s.Length > 5 => "長い文字列",
    string s => "短い文字列",
    _ => "その他"
});

var rank = "松";

Console.WriteLine( rank switch
{
    "甲" => "最高ランク",
    "乙" => "中ランク",
    "丙" => "低ランク",
    _ => throw new ArgumentException("不明なランクです")
});