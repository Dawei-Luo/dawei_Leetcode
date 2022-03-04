string s = "abcabcbb";
var words = new Dictionary<string, bool> { };
int len = 0;
int left = 0;

for (int i = 0; i < s.Length; i++)
{
    string str = s[i].ToString();
    if (!words.ContainsKey(str))
    {
        words.Add(str, true);
    }
    else
    {
        len = Math.Max(words.Count, len);
        words.Clear();
        i = left++;
    }

}
len = Math.Max(words.Count, len);

Console.WriteLine(len);
