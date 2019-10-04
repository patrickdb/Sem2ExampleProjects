using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    class USBFileContext : IFileContext
    {
        public void addFile(File newFile)
        {
            System.Console.WriteLine("=== USB CONTEXT ===");
            System.Console.WriteLine("USB present? : Yes");
            System.Console.WriteLine("Initializing USB drive ... Waiting: OK");
            System.Console.WriteLine("Create file: " + newFile.FileName);
            System.Console.WriteLine("Writing content:" + newFile.FileContent);
            System.Console.WriteLine("");
        }
    }
}
