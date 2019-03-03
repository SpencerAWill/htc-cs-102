namespace WPF_Movie_List_Redone
{
    public class Genre
    {
        private string _name;
        public Genre(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
    }
}