namespace Application.Common
{
    public class DataCollection<T>
    {
        public bool HasItems
        {
            get
            {
                return Items != null && Items.Any();
            }
        }

        public int Total { get; set; }

        public int Page { get; set; }

        public int Pages { get; set; }

        public IEnumerable<T> Items { get; set; }

    }

    public class IndexedItem<T>
    {
        public int Index { get; set; }
        public T Item { get; set; }
    }
}
