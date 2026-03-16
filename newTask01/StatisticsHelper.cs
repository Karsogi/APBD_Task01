namespace newTask01;

public class StatisticsHelper
{
    public static double Average(int a, int b)
    {
        return (a + b) / 2.0;
    }
    public static double CalculateAverage(int[] values)
    {
        if(values.Length == 0) return 0;
        double sum = 0;
        foreach(var v in values) sum += v;
        return sum / values.Length;
    }
    public static int CalculateMax(int[] values)
    {
        if(values.Length == 0) return int.MinValue;
        int max = values[0];
        foreach(var v in values)
            if(v > max) max = v;
        return max;
        //TO Expand The Logic
    }
    public static int CalculateMin(int[] values)
    {
        //TODO
    }
}