public class Solution_05
{
    public string LongestPalindrome(string s)
    {

        string result = "";
        int resultLen = 0;
        for (int i = 0; i < s.Length; i++)
        {
            recursive(i, i);
            recursive(i, i + 1);
        }
        void recursive(int L, int R)
        {
            while (L >= 0 && R <= s.Length - 1)
            {
                if (s[L] != s[R])
                {
                    break;
                }
                if (s.Substring(L, R - L + 1).Length > resultLen)
                {
                    resultLen = s.Substring(L, R - L + 1).Length;
                    result = s.Substring(L, R - L + 1);
                }
                R++;
                L--;
            }
        }
        return result;
    }
}