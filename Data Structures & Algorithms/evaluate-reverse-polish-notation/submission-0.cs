public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        int res = 0;
        Stack<int> stack = new Stack<int>();
        string temp;

        for(int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] != "+"
              && tokens[i] != "-"
              && tokens[i] != "*"
              && tokens[i] != "/")
            {
                res = int.Parse(tokens[i]);
                stack.Push(res);
            }
            else
            {
                if (tokens[i] == "+")
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();


                    res = num1 + num2;  

                    stack.Push(res);
                }
                else if (tokens[i] == "-")
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();

                    res = num1 - num2;

                    stack.Push(res);
                }
                else if (tokens[i] == "*")
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();

                    res = num1 * num2;

                    stack.Push(res);
                }
                else
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();

                    if (num2 == 0) res = num1;
                    else
                    {
                        res = num1 / num2;
                    }

                    stack.Push(res);
                }
            }
        }

       
        return stack.Peek();
    }

    
}