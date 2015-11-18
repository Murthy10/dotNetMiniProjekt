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

        public void CreateAuto(AutoDto auto)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void CreateKunde(KundeDto kunde)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void CreateReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void DeleteAuto(AutoDto auto)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void DeleteKunde(KundeDto kunde)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void DeleteReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<AutoDto> getAllAutos()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<KundeDto> getAllKunden()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<ReservationDto> getAllReservationen()
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
            throw new NotImplementedException();
        }

        public void UpdateKunde(KundeDto original, KundeDto modified)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void UpdateReservation(ReservationDto original, ReservationDto modified)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }
    }
}