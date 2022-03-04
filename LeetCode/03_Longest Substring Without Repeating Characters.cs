public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var words = new Dictionary<string, int> { };
        int len = 0;
        int start = 0;
        if (s.Length < 2) return s.Length;
        for (int i = 0; i < s.Length; i++)
        {
            string str = s[i].ToString();
            if (words.ContainsKey(str) && words[str] >= start)
            {
                start = words[str] + 1;
                words[str] = i;
            }
            else
            {
                words.Add(str, i);
            }
            len = Math.Max(i - start + 1, len);

        };

        return len;

    }
}