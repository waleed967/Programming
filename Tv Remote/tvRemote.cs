using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteTv3
{
    interface Remotable
    {
        void turnOff();
        void turnOn();
        void volumeDown();
        void volumeUp();
        
        

    }

    class Television : Remotable
    {
        public void turnOff()
        {
            Console.WriteLine("TELEVISION OFF");
        }

        public void turnOn()
        {
            Console.WriteLine("TELEVISION ON");
        }

        public void volumeDown()
        {
            Console.WriteLine("TV Volume Down");
        }

        public void volumeUp()
        {
            Console.WriteLine("TV Volume Up");
        }
    }

    class Remote
    {
        private Remotable target;

        public Remote(Remotable target)
        {
            this.target = target;
        }
        public void turnOff()
        {
            target.turnOff();
        }
    }

    class Remote1
    {
        private Remotable target;

        public Remote1(Remotable target)
        {
            this.target = target;
        }
        public void turnOn()
        {
            target.turnOn();
        }
    }

    class Remote2
    {
        private Remotable target;

        public Remote2(Remotable target)
        {
            this.target = target;
        }
        public void volumeDown()
        {
            target.volumeDown();
        }
    }

    class Remote3
    {
        private Remotable target;

        public Remote3(Remotable target)
        {
            this.target = target;
        }
        public void volumeUp()
        {
            target.volumeUp();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Television te = new Television();
            Remote re = new Remote(te);
            Remote1 rem = new Remote1(te);
            Remote2 remo = new Remote2(te);
            Remote3 remot = new Remote3(te);
            re.turnOff();
            rem.turnOn();
            remo.volumeDown();
            remot.volumeUp();
            Console.ReadLine();
        }
    }
}
