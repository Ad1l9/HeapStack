namespace HeapStack { 
    internal class Program { 
        
        static void Main(string[] args) { 

            int[] numbers = { 1, 2, 3, 4 }; 
            ReSize(ref numbers, 1, 2, 3); } 

        //Task1
        public static void ReSize(ref int[] numbers, params int[] newnums) { 
            
            int[] copy = new int[numbers.Length + newnums.Length]; 
            
            for (int i = 0; i < copy.Length; i++) { 
                if (i < numbers.Length) copy[i] = numbers[i]; 
                else copy[i] = newnums[i - numbers.Length]; 
            } 
            numbers = copy; 
            for (int i = 0; i < copy.Length; i++) { 
                Console.WriteLine(copy[i]); 
            } 
        }
    }
}