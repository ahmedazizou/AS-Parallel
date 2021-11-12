using System.Threading;

namespace ParallelProgramming.Task1
{
    public class BubbleSort
    {
    // To divide the array into sections, we initialize a low and high parameter
    private readonly int _nLow;
    private readonly int _nHigh;
    private readonly Thread _thread;

    // When the class is created, this constructor takes three arguments: low, high, and array
    public BubbleSort(int nLowParam, int nHighParam, int[] arr)
    {
        _nLow = nLowParam;
        _nHigh = nHighParam;
        _thread = new Thread(()=>Main(arr));
    }

    public void Start()
    {
        _thread.Start();
    }

    public bool IsAlive => _thread.IsAlive;

    // The bubble sort algorithm is implemented in this function
    public void Main(int[] array)
    {
        int arrayLen = array.Length;
        for (int v = _nLow; v < _nHigh - 1; v++)

        for (int c = 0; c < arrayLen - v - 1; c++)
            if (array[c] > array[c + 1])
            {
                int t = array[c];
                array[c] = array[c + 1];
                array[c + 1] = t;
            }
        }
    }
}
