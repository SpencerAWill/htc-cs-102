namespace MovieApp
{
    public class Tag
    {
        private string _name;

        public Tag(string name = "New Tag")
        {
            _name = name;
        }

        public string getTagName()
        {
            return _name;
        }
    }
}