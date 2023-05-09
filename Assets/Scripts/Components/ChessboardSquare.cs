using Unity.Entities;

namespace Chazz.Components
{
    public struct ChessboardPosition
    {
        // Columns = files
        public uint File;

        // Rows = ranks
        public uint Rank;
    }

    public struct ChessboardSquare : IComponentData
    {
        public ChessColor Color;
        public ChessboardPosition Position;
    }
}
