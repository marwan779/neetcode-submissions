public class Solution
{
    public bool IsValid(string s)
    {

        if(s == null || s.Length == 0 || s.Length == 1) return false;

        Stack<char> chars = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                chars.Push(s[i]);
            }
            else
            {
                if (chars.Count == 0) return false;

                if (s[i] == ')' && chars.Peek() != '('||
                s[i] == ']' && chars.Peek() != '[' ||
                s[i] == '}' && chars.Peek() != '{') 
                    return false;

                chars.Pop();
            }

        }

        return chars.Count == 0;
    }

}