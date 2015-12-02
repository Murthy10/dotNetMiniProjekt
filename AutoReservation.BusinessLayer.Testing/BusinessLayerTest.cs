using System;
using AutoReservation.TestEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoReservation.BusinessLayer;
using AutoReservation.Dal;
using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.Extensions;
using System.Collections.Generic;
using AutoReservation.Service.Wcf;

namespace AutoReservation.BusinessLayer.Testing
{
    [TestClass]
    public class BusinessLayerTest
    {
        private AutoReservationBusinessComponent target;
        private AutoReservationBusinessComponent Target
        {
            get
            {
                if (target == null)
                {
                    target = new AutoReservationBusinessComponent();
                }
                return target;
            }
        }


        [TestInitialize]
        public void InitializeTestData()
        {
            TestEnvironmentHelper.InitializeTestData();
        }

        [TestMethod]
        public void Test_UpdateAuto()
        {
            AutoReservationBusinessComponent arvc = new AutoReservationBusinessComponent();
            Auto original = arvc.GetAllAutos()[0];
            Auto modified = arvc.GetAllAutos()[0];
            modified.Marke = "Skoda";
            arvc.UpdateAuto(original, modified);
            Auto newCar = arvc.GetAllAutos()[0];
            Assert.AreEqual("Skoda", newCar.Marke);
        }


        [TestMethod]
        public void Test_UpdateKunde()
        {
            AutoReservationBusinessComponent arvc = new AutoReservationBusinessComponent();
            Kunde original = arvc.GetAllKunden()[0];
            Kunde modified = arvc.GetAllKunden()[0];
            modified.Vorname = "Skoda";
            arvc.UpdateKunde(original, modified);
            Kunde newKunde = arvc.GetAllKunden()[0];
            Assert.AreEqual("Skoda", newKunde.Vorname);
        }

        [TestMethod]
        public void Test_UpdateReservation()
        {
            AutoReservationBusinessComponent arvc = new AutoReservationBusinessComponent();
            Reservation original = arvc.GetAllReservations()[0];
            Reservation modified = arvc.GetAllReservations()[0];
            modified.Bis = new DateTime(2099, 12, 31);
            arvc.UpdateReservation(original, modified);
            Reservation newReservation = arvc.GetAllReservations()[0];
            Assert.AreEqual(new DateTime(2099, 12, 31), modified.Bis);
        }
    }
}
