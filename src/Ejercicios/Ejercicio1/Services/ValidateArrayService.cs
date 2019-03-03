namespace Ejercicios.Ejercicio1.Services
{
    public static class ValidateArrayService
    {
        public static bool IsValid(int[] array)
        {
            return array != null && array.Length > 0;
        }
    }
}