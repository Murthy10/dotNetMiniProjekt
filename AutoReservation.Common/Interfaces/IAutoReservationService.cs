using AutoReservation.Common.DataTransferObjects;
namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        System.Collections.Generic.List<AutoDto> Autos();
        System.Collections.Generic.List<KundeDto> getAllKunden();
        System.Collections.Generic.List<ReservationDto> getAllReservationen();

        AutoDto getAuto(int id);
        KundeDto getKunde(int id);
        ReservationDto getReservation(int id);

        void CreateAuto(AutoDto auto);
        void CreateKunde(KundeDto kunde);
        void CreateReservation(ReservationDto reservation);

        void UpdateAuto(AutoDto original, AutoDto modified);
        void UpdateKunde(KundeDto original, KundeDto modified);
        void UpdateReservation(ReservationDto original, ReservationDto modified);

        void DeleteAuto(AutoDto auto);
        void DeleteKunde(KundeDto kunde);
        void DeleteReservation(ReservationDto reservation);
    }
}
