using System;

namespace tc3
{
    class Program
    {
        static void Main (string[] args){
            System.Console.WriteLine("numero");
            int numero =Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numero];
            
            Secuencia(arr, numero);
            PrintArray(arr);
        }

        static void PrintArray(int[] nums){
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.WriteLine(nums[i]);
            }
        }

        static void Secuencia (int[] nums, int numero ){
            for(int i = 0; i < numero; i++){
                nums[i] = i+1;
            }
        }
    }
}
