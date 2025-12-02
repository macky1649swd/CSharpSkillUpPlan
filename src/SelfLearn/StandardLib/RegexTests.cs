using System.Text.RegularExpressions;

namespace StandardLib
{
    public class RegexTests
    {
        public static void RunTests()
        {
            Console.WriteLine("=== 正規表現ライブラリのテスト ===\n");

            // 数字を抽出
            var pattern1 = @"\d+";
            var text1 = "123abc456def789";
            Console.WriteLine($"パターン: {pattern1}");
            Console.WriteLine($"テキスト: {text1}");
            var matches1 = Regex.Matches(text1, pattern1);
            Console.WriteLine($"マッチ: {string.Join(", ", matches1.Select(m => m.Value))}\n");

            // メールアドレスの検証
            var pattern2 = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var emails = new[] { "test@example.com", "invalid.email", "user@domain.co.jp" };
            Console.WriteLine($"パターン: {pattern2}");
            foreach (var email in emails)
            {
                Console.WriteLine($"{email}: {Regex.IsMatch(email, pattern2)}");
            }
        }
    }
}
