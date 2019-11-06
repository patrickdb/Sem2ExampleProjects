using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryAndTesting
{
    public class StubContext : IFileContext
    {
        List<File> files;
        bool addFileSucces = false;

        public void setAddFileSucces(bool state)
        {
            addFileSucces = state;
        }

        bool IFileContext.addFile(File newFile)
        {
            return addFileSucces;
        }
    }
}
