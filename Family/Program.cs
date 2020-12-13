using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Family
{
    class Family
    {
        private string _LastName;
        private string _Father;
        private string _Mother;
        private List<string> _Children;

        public Family()
        {
            _Children = new List<string>();
        }
        public Family(string lastname, string father, string mother, List<string> children)
        {
            _LastName = lastname;
            _Father = father;
            _Mother = mother;
            _Children = children;
        }
        public string LastName { set { _LastName = value; } get { return _LastName; } }
        public string Father { set { _Father = value; }  get {return _Father; } }
        public string Mother { set { _Mother = value; } get { return _Mother; } }
        public List<string> Children { set { _Children = value; } get { return _Children; } }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            string kids;
            var family1 = new Family("Smith","John", "Jane", new List<string>() { "Luke", "Eva" });

            //Console.WriteLine(Smith.Father);
            //Console.WriteLine(Smith.Mother);
            //Console.WriteLine(Smith.Children[0]+", "+ Smith.Children[1]);


            var family2 = new Family("Jonson","Richard", "Maria", new List<string>() { "George", "David", "Hellen" });
            
            count = family2.Children.Count +2;
            kids = " ";
            foreach (string child in family2.Children)
            {               
                kids += child;
                if (family2.Children.IndexOf(child) < count - 3)
                {
                    kids += ", ";
                }                
            }            
            Console.WriteLine("{0}'s family consists of {1} members. Their names are: {2}, {3},{4}.", family2.LastName, count, family2.Father, family2.Mother, kids);
            
            
            var family3 = new Family();
            Console.WriteLine("Input new family name: ");            
            family3.LastName = Console.ReadLine();
            Console.WriteLine("Input {0}'s father's name: ", family3.LastName);
            family3.Father = Console.ReadLine();
            Console.WriteLine("Input {0}'s mother's name: ", family3.LastName);
            family3.Mother = Console.ReadLine();
            bool moreKids = true;
            while (moreKids is true)
            {
                Console.WriteLine("Input {0}'s child's name: ", family3.LastName);
                string childsName = Console.ReadLine();
                if ( childsName == "0")
                {
                    moreKids = false;
                }
                else
                {
                    family3.Children.Add(childsName);
                }                
            }
            //OUTPUT
            count = family3.Children.Count + 2;
            kids = " ";
            foreach (string child in family3.Children)
            {                
                kids += child;
                if (family3.Children.IndexOf(child) < count - 3)
                {
                    kids += ", ";
                }
            }
            Console.WriteLine("{0}'s family consists of {1} members. Their names are: {2}, {3},{4}.", family3.LastName, count, family3.Father, family3.Mother, kids);



        }
    }
}
