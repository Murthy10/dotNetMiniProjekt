using AutoReservation.Common.DataTransferObjects;
namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        System.Collections.Generic.List<AutoDto> Autos();
        System.Collections.Generic.List<KundeDto> Kunden();
        System.Collections.Generic.List<ReservationDto> Reservationen();

        AutoDto getAuto(int id);
        KundeDto getKunde(int id);
        ReservationDto getReservation(int id);

        void InsertAuto(AutoDto auto);
        void InsertKunde(KundeDto kunde);
        void InsertReservation(ReservationDto reservation);

        void UpdateAuto(AutoDto original, AutoDto modified);
        void UpdateKunde(KundeDto original, KundeDto modified);
        void UpdateReservation(ReservationDto original, ReservationDto modified);

        void DeleteAuto(AutoDto auto);
        void DeleteKunde(KundeDto kunde);
        void DeleteReservation(ReservationDto reservation);
    }
}
