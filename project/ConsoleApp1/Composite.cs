//using System;
//using System.Collections.Generic;

//namespace CompositePattern
//{
//    abstract class Component
//    {
//        public abstract void Operation();
//    }

//    class Leaf : Component
//    {
//        public override void Operation()
//        {
//            Console.WriteLine("Leaf operation");
//        }
//    }

//    class Composite : Component
//    {
//        private List<Component> _children = new List<Component>();

//        public override void Operation()
//        {
//            Console.WriteLine("Composite operation");
//            foreach (var child in _children)
//            {
//                child.Operation();
//            }
//        }

//        public void Add(Component component)
//        {
//            _children.Add(component);
//        }

//        public void Remove(Component component)
//        {
//            _children.Remove(component);
//        }

//        public Component GetChild(int index)
//        {
//            return _children[index];
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Composite root = new Composite();
//            root.Add(new Leaf());

//            Composite subtree = new Composite();
//            subtree.Add(new Leaf());
//            root.Add(subtree);

//            root.Operation();
//        }
//    }
//}
