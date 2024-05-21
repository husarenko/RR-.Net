//namespace ServantPattern
//{
//    class Servant
//    {
//        public void Operation1(Host host)
//        {
//            Console.WriteLine($"Servant is performing operation 1 on host with data: {host.Data}");
//        }

//        public void Operation2(Host host)
//        {
//            Console.WriteLine($"Servant is performing operation 2 on host with data: {host.Data}");
//        }
//    }

//    class Host
//    {
//        public int Data { get; private set; }

//        public Host(int data)
//        {
//            Data = data;
//        }

//        public void Request1(Servant servant)
//        {
//            servant.Operation1(this);
//        }

//        public void Request2(Servant servant)
//        {
//            servant.Operation2(this);
//        }
//    }

//    class Client
//    {
//        public void DoWork(Host host, Servant servant)
//        {
//            host.Request1(servant);
//            host.Request2(servant);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Host host = new Host(42);
//            Servant servant = new Servant();
//            Client client = new Client();

//            client.DoWork(host, servant);
//        }
//    }
//}
