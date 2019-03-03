using System;

namespace Ejericios.Ejercicio2.Services
{
    public static class CalculateTheFactorialOfANumberService
    {
        private const uint MinimumFactorial = 1;
        public static uint Calculate(uint value)
        {
            uint result = MinimumFactorial;
            for(uint i = 1; i < value; i++)
            {
                uint nextValue = i + 1;
                result *=  nextValue;
            }
            return result;
        }
    }
}