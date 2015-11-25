using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.BusinessLayer;


namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService: IAutoReservationService
    {
        private AutoReservationBusinessComponent db = new AutoReservationBusinessComponent();
        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }

        public void InsertAuto(AutoDto auto)
        {
            WriteActualMethod();
            var dbAuto = auto.ConvertToEntity();
            db.InsertAuto(dbAuto);
        }

        public void InsertKunde(KundeDto kunde)
        {
            WriteActualMethod();
            var dbKunde = kunde.ConvertToEntity();
            db.InsertKunde(dbKunde);
        }

        public void InsertReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            var dbReservation = reservation.ConvertToEntity();
            db.InsertReservation(dbReservation);
        }

        public void DeleteAuto(AutoDto auto)
        {
            WriteActualMethod();
            var dbAuto = auto.ConvertToEntity();
            db.DeleteAuto(dbAuto);
        }

        public void DeleteKunde(KundeDto kunde)
        {
            WriteActualMethod();
            var dbKunde = kunde.ConvertToEntity();
            db.DeleteKunde(dbKunde);
        }

        public void DeleteReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            var dbResevation = reservation.ConvertToEntity();
            db.DeleteReservation(dbResevation);
        }

        public List<AutoDto> Autos()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<KundeDto> Kunden()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<ReservationDto> Reservationen()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public AutoDto getAuto(int id)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public KundeDto getKunde(int id)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public ReservationDto getReservation(int id)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void UpdateAuto(AutoDto original, AutoDto modified)
        {
            WriteActualMethod();
            var dbOrginal = original.ConvertToEntity();
            var dbModified = modified.ConvertToEntity();
            db.UpdateAuto(dbOrginal, dbModified);
        }

        public void UpdateKunde(KundeDto original, KundeDto modified)
        {
            WriteActualMethod();
            var dbOrginal = original.ConvertToEntity();
            var dbModified = modified.ConvertToEntity();
            db.UpdateKunde(dbOrginal, dbModified);
        }

        public void UpdateReservation(ReservationDto original, ReservationDto modified)
        {
            WriteActualMethod();
            var dbOrginal = original.ConvertToEntity();
            var dbModified = modified.ConvertToEntity();
            db.UpdateReservation(dbOrginal, dbModified);
        }
    }
}