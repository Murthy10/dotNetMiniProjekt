﻿using AutoReservation.Dal;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace AutoReservation.BusinessLayer

{
    public class AutoReservationBusinessComponent
    {
        public void InsertAuto(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Add(auto);
                context.SaveChanges();
            }
        }

        public void UpdateAuto(Auto original, Auto modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                context.SaveChanges();
            }
        }

        public void DeleteAuto(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(auto);
                context.Auto.Remove(auto);
                context.SaveChanges();
            }
        }

        public void InsertKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Add(kunde);
                context.SaveChanges();
            }
        }

        public void UpdateKunde(Kunde original, Kunde modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                context.SaveChanges();
            }
        }

        public void DeleteKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Attach(kunde);
                context.Kunde.Remove(kunde);
                context.SaveChanges();
            }
        }

        public void InsertReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Add(reservation);
                context.SaveChanges();
            }
        }

        public void UpdateReservation(Reservation original, Reservation modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                context.SaveChanges();
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Attach(reservation);
                context.Reservation.Remove(reservation);
                context.SaveChanges();
            }
        }

        public List<Auto> GetAllAutos()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Auto.ToList();
            }
        }

        public List<Kunde> GetAllKunden()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunde.ToList();
            }
        }

        public List<Reservation> GetAllReservations()
        {
            using (var context = new AutoReservationEntities())
            {
                
                return context.Reservation.Include(r => r.Auto).Include(r => r.Kunde).ToList();
            }
        }



        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }
    }
}