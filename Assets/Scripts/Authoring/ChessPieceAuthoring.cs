using Chazz.Components;
using Unity.Entities;
using UnityEngine;

namespace Chazz.Authoring
{
    public class ChessPieceAuthoring : MonoBehaviour
    {
        public ChessColor Color;
        public ChessPieceType Type;
        public Vector2Int BoardPosition;
    }

    public class ChessPieceBaker : Baker<ChessPieceAuthoring>
    {
        public override void Bake(ChessPieceAuthoring authoring)
        {
        }
    }
}