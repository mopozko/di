﻿using System.Drawing;

namespace TagsCloudVisualization
{
    public class TagStatistic
    {
        public double Coefficient { get; }
        public string Value { get; }

        public TagStatistic(string value, double coefficient)
        {
            this.Value = value;
            Coefficient = coefficient;
        }
    }
}