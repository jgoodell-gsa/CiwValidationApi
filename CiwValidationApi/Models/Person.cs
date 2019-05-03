using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CiwValidationApi.Models
{
    public class Person
    {
        public string PlaceOfBirthCountryName { get; set; }
        public string HomeCountryName { get; set; }
        public string CitizenCountryName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirthCity { get; set; }
        public string PlaceOfBirthCountry { get; set; }
        public string PlaceOfBirthState { get; set; }
        public string PlaceOfBirthMexicoCanada { get; set; }
        public string HomeAddressOne { get; set; }
        public string HomeAddressTwo { get; set; }
        public string HomeAddressThree { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressCountry { get; set; }
        public string HomeAddressUsState { get; set; }
        public string HomeAddressMexicoStateCanadaProvince { get; set; }
        public string HomeAddressZip { get; set; }
        public string PhoneNumberWork { get; set; }
        public string PhoneNumberWorkCell { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string PositionJobTitle { get; set; }
        public string PriorInvestigation { get; set; }
        public string PriorInvestigationDate { get; set; }
        public string AgencyAdjudicatedPriorInvestigation { get; set; }
        public string Citizen { get; set; }
        public string PortOfEntryUsCityAndState { get; set; }
        public string DateOfEntry { get; set; }
        public string LessThanThreeYearsResident { get; set; }
        public string AlienRegistrationNumber { get; set; }
        public string CitizenshipCountry { get; set; }

        public IList<GsaPoc> GsaPocList;
        public IList<VendorPoc> VendorPocList;

        public Person()
        {
            GsaPocList = new List<GsaPoc>();
            VendorPocList = new List<VendorPoc>();
        }
    }
}