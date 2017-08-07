using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            foo.Select().Where().OrderBy().Select();
        }
    }
}