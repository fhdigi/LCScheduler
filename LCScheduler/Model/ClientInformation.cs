using System;
using System.Collections.Generic;
using System.Linq;
using LCScheduler.Data;
using SQLite;

namespace LCScheduler.Model
{
    public class ClientInformation : DatabaseService<ClientInformation>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumberA { get; set; }
        public string PhoneNumberB { get; set; }
        public string DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int MaritalStatus { get; set; }
        public bool Student { get; set; }
        public string PrimaryInsurance { get; set; }
        public string InsuredName { get; set; }
        public int InsuredGender { get; set; }
        public string Employer { get; set; }
        public string InsuredPolicyNumber { get; set; }
        public string InsuredDateOfBirth { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string DiagnosisCode { get; set; }
        public int RelationshipToInsured { get; set; }
        public int LocationIndex { get; set; }

        [Ignore]
        public string FullName => $"{FirstName?.Trim()} {LastName?.Trim()}";

        public override string ToString()
        {
            return FullName;
        }

        public static List<ClientInformation> ReturnAllClients()
        {
            return GetItems().OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }

        public static ClientInformation GetClientInfo(int databaseId)
        {
            ClientInformation client = GetItems().Where(x => x.Id == databaseId).Select(x => x).SingleOrDefault();
            return client;
        }
    }
}
