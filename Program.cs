using System;

namespace CommandHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Dispatcher dispath = new Dispatcher();
            dispath.Dispatch(book);
        }
    }
}
