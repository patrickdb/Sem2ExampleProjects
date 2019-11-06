using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    enum ContextType
    {
        USB,
        Netwerk,
        SQL,
        Test
    }

    class FileController
    {
        IFileContext ctx = null;

        public void addFile(File f)
        {
            if (ctx != null)
            {
                FileRepository rep = new FileRepository(ctx);
                rep.addNewFile(f);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void changeContext(ContextType type)
        {
            if(type == ContextType.USB)
            {
                ctx = new USBFileContext();
            }
            else if (type == ContextType.Netwerk)
            {
                ctx = new NetwerkContext();
            }
            else if (type == ContextType.Test)
            {
                ctx = new NetwerkContext();
            }
            else
            {
                ctx = null;
                throw new InvalidOperationException();
            }
        }
    }
}
