namespace SimpleBlog.Shared.Entities
{
    public class Setting
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; } = null;
    }
}
