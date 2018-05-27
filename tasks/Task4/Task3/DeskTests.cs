using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class DeskTests
    {
        [Test]
        public void CannotCreateDeskWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var test = new Desk(null, 102, 30, 350);
            });
        }

        [Test]
        public void CannotCreateDeskWithEmptyRoomNumber()
        {
            Assert.Catch(() =>
            {
                var test = new Desk("Schreibtisch höhenverstellbar", 0, 30, 350);
            });
        }

        [Test]
        public void CannotCreateDeskWithWrongInventorynumber()
        {
            Assert.Catch(() =>
            {
                var test = new Desk("Schreibtisch höhenverstellbar", 102, 0, 350);
            });
        }

        [Test]
        public void CannotCreateDeskWithNegativeInventorynumber()
        {
            Assert.Catch(() =>
            {
                var test = new Desk("Schreibtisch höhenverstellbar", 102, -20, 350);
            });
        }

        [Test]
        public void CannotCreateDeskWithZeroRestValue()
        {
            Assert.Catch(() =>
            {
                var test = new Desk("Schreibtisch höhenverstellbar", 102, 30, 0);
            });
        }

        [Test]
        public void CannotCreateDeskWithNegativeRestValue()
        {
            Assert.Catch(() =>
            {
                var test = new Desk("Schreibtisch höhenverstellbar", 102, 30, 0);
            });
        }

        [Test]
        public void CannotChangeRestValueToNegative()
        {
            Assert.Catch(() =>
            {
                var test = new Desk(null, 102, 30, 350);
                test.SetRestvalue(-100);
            });
        }
    }
}
