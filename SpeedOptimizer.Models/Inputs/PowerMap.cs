namespace SpeedOptimizer.Models.Inputs
{
    public class PowerMap
    {
        public int[,] Map;

        public PowerMap(int[,] powers, double[] speeds, double[] tractionPercentages)
        {
            int newRowCount = (int)Math.Ceiling(tractionPercentages[^1]) + 1;
            int newColCount = (int)Math.Ceiling(speeds[^1]) + 1;
            Map = new int[newRowCount, newColCount];

            for (int i = 0; i < newRowCount; i++)
            {
                for (int j = 0; j < newColCount; j++)
                {
                    double traction = i;
                    double speed = j;
                    Map[i, j] = GetPowerValue(powers, speeds, tractionPercentages, speed, traction);
                }
            }
        }

        private int GetPowerValue(int[,] powers, double[] speeds, double[] tractionPercentages, double speed, double traction)
        {
            int row = Array.FindLastIndex(tractionPercentages, t => t <= traction);
            int col = Array.FindLastIndex(speeds, s => s <= speed);

            if (row == -1 || col == -1)
            {
                throw new ArgumentException("Speed or traction out of bounds.");
            }

            // Check if both values match exactly
            if (traction == tractionPercentages[row] && speed == speeds[col])
            {
                return powers[row, col];
            }

            // Check if only traction matches exactly
            if (traction == tractionPercentages[row])
            {
                return Interpolate1D(powers, speeds, row, speed, col, true);
            }

            // Check if only speed matches exactly
            if (speed == speeds[col])
            {
                return Interpolate1D(powers, tractionPercentages, col, traction, row, false);
            }

            // Perform 2D interpolation if neither value matches exactly
            return Interpolate2D(powers, speeds, tractionPercentages, speed, traction, row, col);
        }

        private int Interpolate1D(int[,] powers, double[] values, int fixedIndex, double variableValue, int variableIndex, bool isRowFixed)
        {
            if (variableIndex == values.Length - 1)
            {
                return isRowFixed ? powers[fixedIndex, variableIndex] : powers[variableIndex, fixedIndex];
            }

            double v1 = values[variableIndex];
            double v2 = values[variableIndex + 1];

            double q1 = isRowFixed ? powers[fixedIndex, variableIndex] : powers[variableIndex, fixedIndex];
            double q2 = isRowFixed ? powers[fixedIndex, variableIndex + 1] : powers[variableIndex + 1, fixedIndex];

            return (int)(((v2 - variableValue) / (v2 - v1)) * q1 + ((variableValue - v1) / (v2 - v1)) * q2);
        }

        private int Interpolate2D(int[,] powers, double[] speeds, double[] tractionPercentages, double speed, double traction, int row, int col)
        {
            if (row == tractionPercentages.Length - 1 || col == speeds.Length - 1)
            {
                return powers[row, col];
            }

            double t1 = tractionPercentages[row];
            double t2 = tractionPercentages[row + 1];
            double s1 = speeds[col];
            double s2 = speeds[col + 1];

            double q11 = powers[row, col];
            double q12 = powers[row, col + 1];
            double q21 = powers[row + 1, col];
            double q22 = powers[row + 1, col + 1];

            double r1 = ((s2 - speed) / (s2 - s1)) * q11 + ((speed - s1) / (s2 - s1)) * q12;
            double r2 = ((s2 - speed) / (s2 - s1)) * q21 + ((speed - s1) / (s2 - s1)) * q22;

            return (int)(((t2 - traction) / (t2 - t1)) * r1 + ((traction - t1) / (t2 - t1)) * r2);
        }
    }
}