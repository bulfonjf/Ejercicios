using System.Collections.Generic;

namespace Ejercicios.Ejercicio3.Services
{
    public static class GetItemByKeyService
    {
        public static void NonPerformantPrintObject(Dictionary<string, object> dictionary, string key)
        {            
            if(dictionary.ContainsKey(key))
            {
                System.Console.WriteLine(dictionary[key].ToString());
            }
            else
            {
                System.Console.WriteLine("null");
            }
        }

        public static void PerformantPrintObject(Dictionary<string, object> dictionary, string key)
        {
            System.Console.WriteLine(GetValueOrNull(dictionary, key));
        }

        public static object PerformantPrintObjectTesteable(Dictionary<string, object> dictionary, string key)
        {
            return GetValueOrNull(dictionary, key);
        }

        // I create this method to avoid duplicated code between PerformantPrintObject and PerformantPrintObjectTesteable.
        private static object GetValueOrNull(Dictionary<string, object> dictionary, string key)
        {
            return dictionary.TryGetValue(key, out object item) ? item.ToString() : "null";
            
        }
        
    }
}