public class StatisticsHelper {
    public double CalculateAverage(int[] values) {
        double sum = 0;
        foreach(int value in values) {
            sum += value;
        }
        return sum / values.Length;
    }
}