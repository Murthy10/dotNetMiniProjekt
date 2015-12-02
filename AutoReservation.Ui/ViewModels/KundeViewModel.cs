﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.Extensions;
using AutoReservation.Ui.Factory;
using System.Collections.Generic;
using System.Linq;

namespace AutoReservation.Ui.ViewModels
{
    public class KundeViewModel : ViewModelBase
    {
        private readonly List<KundeDto> kundenOriginal = new List<KundeDto>();
        private readonly ObservableCollection<KundeDto> kunden = new ObservableCollection<KundeDto>();
        public KundeViewModel(IServiceFactory factory) : base(factory)
        {
            
        }

        public ObservableCollection<KundeDto> Kunden
        {
            get { return kunden; }
        }

        private KundeDto selectedKunde;
        public KundeDto SelectedKunde
        {
            get { return selectedKunde; }
            set
            {
                if (selectedKunde == value)
                {
                    return;
                }
                selectedKunde = value;
                this.OnPropertyChanged(p => p.SelectedKunde);
            }
        }


        #region Load-Command
        private RelayCommand loadCommand;
        public ICommand LoadCommand
        {
            get
            {
                return loadCommand ?? (loadCommand = new RelayCommand(param => Load(), param => CanLoad()));
            }
        }

        private readonly ObservableCollection<AutoDto> autos = new ObservableCollection<AutoDto>();
        public ObservableCollection<AutoDto> Autos
        {
            get { return autos; }
        }

        protected override void Load()
        {
            Kunden.Clear();
            kundenOriginal.Clear();

            Kunden.Clear();
            Autos.Clear();

            foreach (ReservationDto reservation in Service.Reservationen())
            {
                Reservationen.Add(reservation);
            }
            foreach (AutoDto auto in Service.Autos())
            {
                Autos.Add(auto);
            }
            foreach (KundeDto kunde in Service.Kunden())
            {
                Kunden.Add(kunde);
                kundenOriginal.Add((KundeDto)kunde.Clone());
            }
            SelectedKunde = Kunden.FirstOrDefault();
        }

        private readonly List<ReservationDto> reservationenOriginal = new List<ReservationDto>();
        private readonly ObservableCollection<ReservationDto> reservationen = new ObservableCollection<ReservationDto>();


        public ObservableCollection<ReservationDto> Reservationen
        {
            get { return reservationen; }
        }
        private bool CanLoad()
        {
            return ServiceExists;
        }

        #endregion

        #region Save-Command
        private RelayCommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new RelayCommand(param => SaveData(), param => CanSaveData()));
            }
        }

        private void SaveData()
        {
            foreach (var kunde in Kunden)
            {
                if (kunde.Id == default(int))
                {
                    Service.InsertKunde(kunde);
                }
                else
                {
                    var original = kundenOriginal.FirstOrDefault(ku => ku.Id == kunde.Id);
                    Service.UpdateKunde(kunde, original);
                }
            }
            Load();
        }
        #endregion

        private bool CanSaveData()
        {
            if (!ServiceExists)
            {
                return false;
            }

            return Validate(Kunden);
        }

        #region New-Command
        private RelayCommand newCommand;

        public ICommand NewCommand
        {
            get
            {
                return newCommand ?? (newCommand = new RelayCommand(param => New(), param => CanNew()));
            }
        }

        private void New()
        {
            Kunden.Add(new KundeDto());
        }

        private bool CanNew()
        {
            return ServiceExists;
        }
        #endregion

        #region Delete-Command
        private RelayCommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (deleteCommand = new RelayCommand(param => Delete(), param => CanDelete()));
            }
        }

        private void Delete()
        {
            Service.DeleteKunde(SelectedKunde);
            Load();
        }

        private bool CanDelete()
        {
            return
                ServiceExists &&
                SelectedKunde != null &&
                SelectedKunde.Id != default(int);
        }
        #endregion
    }
}
