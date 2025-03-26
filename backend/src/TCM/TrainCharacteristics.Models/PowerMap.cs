namespace TrainCharacteristicsManager.Models
{
    public class PowerMap
    {
        public int[,] Powers;
        public float[] Speeds;
        public float[] TractionPercentages;
        public int Voltage;
        public float Frequency;


        public PowerMap(int[,] powers, float[] speeds, float[] tractionPercentages)
        {
            Powers = powers;
            Speeds = speeds;
            TractionPercentages = tractionPercentages;
        }

        public void Normalize()
        {
            int newRowCount = (int)Math.Ceiling(TractionPercentages[^1]) + 1;
            int newColCount = (int)Math.Ceiling(Speeds[^1]) + 1;
            Powers = new int[newRowCount, newColCount];

            for (int i = 0; i < newRowCount; i++)
            {
                for (int j = 0; j < newColCount; j++)
                {
                    double traction = i;
                    double speed = j;
                    Powers[i, j] = GetPowerValue(speed, traction);
                }
            }
        }

        private int GetPowerValue(double speed, double traction)
        {
            int row = Array.FindLastIndex(TractionPercentages, t => t <= traction);
            int col = Array.FindLastIndex(Speeds, s => s <= speed);

            if (row == -1 || col == -1)
            {
                throw new ArgumentException("Speed or traction out of bounds.");
            }

            // Check if both values match exactly
            if (traction == TractionPercentages[row] && speed == Speeds[col])
            {
                return Powers[row, col];
            }

            // Check if only traction matches exactly
            if (traction == TractionPercentages[row])
            {
                return Interpolate1D(Speeds, row, speed, col, true);
            }

            // Check if only speed matches exactly
            if (speed == Speeds[col])
            {
                return Interpolate1D(TractionPercentages, col, traction, row, false);
            }

            // Perform 2D interpolation if neither value matches exactly
            return Interpolate2D(speed, traction, row, col);
        }

        private int Interpolate1D(float[] values, int fixedIndex, double variableValue, int variableIndex, bool isRowFixed)
        {
            if (variableIndex == values.Length - 1)
            {
                return isRowFixed ? Powers[fixedIndex, variableIndex] : Powers[variableIndex, fixedIndex];
            }

            double v1 = values[variableIndex];
            double v2 = values[variableIndex + 1];

            double q1 = isRowFixed ? Powers[fixedIndex, variableIndex] : Powers[variableIndex, fixedIndex];
            double q2 = isRowFixed ? Powers[fixedIndex, variableIndex + 1] : Powers[variableIndex + 1, fixedIndex];

            return (int)((v2 - variableValue) / (v2 - v1) * q1 + (variableValue - v1) / (v2 - v1) * q2);
        }

        private int Interpolate2D(double speed, double traction, int row, int col)
        {
            if (row == TractionPercentages.Length - 1 || col == Speeds.Length - 1)
            {
                return Powers[row, col];
            }

            double t1 = TractionPercentages[row];
            double t2 = TractionPercentages[row + 1];
            double s1 = Speeds[col];
            double s2 = Speeds[col + 1];

            double q11 = Powers[row, col];
            double q12 = Powers[row, col + 1];
            double q21 = Powers[row + 1, col];
            double q22 = Powers[row + 1, col + 1];

            double r1 = (s2 - speed) / (s2 - s1) * q11 + (speed - s1) / (s2 - s1) * q12;
            double r2 = (s2 - speed) / (s2 - s1) * q21 + (speed - s1) / (s2 - s1) * q22;

            return (int)((t2 - traction) / (t2 - t1) * r1 + (traction - t1) / (t2 - t1) * r2);
        }

        public void Combine(PowerMap powerMap)
        {
            if (Powers.GetLength(0) != powerMap.Powers.GetLength(0) || Powers.GetLength(1) != powerMap.Powers.GetLength(1))
            {

            }

            for (int i = 0; i < Powers.GetLength(0); i++)
            {
                for (int j = 0; j < Powers.GetLength(1); j++)
                {
                    Powers[i, j] += powerMap.Powers[i, j];
                }
            }
        }
    }
}