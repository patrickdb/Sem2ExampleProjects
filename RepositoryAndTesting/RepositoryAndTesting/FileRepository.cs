using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryAndTesting
{
    public class FileRepository
    {
        private IFileContext ctx = null;

        public FileRepository(IFileContext ctx)
        {
            this.ctx = ctx;
        }

      public bool addNewFile(File f)
    {
            if (f.FileName != "" && ctx != null)
            {
                return ctx.addFile(f);
            }
            else
            {
                return false;
            }
    }
    }
}
