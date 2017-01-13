namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Stay
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Viteza { get; set; }
        public static int Scor { get; set; }
        public static int Puncte { get; set; }
        public static int Viteza1 { get; set; }
        public static int Viteza2 { get; set; }
        public static bool JocTerminat { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Viteza = 14;
            Viteza1 = 10;
            Viteza2 = 22;
            Scor = 0;
            Puncte = 10;
            JocTerminat = false;
            direction = Direction.Stay;
        }
    }


}
