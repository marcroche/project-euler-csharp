namespace ProjectEuler.Library.Graph
{
    internal class LatticeCorner
    {
        public string Name { get; }

        public int X { get; }
        public int Y { get; }

        public LatticeCorner Left { get; }
        public LatticeCorner Right { get; }
        public LatticeCorner Top { get; }
        public LatticeCorner Bottom { get; }
        
        public LatticeCorner()
        {

        }
    }
}
