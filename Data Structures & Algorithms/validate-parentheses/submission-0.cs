public class Stack
{
    private char[] Items;
    private int Top;
    private int Capacity;

    public Stack(int _Capacity)
    {
        Capacity = _Capacity;
        Top = -1;
        Items = new char[Capacity];
    }

    public void Push(char Item)
    {
        if (Top == Capacity - 1) // the stack is full 
        {
            return;
        }

        Top++;
        Items[Top] = Item;
    }

    public char Pop()
    {
        char Ret;

        if (Top == -1) // the stack is empty 
        {
            return ' ';
        }

        Ret = Items[Top];
        Top--;
        return Ret;
    }

    public char Peak()
    {
        char Ret;

        if (Top == -1) // the stack is empty 
        {
            return ' ';
        }

        Ret = Items[Top];

        return Ret;
    }
    public bool IsEmpty()
    {
        return (Top == -1 ? true : false);
    }
}

public class Solution
{
    public bool IsValid(string s)
    {
        bool Valid = false;
        char[] arr = s.ToCharArray();

        if (arr.Length <= 1 || arr[0] == ')' || arr[0] == ']' || arr[0] == '}')
        {
            Valid = false;
            return Valid;
        }
        else
        {
            Stack stack = new Stack(arr.Length);

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == '(' || arr[i] == '[' || arr[i] == '{')
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }

                    if ((arr[i] == ')' && stack.Peak() == '(') ||
                        (arr[i] == ']' && stack.Peak() == '[') || 
                        (arr[i] == '}' && stack.Peak() == '{'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false ;
                    }
                }

                Valid = stack.IsEmpty();
            }
            return Valid;
        }

    }
}