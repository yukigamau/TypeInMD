using static TypeInMD.Core.Models.CursorState;

namespace TypeInMD.Core.Models
{
    public record CursorState(Pos Anchor, Pos Focus)
    {
        public record Pos(int Line, int Ch);
    }
}
