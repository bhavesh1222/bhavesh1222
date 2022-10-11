namespace checkusername
{
    class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("helloworld");
            string name = Console.ReadLine();
            int count = name.Length;
            Console.WriteLine("the length is " + count);
            if (name.Length >= 3)
            {
                Console.WriteLine("helloworldfile" + name + "how are you?");
            }
        }

    }



}

