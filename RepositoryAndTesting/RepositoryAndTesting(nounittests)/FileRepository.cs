using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    class FileRepository
    {
        private IFileContext ctx = null;
        public FileRepository(IFileContext ctx)
        {
            this.ctx = ctx;
        }
      public void addNewFile(File f)
        {
            ctx.addFile(f);
        }
    }
}
