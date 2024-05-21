//namespace PrototypePattern
//{
//    public abstract class Prototype
//    {
//        public abstract Prototype Clone();
//    }

//    public class ConcretePrototype1 : Prototype
//    {
//        public string Id { get; set; }

//        public ConcretePrototype1(string id)
//        {
//            Id = id;
//        }

//        public override Prototype Clone()
//        {
//            return (Prototype)MemberwiseClone();
//        }

//        public override string ToString()
//        {
//            return $"ConcretePrototype1: Id = {Id}";
//        }
//    }

//    public class Client
//    {
//        private Prototype _prototype;

//        public Client(Prototype prototype)
//        {
//            _prototype = prototype;
//        }

//        public void Operation()
//        {
//            Prototype clone = _prototype.Clone();
//            Console.WriteLine(clone.ToString());
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConcretePrototype1 prototype = new ConcretePrototype1("1234");
//            Client client = new Client(prototype);
//            client.Operation();
//        }
//    }
//}
