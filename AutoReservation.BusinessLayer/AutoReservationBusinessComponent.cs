using AutoReservation.Dal;

namespace AutoReservation.BusinessLayer

{
    public class AutoReservationBusinessComponent
    {
        public void InsertAuto(Auto auto)
        {
            using(var context = new AutoReservationEntities()){
                context.Auto.Add(auto);
            }
        }

        public void UpdateAuto(Auto original, Auto modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
            }
        }

        public void DeleteAuto(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(auto);
                context.Auto.Remove(auto);
            }
        }

        public void InsertKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Add(kunde);
            }
        }

        public void UpdateKunde(Kunde original, Kunde modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
            }
        }

        public void DeleteKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunde.Attach(kunde);
                context.Kunde.Remove(kunde);
            }
        }

        public void InsertReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Add(reservation);
            }
        }

        public void UpdateReservation(Reservation original, Reservation modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservation.Attach(reservation);
                context.Reservation.Remove(reservation);
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