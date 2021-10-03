
namespace WinformInterface.Functions
{
    public class ReadWriteTxt
    {
        public string[] readFile( string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }

        public void writeFile( string path, string[] allText)
        {
            //if (!System.IO.File.Exists(path))
            //{
            //    // Create a file to write to.
            //    //string[] createText = { "Hello", "And", "Welcome" };
            //    System.IO.File.WriteAllLines(path, allText);
            //}

            System.IO.File.WriteAllLines(path, allText);

        }
    }
}
