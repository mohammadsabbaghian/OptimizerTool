using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class PrecisionBenchmark
{
    private const int ArraySize = 100000;
    private float[] floatArray;
    private double[] doubleArray;
    private float prevVFloat = 30.0f;
    private double prevVDouble = 30.0;
    private float forceFloat = 500.0f;
    private double forceDouble = 500.0;
    private float massFloat = 10000.0f;
    private double massDouble = 10000.0;
    private int discInt = 10;

    public PrecisionBenchmark()
    {
        floatArray = new float[ArraySize];
        doubleArray = new double[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            floatArray[i] = i * 0.1f;
            doubleArray[i] = i * 0.1;
        }
    }

    [Benchmark]
    public float CalculateSpeedFloat()
    {
        var resistanceFloat = CalculateResistanceFloat();
        return prevVFloat + (float)Math.Sqrt(2 * (forceFloat - resistanceFloat) / massFloat * discInt);
    }

    [Benchmark]
    public double CalculateSpeedDouble()
    {
        var resistanceDouble = CalculateResistanceDouble();
        return prevVDouble + Math.Sqrt(2 * (forceDouble - resistanceDouble) / massDouble * discInt);
    }


    public float CalculateResistanceFloat()
    {
        int index = 5000; // Example index
        return floatArray[index] + 0.1f + 0.2f * prevVFloat + 0.3f * prevVFloat * prevVFloat;
    }

    public double CalculateResistanceDouble()
    {
        int index = 5000; // Example index
        return doubleArray[index] + 0.1 + 0.2 * prevVDouble + 0.3 * prevVDouble * prevVDouble;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<PrecisionBenchmark>();
    }
}