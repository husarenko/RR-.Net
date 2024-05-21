//using System;
//using System.Threading;

//namespace ReadWriteLockPattern
//{
//    class ReadWriteLock
//    {
//        private int readers = 0;
//        private bool writer = false;

//        public void AcquireReadLock()
//        {
//            lock (this)
//            {
//                while (writer)
//                {
//                    Monitor.Wait(this);
//                }
//                readers++;
//            }
//        }

//        public void ReleaseReadLock()
//        {
//            lock (this)
//            {
//                readers--;
//                if (readers == 0)
//                {
//                    Monitor.PulseAll(this);
//                }
//            }
//        }

//        public void AcquireWriteLock()
//        {
//            lock (this)
//            {
//                while (readers > 0 || writer)
//                {
//                    Monitor.Wait(this);
//                }
//                writer = true;
//            }
//        }

//        public void ReleaseWriteLock()
//        {
//            lock (this)
//            {
//                writer = false;
//                Monitor.PulseAll(this);
//            }
//        }
//    }

//    class ReadLock
//    {
//        private ReadWriteLock lock_;

//        public ReadLock(ReadWriteLock lock_)
//        {
//            this.lock_ = lock_;
//        }

//        public void Acquire()
//        {
//            lock_.AcquireReadLock();
//        }

//        public void Release()
//        {
//            lock_.ReleaseReadLock();
//        }
//    }

//    class WriteLock
//    {
//        private ReadWriteLock lock_;

//        public WriteLock(ReadWriteLock lock_)
//        {
//            this.lock_ = lock_;
//        }

//        public void Acquire()
//        {
//            lock_.AcquireWriteLock();
//        }

//        public void Release()
//        {
//            lock_.ReleaseWriteLock();
//        }
//    }

//    class SharedResource
//    {
//        private int data = 0;

//        public void Read()
//        {
//            Console.WriteLine($"Reading data: {data}");
//        }

//        public void Write(int value)
//        {
//            Console.WriteLine($"Writing data: {value}");
//            data = value;
//        }
//    }

//    class Client
//    {
//        private SharedResource resource;
//        private ReadLock readLock;
//        private WriteLock writeLock;

//        public Client(SharedResource resource, ReadLock readLock, WriteLock writeLock)
//        {
//            this.resource = resource;
//            this.readLock = readLock;
//            this.writeLock = writeLock;
//        }

//        public void PerformRead()
//        {
//            readLock.Acquire();
//            try
//            {
//                resource.Read();
//            }
//            finally
//            {
//                readLock.Release();
//            }
//        }

//        public void PerformWrite(int value)
//        {
//            writeLock.Acquire();
//            try
//            {
//                resource.Write(value);
//            }
//            finally
//            {
//                writeLock.Release();
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ReadWriteLock rwLock = new ReadWriteLock();
//            SharedResource resource = new SharedResource();
//            ReadLock readLock = new ReadLock(rwLock);
//            WriteLock writeLock = new WriteLock(rwLock);
//            Client client = new Client(resource, readLock, writeLock);

//            Thread reader1 = new Thread(() => client.PerformRead());
//            Thread reader2 = new Thread(() => client.PerformRead());
//            Thread writer = new Thread(() => client.PerformWrite(42));

//            reader1.Start();
//            reader2.Start();
//            writer.Start();

//            reader1.Join();
//            reader2.Join();
//            writer.Join();
//        }
//    }
//}
