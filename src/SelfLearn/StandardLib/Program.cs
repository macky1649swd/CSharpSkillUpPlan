using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var str = "👨‍👩‍👧‍👦";

Console.WriteLine($"👨‍👩‍👧‍👦 str.Length = {str.Length}");

var strInfo = new StringInfo(str);

Console.WriteLine($"👨‍👩‍👧‍👦 StringInfo.LengthInTextElements = {strInfo.LengthInTextElements}");


var str1 = "wing";
var str2 = "WING";

Console.WriteLine($"String Comparison1 {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine($"String Comparison2 {string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)}");

string? nullableStr = null;
Console.WriteLine($"IsNullOrEmpty = {string.IsNullOrEmpty(nullableStr)}");

var name = "macky1649";
Console.WriteLine($"{name} contains digit : {name.Any(ch => Char.IsDigit(ch))}");





