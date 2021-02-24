﻿using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Day_18_Queues_And_Stacks
{
    public class Solution
    {
        private LinkedList<char> queue = new LinkedList<char>();
        private LinkedList<char> stack = new LinkedList<char>();

        public Solution() { }

        public void pushCharacter(char c)
        {
            stack.AddFirst(c);
        }

        public void enqueueCharacter(char c)
        {
            queue.AddFirst(c);
        }

        public char popCharacter()
        {
            char c = stack.First.Value;
            stack.RemoveFirst();
            return (c);
        }

        public char dequeueCharacter()
        {
            char c = queue.Last.Value;
            queue.RemoveLast();
            return (c);
        }
    }
}
