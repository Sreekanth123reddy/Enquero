using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upDownCastingsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //upcasting
            Text text = new Text();  //both references to same object
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); //100
            //RealWorld Of Upcasting 

            //StreamReader reader = new StreamReader(new MemoryStream());

            var al = new ArrayList();
            al.Add(1);
            al.Add("sree");
            al.Add(new Text());

            var al1 = new List<Shape>(); */

            //DownCasting

            Shape shape = new Text();
            shape.Height = 200; // acces only shape properties
            Text text = (Text)shape; // acces both shape and text properties
            

        }
    }
}
