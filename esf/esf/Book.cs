namespace esf
{
    internal class Book
    {
        public string Name { get; internal set; }
        public string Author { get; internal set; }
        public int Page { get; internal set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Book objAsPart = obj as Book;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(Book other)
        {
            if (other == null) return false;
            return (this.Page.Equals(other.Page));
        }
    }
}