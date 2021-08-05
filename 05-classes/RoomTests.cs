using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void RoomTest()
        {
            // new up instance of a Room w/ Constructor from Room.cs Room class
            Room livingRoom = new Room(100, 20, 10);

            Console.WriteLine($"Width: {livingRoom.Width}, LSA: {livingRoom.LSA}, Total Square Feet: { livingRoom.TotalSqFt}");

        }
    }
}
