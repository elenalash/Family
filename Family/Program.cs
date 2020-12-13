using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Family
{
    class Family
    {
        private string _Father;
        private string _Mother;
        private List<string> _Children;

        public Family(string father, string mother, List<string> children)
        {
            _Father = father;
            _Mother = mother;
            _Children = children;
        }

        public string Father { set { _Father = value; }  get {return _Father; } }
        public string Mother { set { _Mother = value; } get { return _Mother; } }
        public List<string> Children { set { _Children = value; } get { return _Children; } }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var Smith = new Family("John", "Jane", new List<string>() { "Luke", "Eva" });

            Console.WriteLine(Smith.Father);
            Console.WriteLine(Smith.Mother);
            Console.WriteLine(Smith.Children[0]+", "+ Smith.Children[1]);


            var Jonson = new Family("Richard", "Maria", new List<string>() { "George", "David", "Hellen" });
            int count = Jonson.Children.Count +2;
            string kids = "";
            foreach (string child in Jonson.Children)
            {
                if (Jonson.Children.IndexOf(child) == 0)
                {
                    kids += " ";
                }
                kids += child;
                if (Jonson.Children.IndexOf(child) < count - 3)
                {
                    kids += ", ";
                }                
            }
            string name = nameof(Jonson);
            Console.WriteLine("{0}'s family consists of {1} members. Their names are: {2}, {3},{4}.", name, count, Jonson.Father, Jonson.Mother, kids);
        }
    }
}
