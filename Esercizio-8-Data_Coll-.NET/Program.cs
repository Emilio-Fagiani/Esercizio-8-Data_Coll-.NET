using Esercizio_8_Data_Coll_.NET;

class Program
{
   static void Main()
    {
        OperationWithNumbers operationWithNumbers = new OperationWithNumbers();
        List<int> randomNumb = operationWithNumbers.GenerateRandomNumbers(1000);
        
        int min = operationWithNumbers.MinNumber(randomNumb);
        int max = operationWithNumbers.MaxNumber(randomNumb);
        Console.WriteLine();
        Console.WriteLine("Minum number : " + min);
        Console.WriteLine();
        Console.WriteLine("Maximum number : " + max);
    
    }



}