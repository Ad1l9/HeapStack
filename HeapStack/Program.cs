namespace HeapStack { 
    internal class Program { 
        
        static void Main(string[] args) {

            //int[] numbers = { 1, 2, 3, 4 }; 
            //ReSize(ref numbers, 1, 2, 3); 
            int balance = 1000;


            StartBank(ref balance);
        } 

        //Task1
        //public static void ReSize(ref int[] numbers, params int[] newnums) { 
            
        //    int[] copy = new int[numbers.Length + newnums.Length]; 
            
        //    for (int i = 0; i < copy.Length; i++) { 
        //        if (i < numbers.Length) copy[i] = numbers[i]; 
        //        else copy[i] = newnums[i - numbers.Length]; 
        //    } 
        //    numbers = copy; 
        //    for (int i = 0; i < copy.Length; i++) { 
        //        Console.WriteLine(copy[i]); 
        //    } 
        //}

        public static int StartBank(ref int balans)
        {

            Console.WriteLine(@"
============
ATM
============

Emeliyyati secin:
[1] Balansi goster
[2] Pul cixar
[3] Pul medaxil et
[0] Cix
");


            Console.Write(">>>");

            int choice;
            string input = Console.ReadLine();
            bool chooseVariant = int.TryParse(input, out choice);
            if(choice.ToString()!=input)
            {
                Console.Clear();
                StartBank(ref balans);
            }
            switch (choice)
            {
                case 0:
                    return 0;

                case 1:

                    Console.Clear();
                    Console.WriteLine($"Balance: {balans} AZN");
                    StartBank(ref balans);
                    break;

                case 2:
                    Console.Write("Cixaracaginiz mebleg:");
                    int cash = Convert.ToInt32(Console.ReadLine());
                    balans -= cash;
                    Console.Clear();
                    StartBank(ref balans);
                    break;

                case 3:
                    Console.Write("Medaxil edeceyiniz mebleg:");
                    int inp = Convert.ToInt32(Console.ReadLine());
                    balans += inp;
                    Console.Clear();
                    StartBank(ref balans);
                    break;

                default:
                    StartBank(ref balans);
                    break;
            }

            return 0;
        }
    }
}