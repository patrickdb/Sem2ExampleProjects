using NUnit.Framework;
using RepositoryAndTesting;

namespace TestFileRepositoryLogic
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SuccessCase()
        {
            StubContext dataContext = new StubContext();
            FileRepository fr = new FileRepository(dataContext);

            dataContext.setAddFileSucces(true);
            File newFile = new File("content", "filename");
            Assert.IsTrue(fr.addNewFile(newFile));
        }

        [Test]
        public void FailingContextCase()
        {
            StubContext dataContext = new StubContext();
            FileRepository fr = new FileRepository(dataContext);

            dataContext.setAddFileSucces(false);

            File newFile = new File("content", "filename");
            Assert.IsFalse(fr.addNewFile(newFile));
        }

        [Test]
        public void FailingWhenEmptyFileName()
        {
            StubContext dataContext = new StubContext();
            FileRepository fr = new FileRepository(dataContext);

            dataContext.setAddFileSucces(true);

            File newFile = new File("content", "");
            Assert.IsFalse(fr.addNewFile(newFile));
        }

        [Test]
        public void FailingWhenInvalidContext()
        {
            StubContext dataContext = null;
            FileRepository fr = new FileRepository(dataContext);

            //dataContext.setAddFileSucces(true);

            File newFile = new File("content", "File");
            Assert.IsFalse(fr.addNewFile(newFile));
        }

    }
}