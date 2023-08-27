namespace ConsoleApp3
{
    public class Average
    {
        public double CalculateAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
    }
}