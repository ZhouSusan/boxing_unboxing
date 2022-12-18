namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> GenericList = new List<Object>();
            GenericList.Add(7);
            GenericList.Add(28);
            GenericList.Add(-1);
            GenericList.Add(false);
            GenericList.Add(true);
            GenericList.Add('z');
            GenericList.Add("table");

            int Sum = 0;
            for (int i = 0; i < GenericList.Count; i++)
            {
                System.Console.WriteLine(GenericList[i]);
                if (GenericList[i] is int)
                {
                    Sum += (int) GenericList[i];
                }
            }
            Console.WriteLine("Sum is {0}" ,Sum);
        }
    }
}