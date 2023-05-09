using Chazz.Components;
using Unity.Entities;
using UnityEngine;

namespace Chazz.Authoring
{
    public class ChessboadSquareAuthoring : MonoBehaviour
    {
        public ChessColor Color;

        [Tooltip("Column (0-7)")]
        public uint File;

        [Tooltip("Row (0-7)")]
        public uint Rank;
    }

    public class ChessboadSquareBaker : Baker<ChessboadSquareAuthoring>
    {
        public override void Bake(ChessboadSquareAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Renderable);

            AddComponent(entity, new ChessboardSquare
            {
                Color = authoring.Color,
                Position = new ChessboardPosition
                {
                    File = authoring.File,
                    Rank = authoring.Rank
                },
            });
        }
    }
}