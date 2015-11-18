using AutoReservation.Dal;

namespace AutoReservation.BusinessLayer

{
    public class AutoReservationBusinessComponent
    {
        public void insert(Auto auto)
        {
            using(var context = new AutoReservationEntities()){
                context.Auto.Add(auto);
            }
        }

        public void update(Auto original, Auto modified)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
            }
        }

        public void delete(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Auto.Attach(auto);
                context.Auto.Remove(auto);
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