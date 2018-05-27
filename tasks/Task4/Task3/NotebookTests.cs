using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class NotebookTests
    {
        [Test]
        public void CannotCreateNotebookWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var test = new Notebook(null, "1s2f3g", 15, 20);
            });
        }

        [Test]
        public void CannotCreateNotebookWithEmptySerialnumber()
        {
            Assert.Catch(() =>
            {
                var test = new Notebook("HP", null, 15, 20);
            });
        }

        [Test]
        public void CannotCreateNotebookWithWrongInventorynumber()
        {
            Assert.Catch(() =>
            {
                var test = new Notebook("HP", "1s2f3g", -4, 20);
            });
        }

        [Test]
        public void CannotCreateNotebookWithWrongRestValue()
        {
            Assert.Catch(() =>
            {
                var test = new Notebook(null, "1s2f3g", 15, 0);
            });
        }

    }
}
