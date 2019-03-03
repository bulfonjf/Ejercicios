using System;
using System.Linq;

namespace Ejercicios.Ejercicio1.Services
{
    public static class FindSecondLargestNumberService
    {
        private const int ValidQuantity = 2;
        private const int SkipQuantity = 1;

        public static int? Find(int[] array)
        {
            int? result = null;
            if(ValidateArrayService.IsValid(array) 
                && TheArrayHasValidQuantity(array))
            {
                result = array.OrderByDescending(x => x)
                            .Skip(SkipQuantity)
                            .First();
                
            }
            return result;
        }

        private static bool TheArrayHasValidQuantity(int[] array)
        {
            return array.Length >= ValidQuantity;
        }
    }
}