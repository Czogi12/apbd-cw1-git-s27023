public class StatisticsHelper {
    public double CalculateAverage(int[] values) {
        double sum = 0;
        foreach(int value in values) {
            sum += value;
        }
        return sum / values.Length;
    }

    public int CalculateMax(int[] values) {
        int max = int.MinValue;

        foreach (int value in values) {
            if (max < value) max = value;
        }

        return max;
    }
}