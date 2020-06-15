using System;

namespace inheritanceCSharpBasic
{
    public class PresentationText
    {
        public  int width { set; get; }
        public int height { set; get; }
        public void Copy()
        {
            Console.WriteLine("object copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}
