using AutoReservation.Common.DataTransferObjects;
namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        System.Collections.Generic.List<AutoDto> getAllAutos();
        System.Collections.Generic.List<KundeDto> getAllKunden();
        System.Collections.Generic.List<ReservationDto> getAllReservationen();

        AutoDto getAuto(int id);
        KundeDto getKunde(int id);
        ReservationDto getReservation(int id);

        void createAuto(AutoDto auto);
        void createKunde(KundeDto kunde);
        void createReservation(ReservationDto reservation);

        void updateAuto(AutoDto original, AutoDto modified);
        void updateKunde(KundeDto original, KundeDto modified);
        void updateReservation(ReservationDto original, ReservationDto modified);

        void deleteAuto(AutoDto auto);
        void deleteKunde(KundeDto kunde);
        void deleteReservation(ReservationDto reservation);
    }
}
