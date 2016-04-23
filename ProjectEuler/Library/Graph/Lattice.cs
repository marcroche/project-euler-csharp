namespace ProjectEuler.Library.Graph
{
    internal class Lattice
    {
        public LatticeCorner[,] Corners { get; }

        public Lattice(int x, int y)
        {
            Corners = new LatticeCorner[x,y];

            for(int i = 0; i < x; i++)
            {

            }
        }
    }
}
