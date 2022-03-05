public class Solution_22
{
    public IList<string> GenerateParenthesis(int n)
    {

        IList<string> result = new List<string>();
        string str = "";
        combo(str, n, n);
        void combo(string s, int L, int R)
        {
            if (L == 0 && R == 0)
            {
                result.Add(s);
            }

            if (R < L) return;
            if (L > 0) combo(s + "(", L - 1, R);
            if (R > 0) combo(s + ")", L, R - 1);
        }
        return result;
    }
}