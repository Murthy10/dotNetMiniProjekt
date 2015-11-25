using AutoReservation.Common.DataTransferObjects;
using System.ServiceModel;

namespace AutoReservation.Common.Interfaces
{
    [ServiceContract]
    public interface IAutoReservationService
    {
        [OperationContract]
        System.Collections.Generic.List<AutoDto> Autos();
        [OperationContract]
        System.Collections.Generic.List<KundeDto> Kunden();
        [OperationContract]
        System.Collections.Generic.List<ReservationDto> Reservationen();

        [OperationContract]
        AutoDto getAuto(int id);
        [OperationContract]
        KundeDto getKunde(int id);
        [OperationContract]
        ReservationDto getReservation(int id);

        [OperationContract]
        void InsertAuto(AutoDto auto);
        [OperationContract]
        void InsertKunde(KundeDto kunde);
        [OperationContract]
        void InsertReservation(ReservationDto reservation);

        [OperationContract]
        void UpdateAuto(AutoDto original, AutoDto modified);
        [OperationContract]
        void UpdateKunde(KundeDto original, KundeDto modified);
        [OperationContract]
        void UpdateReservation(ReservationDto original, ReservationDto modified);

        [OperationContract]
        void DeleteAuto(AutoDto auto);
        [OperationContract]
        void DeleteKunde(KundeDto kunde);
        [OperationContract]
        void DeleteReservation(ReservationDto reservation);
    }
}
