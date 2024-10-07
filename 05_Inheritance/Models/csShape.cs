using System.Numerics;

namespace Models;

    abstract public class csShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    // Triangle is derived from Shape.  
    public class csTriangle : csShape
    {
        public double Area => Width * Height / 2;

        public override string ToString() => $"i am a {nameof(csTriangle)} with area: {Area}";

    }
    // Rectangle is derived from Shape
    public class csRectangle : csShape
    {
        public double Area => Width * Height;
        public override string ToString() => $"i am a {nameof(csRectangle)} with area: {Area}";
    }

    public class csSquare : csRectangle{
        public new double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        public new double Height { get => base.Height; set{ base.Height = value; base.Width = value;} }

        public override string ToString() => $"i am a {nameof(csSquare)} with area: {Area}, side: {Width}";
    }
