namespace Simple_DictionaryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tests
            OtusDictionary otusDictionary = new OtusDictionary();
            try
            {
                otusDictionary.GetFirstStringByKey(0);
            }
            catch (ValueNotFoundExeption e)
            {
                Console.WriteLine("Catch notFoundValue exeption " + e.Message);
            }
            try
            {
                otusDictionary.Add(23, null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null argument " + e.Message);
            }
            try
            {
                OtusDictionary otusDictionary2 = new OtusDictionary(-10);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("DictionarySize exeption" + e.Message);
            }
            OtusDictionary otusDictionary3 = new OtusDictionary(3);
            otusDictionary3.Add(11, "11");
            otusDictionary3.Add(22, "22");
            otusDictionary3.Add(33, "33");
            Console.WriteLine(otusDictionary3.GetFirstStringByKey(22));

            //Test incresing _size
            otusDictionary3.Add(44, "44");
            otusDictionary3.Add(55, "55");
            otusDictionary3.Add(66, "66");
            otusDictionary3.Add(77, "77");

            //Test zero _size Dictionary creation
            OtusDictionary otusDictionary4 = new OtusDictionary(0);
            otusDictionary4.Add(11, "11");
            Dictionary<int,int> keyValuePairs;    
            keyValuePairs.Add(0, 1);

            #endregion Tests


            Console.WriteLine("Hello, World!");
        }
    }
}
