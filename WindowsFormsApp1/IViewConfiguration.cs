﻿using System.Drawing;

namespace TagsCloudVisualization
{
    public interface IViewConfiguration
    {
        Color Color { get; set; }
        FontFamily FontFamily { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        StringFormat StringFormat { get; set; }
    }
}