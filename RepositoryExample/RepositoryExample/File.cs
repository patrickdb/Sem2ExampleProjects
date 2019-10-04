using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    class File
    {
        private string data;
        private string fileName;

        public string FileName { get {return this.fileName; } private set { } }
        public string FileContent { get { return this.data; } private set { } }

        public File(string data, string fileName)
        {
            this.data = data;
            this.fileName = fileName;
        }
    }
}
