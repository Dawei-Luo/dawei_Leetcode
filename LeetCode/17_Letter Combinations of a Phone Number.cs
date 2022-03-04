public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {

        Dictionary<char, List<char>> words = new Dictionary<char, List<char>>
{
    { '2', new List<char>{ 'a','b','c'} },
    { '3', new List<char>{ 'd','e','f'} },
    { '4', new List<char>{ 'g','h','i'} },
    { '5', new List<char>{ 'j','k','l'} },
    { '6', new List<char>{ 'm','n','o'} },
    { '7', new List<char>{ 'p','q','r','s'} },
    { '8', new List<char>{ 't','u','v'} },
    { '9', new List<char>{ 'w','x','y','z'} }
};
        IList<string> result = new List<string>();
        if (digits == "") return new List<string> { };
        string ans = "";
        combo(digits, 0, digits.Length, ans);


        void combo(string phoneNum, int item, int max, string ans)
        {
            if (item == max)
            {
                result.Add(ans);
                return;
            }
            foreach (char word in words[phoneNum[item]])
            {
                combo(phoneNum, item + 1, max, ans + word);
            }
        }
        return result;
    }
}