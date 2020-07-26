using BeeApp.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BeeAppTest
{
    [TestClass]
    public class BeeTest
    {
        public List<Bee> bees = new List<Bee>();
        Drone drone;
        Worker worker;
        Queen queen;
        public BeeTest()
        {
            // arrange

            drone = new Drone();
            worker = new Worker();
            queen = new Queen();
        }

        [TestMethod]
        public void TestInvalidInput_GreaterThan100OrLessThan0()
        {
            // act
            drone.Damage(110);

            // assert
            Assert.AreEqual(drone.health, 100);
        }

        [TestMethod]
        public void TestDrone_Below50()
        {
            // act
            drone.Damage(60);

            // assert
            Assert.AreEqual(drone.health, 40);
        }

        [TestMethod]
        public void TestDrone_Above50()
        {
            // act
            drone.Damage(40);

            // assert
            Assert.AreEqual(drone.health, 60);
        }

        [TestMethod]
        public void TestQueen_Below20()
        {
            // act
            queen.Damage(90);

            // assert
            Assert.AreEqual(queen.health, 10);
        }

        [TestMethod]
        public void TestQueen_Above20()
        {
            // act
            queen.Damage(40);

            // assert
            Assert.AreEqual(queen.health, 60);
        }

        [TestMethod]
        public void TestWorker_Below70()
        {
            // act
            worker.Damage(90);

            // assert
            Assert.AreEqual(worker.health, 10);
        }

        [TestMethod]
        public void TestWorker_Above70()
        {
            // act
            worker.Damage(20);

            // assert
            Assert.AreEqual(worker.health, 80);
        }
    }


}
