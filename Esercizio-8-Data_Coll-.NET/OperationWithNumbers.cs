using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_8_Data_Coll_.NET
{
    internal class OperationWithNumbers
    {
        public List<int> GenerateRandomNumbers(int count)
        {
            Random random = new Random();   
            List<int> numbers = new List<int>();
            for(int i = 0;i < count; i++ ){

                int randomNumber = random.Next();
                numbers.Add(randomNumber);
                Console.WriteLine(numbers[i]);
            }
            
            return numbers;
        }

        public int MaxNumber(List<int> numbers)
        {
            int max = int.MinValue;
            for(int i =0;i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public int MinNumber(List<int> numbers) 
        {
            int min = int.MaxValue;
            for(int i = 0;i < numbers.Count;i++)
            { 
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
               
            }
            return min;
        }
    }
}
