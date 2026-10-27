namespace NamesManagement
{
    class NamesValidator
    {
        public bool IsValid(string name)
        {
            return name.Length >= 2 &&
                name.Length < 20 &&
                char.IsUpper(name[0]) &&
                name.All(char.IsLetter);
        }
    }

  
}
