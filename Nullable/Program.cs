using System;

namespace Nullable
{
    struct State
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 7;
            Console.WriteLine(x.Value);
            Nullable<State> state = new State() { Name = "bob" };
            Console.WriteLine(state.Value.Name);
            Console.Read();
        }
    }
}
