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

        public void turnOn()
        {
            target.turnOn();
        }

        public void volumeDown()
        {
            target.volumeDown();
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
            
            re.turnOff();
            re.turnOn();
            re.volumeDown();
            re.volumeUp();
            Console.ReadLine();
        }
    }
}
