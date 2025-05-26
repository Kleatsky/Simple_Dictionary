namespace Simple_DictionaryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tests();
            Console.WriteLine("Program complited success.");
        }

        #region Tests
        private static void Tests()
        {

            OtusDictionary otusDictionary = new OtusDictionary();
            try
            {
                otusDictionary.Get(2);
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
            Console.WriteLine(otusDictionary3.Get(22));

            //Test incresing _size
            otusDictionary3.Add(44, "44");
            otusDictionary3.Add(55, "55");
            otusDictionary3.Add(66, "66");
            otusDictionary3.Add(77, "77");

            //Test one _size Dictionary creation
            OtusDictionary otusDictionary4 = new OtusDictionary(1);
            otusDictionary4.Add(11, "11");


            //Test indexeter
            Console.WriteLine(otusDictionary3[5]);
            try
            {
                (int, string) tempVariable = otusDictionary3[-1];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Index below 0 exeption " + e.Message);
            }
            try
            {
                (int, string) tempVariable = otusDictionary3[50];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Index bigger then dictionary size exeption " + e.Message);
            }
        }
        #endregion Tests
    }
}
