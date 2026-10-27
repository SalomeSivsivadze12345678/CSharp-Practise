using NamesManagement.DataAccess;

namespace NamesManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new Names();
            var path = new NamesFilePathBuilder().BuildFilePath();
            var stringsTextualRepository = new StringsTextualRepository();

            if (File.Exists(path))
            {
                Console.WriteLine("Names file already exists, Loading names");
                var stringsFromFile = stringsTextualRepository.Read(path);
                names.AddNames(stringsFromFile);
            }
            else
            {
                Console.WriteLine("Names file does not exist");

                names.AddName("Salome");
                names.AddName("Not a valid name");
                names.AddName("Nino");
                names.AddName("123 definitely not a valid name");

                Console.WriteLine("Saving names to a file");
                stringsTextualRepository.Write(path, names.All);
            }
            Console.WriteLine(new NamesFormatter().Format(names.All));
            Console.ReadKey();


        }
    }

  
}
