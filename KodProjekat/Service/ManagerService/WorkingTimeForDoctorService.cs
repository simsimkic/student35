// File:    WorkingTimeForDoctorService.cs
// Created: Thursday, June 11, 2020 6:14:37 PM
// Purpose: Definition of Class WorkingTimeForDoctorService

using Model.ManagerFunctionality;
using Model.Roles;
using Repository.ManagerRepository;
using Repository.UserRepository;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service.ManagerService
{
   public class WorkingTimeForDoctorService
   {
        

        public ObservableCollection<Doctor> Doctors
        {
            get;
            set;

        }

        public WorkingTimeForDoctorService()
        {
            Doctors = new ObservableCollection<Doctor>();
            Doctors = DoctorRepository.getInstance().GetAllUsers();
        }


        public void DetermineDoktorWorkTime(DoctorWorktime workTimeForDoctor, string idSelectedDoctor)
      {
            foreach (Doctor doctor in Doctors)
            {
                if (doctor.Jmbg.ToString().Equals(idSelectedDoctor))
                {

                    if (allreadyExistsForThisDayWorkTime(doctor, workTimeForDoctor.DanRada))
                    {
                        MessageBox.Show("radno vreme je vec odredjeno za taj dan", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                    else
                    {
                       
                        doctor.popunjavanjeRadnoVRemePrikazDoktora(workTimeForDoctor);
                        DoctorRepository.getInstance().saveAllUsers(Doctors);
                        MessageBox.Show("Uspesno je odredjeno radno vreme za izabrani dan", "Uspesno", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                }

            }
       }

        public bool allreadyExistsForThisDayWorkTime(Doctor doctor, DateTime dan)
        {
            foreach (DoctorWorktime prikazVremena in doctor.dajRadnoVRemePrikazDoktora())
            {
                if (prikazVremena.DanRada == dan)
                {
                    return true;
                }
            }
            return false;
        }


        public void EditDoktorWorkTime(DoctorWorktime workTimeForDoctor, string idSelectedDoctor, DoctorWorktime selectedDay)
        {
            foreach (Doctor doctor in Doctors)
            {
                if (doctor.Jmbg.ToString().Equals(idSelectedDoctor))
                {

                       DoctorWorktime newWorkDay = getSelectedWorkTimeForSelectedDoctor(doctor, selectedDay);
                   
                        newWorkDay.DanRada = workTimeForDoctor.DanRada;
                        newWorkDay.RadnoVreme = workTimeForDoctor.RadnoVreme;
                        DoctorRepository.getInstance().saveAllUsers(Doctors);

                        MessageBox.Show("Uspesno je izmenjeno radno vreme za izabrani dan,za izabranog doktora", "Uspesno", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    
                   
                }


            }
        }

        public DoctorWorktime getSelectedWorkTimeForSelectedDoctor(Doctor doctor, DoctorWorktime work)
        {
            foreach (DoctorWorktime workDoctor in doctor.dajRadnoVRemePrikazDoktora())
            {
                if (workDoctor.DanRada == work.DanRada && workDoctor.RadnoVreme.Equals(work.RadnoVreme))
                {
                    return workDoctor;
                }

            }

            return null;
        }

        public void DeleteDoktorWorkTime(DoctorWorktime workTimeForDoctor, string idSelectedDoctor)
        {
            foreach (Doctor doctorTrenutni in Doctors)
            {
                if (doctorTrenutni.Jmbg.ToString().Equals(idSelectedDoctor))
                {

                    foreach (DoctorWorktime prikazVremena in doctorTrenutni.dajRadnoVRemePrikazDoktora())
                    {
                        if (prikazVremena.DanRada==workTimeForDoctor.DanRada)
                        {
                            doctorTrenutni.dajRadnoVRemePrikazDoktora().Remove(prikazVremena);
                            DoctorRepository.getInstance().saveAllUsers(Doctors);
                            MessageBox.Show("Uspesno je obrisano radno vreme za izabrani dan,za izabranog doktora", "Uspesno", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        }

                    }


                }

            }

        }


    }
}