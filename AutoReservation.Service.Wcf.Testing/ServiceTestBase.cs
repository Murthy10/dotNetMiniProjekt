using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.Interfaces;
using AutoReservation.TestEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AutoReservation.Service.Wcf.Testing
{
    [TestClass]
    public abstract class ServiceTestBase
    {
        protected abstract IAutoReservationService Target { get; }

        [TestInitialize]
        public void InitializeTestData()
        {
            TestEnvironmentHelper.InitializeTestData();
        }

        [TestMethod]
        public void Test_GetAutos()
        {
            var autos = Target.Autos();
            Assert.IsTrue(autos.Count > 0);
        }

        [TestMethod]
        public void Test_GetKunden()
        {
            var kunden = Target.Kunden();
            Assert.IsTrue(kunden.Count > 0);
        }

        [TestMethod]
        public void Test_GetReservationen()
        {
            var res = Target.Reservationen();
            Assert.IsTrue(res.Count > 0);
        }

        [TestMethod]
        public void Test_GetAutoById()
        {
            var obj = Target.getAuto(1);
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void Test_GetKundeById()
        {
            var obj = Target.getKunde(1);
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void Test_GetReservationByNr()
        {
            var obj = Target.getReservation(1);
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void Test_GetReservationByIllegalNr()
        {
            var obj = Target.getReservation(12312312);
            Assert.IsNull(obj);
        }

        [TestMethod]
        public void Test_InsertAuto()
        {
            var countOld = Target.Autos().Count;
            var auto = new AutoDto();
            auto.Marke = "Yolo";
            auto.Tagestarif = 5;
            auto.Basistarif = 10;
            auto.AutoKlasse = AutoKlasse.Luxusklasse;
            Target.InsertAuto(auto);
            var countNew = Target.Autos().Count;
            Assert.AreEqual(countOld + 1, countNew);
        }

        [TestMethod]
        public void Test_InsertKunde()
        {
            var countOld = Target.Kunden().Count;
            var kunde = new KundeDto();
            kunde.Nachname = "yolo";
            kunde.Vorname = "Heiri";
            kunde.Geburtsdatum = DateTime.Now;
            Target.InsertKunde(kunde);
            var countNew = Target.Kunden().Count;
            Assert.AreEqual(countOld + 1, countNew);
        }

        [TestMethod]
        public void Test_InsertReservation()
        {
            var countOld = Target.Reservationen().Count;
            var res = new ReservationDto();
            res.Auto = Target.getAuto(1);
            res.Kunde = Target.getKunde(1);
            res.Bis = DateTime.Now;
            res.Von = DateTime.Now;
            Target.InsertReservation(res);
            var countNew = Target.Reservationen().Count;
            Assert.AreEqual(countOld + 1, countNew);
        }

        [TestMethod]
        public void Test_UpdateAuto()
        {
            Random rnd = new Random();
            var newname = "yoloHashtagSwag" + rnd.Next(9999);
            var old = Target.getAuto(1);
            var neu = old.Clone();
            neu.Marke = newname;
            Target.UpdateAuto(old, neu);
            var updated = Target.getAuto(1);
            Assert.AreEqual(newname, updated.Marke);
        }

        [TestMethod]
        public void Test_UpdateKunde()
        {
            Random rnd = new Random();
            var newname = "yoloHashtagSwag" + rnd.Next(9999);
            var old = Target.getKunde(1);
            var neu = old.Clone();
            neu.Nachname = newname;
            Target.UpdateKunde(old, neu);
            var updated = Target.getKunde(1);
            Assert.AreEqual(newname, updated.Nachname);
        }

        [TestMethod]
        public void Test_UpdateReservation()
        {
            var newname = DateTime.Now;
            var old = Target.getReservation(2);
            var neu = old.Clone();
            neu.Bis = newname;
            Target.UpdateReservation(old, neu);
            var updated = Target.getReservation(2);
            Assert.AreEqual(newname, updated.Bis);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<AutoDto>))]
        public void Test_UpdateAutoWithOptimisticConcurrency()
        {
            Assert.Inconclusive("Test not implemented.");
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<KundeDto>))]
        public void Test_UpdateKundeWithOptimisticConcurrency()
        {
            Assert.Inconclusive("Test not implemented.");
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ReservationDto>))]
        public void Test_UpdateReservationWithOptimisticConcurrency()
        {
            Assert.Inconclusive("Test not implemented.");
        }

        [TestMethod]
        public void Test_DeleteKunde()
        {
            var countOld = Target.Kunden().Count;
            var kunde = new KundeDto();
            kunde.Nachname = "yolo";
            kunde.Vorname = "Heiri";
            kunde.Geburtsdatum = DateTime.Now;
            Target.InsertKunde(kunde);
            var newKunde = Target.Kunden()[countOld];
            countOld = Target.Kunden().Count;
            Target.DeleteKunde(newKunde);
            var countNew = Target.Kunden().Count;
            Assert.AreEqual(countNew, countOld - 1);

        }

        [TestMethod]
        public void Test_DeleteAuto()
        {
            var countOld = Target.Autos().Count;
            var auto = new AutoDto();
            auto.Marke = "Yolo";
            auto.Tagestarif = 5;
            auto.Basistarif = 10;
            auto.AutoKlasse = AutoKlasse.Luxusklasse;
            Target.InsertAuto(auto);
            var newAuto = Target.Autos()[countOld];
            countOld = Target.Autos().Count;
            Target.DeleteAuto(newAuto);
            var countNew = Target.Autos().Count;
            Assert.AreEqual(countNew, countOld - 1);
        }

        [TestMethod]
        public void Test_DeleteReservation()
        {
            var countOld = Target.Reservationen().Count;
            var res = new ReservationDto();
            res.Auto = Target.getAuto(1);
            res.Kunde = Target.getKunde(1);
            res.Bis = DateTime.Now;
            res.Von = DateTime.Now;
            Target.InsertReservation(res);
            var newRes = Target.Reservationen()[countOld];
            countOld = Target.Reservationen().Count;
            Target.DeleteReservation(newRes);
            var countNew = Target.Reservationen().Count;
            Assert.AreEqual(countNew, countOld - 1);
        }
    }
}
