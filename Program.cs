using System;
using System.Collections.Generic;

namespace Hen
{
    class Action
    {
        public string Description { get; set; }
        public int Priority { get; set; }

        public Action(string description, int priority)
        {
            Description = description;
            Priority = priority;
        }
    }

    class Program
    {
        static Stack<Action> ActionStack = new Stack<Action>();

        static void Search()
        {
            bool found = false;

            foreach (Action action in ActionStack)
            {
                if (action.Priority == 1)
                {
                    Console.WriteLine(action.Description);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("nothing was found");
            }
        }

        static public void Main(string[] args)
        {
            Action action1 = new Action("eat", 1);
            Action action2 = new Action("drink", 2);
            Action action3 = new Action("sleep", 1);

            ActionStack.Push(action1);
            ActionStack.Push(action2);
            ActionStack.Push(action3);

            Search(); // Call Search method
        }
    }
}