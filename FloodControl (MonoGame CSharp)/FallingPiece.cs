using Microsoft.Xna.Framework;

public class FallingPiece : GamePiece
{
    public int VerticalOffset;
    public static int fallRate = 5;

    public FallingPiece(string pieceType, int verticalOffset)
        : base(pieceType)
    {
        VerticalOffset = verticalOffset;
    }

    public void UpdatePiece()
    {
        VerticalOffset = MathHelper.Max(0, VerticalOffset - fallRate);
    }
}