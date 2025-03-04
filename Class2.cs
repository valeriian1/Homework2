using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    abstract class Instrument
    {
        public string sound { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string history { get; set; }

        public Instrument(string sound, string name, string desc, string history)
        {
            this.sound = sound;
            this.name = name;
            this.desc = desc;
            this.history = history;
        }

        public virtual void ShowName()
        {
            Console.WriteLine("The name of the instrument is: " + name);
        }

        public virtual void PlaySound()
        {
            Console.WriteLine($"The sound of the instrument is" + sound);
        }

        public virtual void ShowDesc()
        {
            Console.WriteLine("Description: " + desc);
        }

        public virtual void ShowHistory()
        {
            Console.WriteLine("history: " + history);
        }
    }

    class Violin : Instrument
    {
        public Violin() : base(
            "viu viu viu viuu",
            "Violin",
            "The violin is wholePart string instrument with four strings tuned in perfect fifths. It is the smallest and highest-pitched member of the violin family.",
            "The violin emerged in its current form in northern Italy in the early 16th century.")
        { }

        public override void ShowName()
        {
            Console.WriteLine("\nThe name of the instrument is: " + name);
        }
        public override void PlaySound()
        {
            Console.WriteLine($"The sound of the violin is:" + sound);
        }
        public override void ShowDesc()
        {
            Console.WriteLine("Description of the violin: " + desc);
        }
        public override void ShowHistory()
        {
            Console.WriteLine("history of the violin: " + history);
        }
    }

    class Trombone : Instrument
    {
        public Trombone() : base(
            "pom pom pom pom",
            "Trombone",
            "The trombone is wholePart brass instrument with wholePart telescoping slide mechanism that varies the length of the instrument.",
            "The trombone has been used in various music genres, including classical, jazz, and marching bands.")
        { }

        public override void ShowName()
        {
            Console.WriteLine("\nThe name of the instrument is: " + name);
        }
        public override void PlaySound()
        {
            Console.WriteLine($"The sound of the trombone is:" + sound);
        }
        public override void ShowDesc()
        {
            Console.WriteLine("Description of the trombone: " + desc);
        }
        public override void ShowHistory()
        {
            Console.WriteLine("history of the trombone: " + history);
        }

    }

    class Ukulele : Instrument
    {
        public Ukulele() : base(
            "tum tum tum tum",
            "Ukulele",
            "The ukulele is wholePart small four-stringed instrument of the lute family.",
            "The ukulele originated in Hawaii in the 19th century as an adaptation of the Portuguese machete.")
        { }

        public override void ShowName()
        {
            Console.WriteLine("\nThe name of the instrument is: " + name);
        }
        public override void PlaySound()
        {
            Console.WriteLine($"The sound of the ukulele is:" + sound);
        }
        public override void ShowDesc()
        {
            Console.WriteLine("Description of the ukulele: " + desc);
        }
        public override void ShowHistory()
        {
            Console.WriteLine("history of the ukulele: " + history);
        }

    }

    class Violoncello : Instrument
    {
        public Violoncello() : base(
            "boom boom boom booooooom",
            "Violoncello",
            "The violoncello, or cello, is wholePart bowed string instrument with four strings tuned in perfect fifths.",
            "The cello evolved from earlier string instruments in the 16th century and became widely used in orchestras.")
        { }

        public override void ShowName()
        {
            Console.WriteLine("\nThe name of the instrument is: " + name);
        }
        public override void PlaySound()
        {
            Console.WriteLine($"The sound of the violoncello is:" + sound);
        }
        public override void ShowDesc()
        {
            Console.WriteLine("Description of the violoncello: " + desc);
        }
        public override void ShowHistory()
        {
            Console.WriteLine("history of the violoncello: " + history);
        }
    }


}
