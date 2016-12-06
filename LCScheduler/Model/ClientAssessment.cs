using System.Linq;
using LCScheduler.Data;
using SQLite;

namespace LCScheduler.Model
{
    public class ClientAssessment : DatabaseService<ClientAssessment>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string PresentingProblem { get; set; }
        public string FamilyHistory { get; set; }
        public string PsychiatricHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string CurrentMedications { get; set; }
        public string SubstanceAbuseHistory { get; set; }
        public string Education { get; set; }
        public string Employment { get; set; }
        public string LegalHistory { get; set; }
        public string MentalStatusExam { get; set; }
        public string RiskAssessment { get; set; }
        public string ClinicalImpressionDiagnosis { get; set; }
        public string ClinicalImpressionAxisI { get; set; }
        public string TreatmentPlanProblem { get; set; }
        public string TreatmentPlanGoals { get; set; }
        public string TreatmentPlanInterventions { get; set; }
        public string TreatmentPlanModality { get; set; }

        [Ignore]
        public string ClientName { get; set; }

        [Ignore]
        public string ClientDateOfBirth { get; set; }

        public static ClientAssessment GetAssessment(int clientId)
        {
            ClientInformation client = ClientInformation.GetClientInfo(clientId);
            ClientAssessment clientAssessment = GetItems().SingleOrDefault(x => x.ClientId == clientId);

            if (clientAssessment != null)
            {
                clientAssessment.ClientName = client.FullName;
                clientAssessment.ClientDateOfBirth = string.IsNullOrEmpty(client.DateOfBirth) ? "" : client.DateOfBirth;
            }

            return clientAssessment;
        }

        public static ClientAssessment CreateNewClientAssessment(int clientId)
        {
            // get the client information 
            ClientInformation client = ClientInformation.GetClientInfo(clientId);

            ClientAssessment clientAssessment = new ClientAssessment
            {
                ClientId = client.Id,
                ClientName = client.FullName,
                ClientDateOfBirth = string.IsNullOrEmpty(client.DateOfBirth) ? "" : client.DateOfBirth
            };

            return clientAssessment;
        }
    }
}
