using System;
using System.Collections.Generic;
using System.Linq;
using LCScheduler.Data;
using SQLite;

namespace LCScheduler.Model
{
    public class ProgressNoteInformation : DatabaseService<ProgressNoteInformation>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ClientId { get; set; }

        public DateTime DateOfService { get; set; }

        public int? SessionNumber { get; set; }

        public DateTime TimeStarted { get; set; }

        public DateTime TimeEnded { get; set; }

        public string NoteType { get; set; }

        public DateTime? NextSession { get; set; }

        public string TreatmentGoalAddressed { get; set; }

        public string Interventions { get; set; }

        public string ClientResponse { get; set; }

        public string HomeworkAssignedToday { get; set; }

        public string HomeworkCompletedLastSession { get; set; }

        public int Appearance { get; set; }

        public int Behavior { get; set; }

        public int MoodAffect { get; set; }

        public int Cognitions { get; set; }

        public bool DangerToOthers { get; set; }

        public string DescribeDanger { get; set; }

        public enum AppearanceOptions
        {
            WNL = 0,
            Unkempt = 1,
            Dirty = 2,
            Meticulous = 3,
            Unusual = 4
        }

        public enum BehaviorOptions
        {
            WNL = 0,
            Guarded = 1,
            Withdrawn = 2,
            Noncompliant = 3,
            Hostile = 4
        }

        public enum MoodAffectOptions
        {
            WNL = 0,
            Flat = 1,
            Depressed = 2,
            Euphoric = 3,
            Anxious = 4,
            Fearful = 5,
            Irritable = 6,
            Angry = 7,
            Labile = 8,
            Incongruent = 9
        }

        public enum CognitionsOptions
        {
            WNL = 0,
            Loose = 1,
            Scattered = 2,
            Blocked = 3,
            Illogical = 4,
            Delusional = 5,
            Paranoid = 6,
            Hallucinations = 7,
            Grandiose = 8,
            Fragmented = 9,
            Somatic = 10
        }

        public int Duration
        {
            get
            {
                try
                {
                    return (int)(TimeEnded - TimeStarted).TotalMinutes;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public string ClientName => ClientInformation.GetClientInfo(ClientId).FullName;

        //public void SaveNewProgressNote()
        //{
        //    ClientInfoDataClassDataContext db = new ClientInfoDataClassDataContext();
        //    db.ProgressNotes.InsertOnSubmit(this);
        //    db.SubmitChanges();
        //}

        //public void UpdateProgressNote()
        //{
        //    ClientInfoDataClassDataContext db = new ClientInfoDataClassDataContext();
        //    ProgressNote pNote = (from p in db.ProgressNotes where p.Id == Id select p).SingleOrDefault();

        //    if (pNote != null)
        //    {
        //        pNote.DateOfService = DateOfService;
        //        pNote.SessionNumber = SessionNumber;
        //        pNote.TimeStarted = TimeStarted;
        //        pNote.TimeEnded = TimeEnded;
        //        pNote.NoteType = NoteType;
        //        pNote.NextSession = NextSession;
        //        pNote.TreatmentGoalAddressed = TreatmentGoalAddressed;
        //        pNote.Interventions = Interventions;
        //        pNote.ClientResponse = ClientResponse;
        //        pNote.HomeworkAssignedToday = HomeworkAssignedToday;
        //        pNote.HomeworkCompletedLastSession = HomeworkCompletedLastSession;
        //        pNote.Appearance = Appearance;
        //        pNote.Behavior = Behavior;
        //        pNote.MoodAffect = MoodAffect;
        //        pNote.Cognitions = Cognitions;
        //        pNote.DangerToOthers = DangerToOthers;
        //        pNote.DescribeDanger = DescribeDanger;
        //        db.SubmitChanges();
        //    }
        //}

        //public void DeleteNote()
        //{
        //    ClientInfoDataClassDataContext db = new ClientInfoDataClassDataContext();
        //    ProgressNote pNote = (from p in db.ProgressNotes where p.Id == Id select p).SingleOrDefault();
        //    if (pNote != null)
        //    {
        //        db.ProgressNotes.DeleteOnSubmit(pNote);
        //        db.SubmitChanges();
        //    }
        //}

        public static List<ProgressNoteInformation> ReturnClientProgressNotes(int clientId)
        {
            List<ProgressNoteInformation> progressNoteList = GetItems().Where(x => x.ClientId == clientId).ToList();
            return progressNoteList;
        }

        public static ProgressNoteInformation ReturnClientProgressNoteBySessionDate(int clientId, DateTime sessionDate)
        {
            ProgressNoteInformation progressNote = GetItems().SingleOrDefault(x => x.ClientId == clientId && x.DateOfService == sessionDate);
            return progressNote;
        }

        public static ProgressNoteInformation ReturnClientProgressNote(int progressNoteId)
        {
            ProgressNoteInformation progressNote = GetItems().SingleOrDefault(x => x.Id == progressNoteId);
            return progressNote;
        }

        public static int ReturnClientIdFromNote(int progressNoteId)
        {
            int clientId = GetItems().Where(x => x.Id == progressNoteId).Select(x => x.ClientId).SingleOrDefault();
            return clientId;
        }
    }
}
