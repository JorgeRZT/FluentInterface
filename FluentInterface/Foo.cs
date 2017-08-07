using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterface
{
    public class Foo
    {
        public Foo Select()
        {
            return this;
        }

        public Foo Where()
        {
            return this;
        }
        public Foo OrderBy()
        {
            return this;
        }

    }
}
