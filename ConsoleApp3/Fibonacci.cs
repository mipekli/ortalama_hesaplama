namespace ConsoleApp3
{
    public class Fibonacci
    {
        public int[] CalculateFibonacci(int depth)
        {
            int[]arr = new int[depth];
            int n1 = 0, n2 = 1, n3 = 0;
            arr[0] = n1;
            arr[1] = n2;
            for (int i = 0; i < depth; i++)
            {
                n3 = n1 + n2;
                arr[i] = n3;
                n1 = n2;
                n2 = n3;
            }
            return arr;
        }
    }
}