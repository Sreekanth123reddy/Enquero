namespace inheritanceCSharpBasic
{
    public class Traingle:PresentationText
    {
        public int FontSize { set; get; }
        public int FontName { set; get; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("Hyperlonk added"+url);
        }
    }
}
