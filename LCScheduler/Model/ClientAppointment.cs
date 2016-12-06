using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using LCScheduler.Data;
using SQLite;

namespace LCScheduler.Model
{
    public class ClientAppointment : DatabaseService<ClientAppointment>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        [Ignore]
        public object ResourceId { get; set; }
        public int ClientId { get; set; }

        public static BindingList<ClientAppointment> GetClientAppointments()
        {
            return new BindingList<ClientAppointment>(GetItems().ToList());
        }

        public static ClientAppointment GetLastAppointmentForClient(int clientId)
        {
            List<ClientAppointment> appointments =
                GetItems()
                    .Where(x => x.ClientId == clientId)
                    .Where(x => x.StartTime.Date <= DateTime.Today.Date)
                    .OrderByDescending(x => x.StartTime)
                    .ToList();

            if (appointments.Count > 0)
            {
                return appointments[0];
            }
            else
            {
                return null;
            }
        }

        public static List<ClientAppointment> GetClientAppointmentsForRange(DateTime dteStart, DateTime dteEnd)
        {
            return GetItems().Where(x => x.StartTime >= dteStart && x.EndTime < dteEnd).OrderBy(x => x.StartTime).ToList();
        }
    }

    public class AppointmentExtender
    {
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string ClientName => ClientInformation.GetClientInfo(Convert.ToInt32(ClientId)).FullName;

        public string ClientNumber => ClientInformation.GetClientInfo(Convert.ToInt32(ClientId)).PhoneNumberA;

        public DateTime AppointmentStartDate => Convert.ToDateTime(StartDate).Date;

        public static List<AppointmentExtender> GetAppointments(DateTime dteStart, DateTime dteEnd)
        {
            // this will be the list that we will pass back
            List<AppointmentExtender> aptList = new List<AppointmentExtender>();

            foreach (ClientAppointment clientAppointment in ClientAppointment.GetClientAppointmentsForRange(dteStart, dteEnd))
            {
                AppointmentExtender aptExtender = new AppointmentExtender
                {
                    ClientId = clientAppointment.ClientId,
                    StartDate = clientAppointment.StartTime,
                    EndDate = clientAppointment.EndTime
                };
                aptList.Add(aptExtender);
            }

            return aptList;
        }
    }

}
