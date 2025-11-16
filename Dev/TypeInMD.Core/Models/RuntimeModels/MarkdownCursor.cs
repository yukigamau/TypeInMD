namespace TypeInMD.Core.Models
{
    public record MarkdownCursor
    {
        public record Pos(string Key, int Offset);

        public Pos Anchor;

        public Pos Focus;
    }
}
