using System.Collections;
using System.Collections.Generic;

namespace Day_18_Queues_And_Stacks
{
    public class Solution
    {
        ArrayList queue;
        Stack stack;

        public Solution()
        {
            queue = new ArrayList();
            stack = new Stack();
        }

        public void pushCharacter(char c)
        {
            stack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            queue.Add(c);
        }

        public char popCharacter()
        {
            return (char)stack.Pop();
        }

        public char dequeueCharacter()
        {
            return char.Parse(queue.RemoveAt(0));
        }
    }
}
