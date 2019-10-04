namespace RepositoryExample
{
    internal class NetwerkContext : IFileContext
    {
        void IFileContext.addFile(File newFile)
        {
            System.Console.WriteLine("=== NETWORK CONTEXT ===");
            System.Console.WriteLine("Initializing network ... Retrieving adress: 0.0.0.0");
            System.Console.WriteLine("Create file: " + newFile.FileName);
            System.Console.WriteLine("Writing content:" + newFile.FileContent);
            System.Console.WriteLine("");
        }
    }
}