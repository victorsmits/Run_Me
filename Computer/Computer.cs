using System;

namespace computer
{
    public interface Computer
    {
        string Name { get; }

        double Compute(params double[] values);
    }
}
