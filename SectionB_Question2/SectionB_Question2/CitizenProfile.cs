using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SectionB_Question2
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int age { get; set; }
        public string Citizenshipstatus { get; set; }


        public CitizenProfile(string name, string id, string citezenship)
        {
            FullName = name;
            IDNumber = id;
            Citizenshipstatus = citezenship;
            age = CalculateAge();
        }

        public int CalculateAge()
        {

            try
            {
                // Extract the date of birth from the ID number

                string dob = IDNumber.Substring(0, 6);
                
                int year = int.Parse(dob.Substring(0, 2));
                int month = int.Parse(dob.Substring(2, 2));
                int day  = int.Parse(dob.Substring(4, 2));

                int fullyear;

                if (year <= DateTime.Now.Year % 100)
                {
                    fullyear = 2000 + year;

                }
                else
                
                    fullyear = 1900 + year;

                DateTime birthdate = new DateTime(fullyear, month, day);

                int age = DateTime.Now.Year - birthdate.Year;

                if (DateTime.Now < birthdate.AddYears(age))
                {
                    age--;
                }

                return age;
            }
            catch
            {
                return -1;
            }
        }


        // Method to validate the ID number format
        public string ValidId()
        {
            if (IDNumber.Length != 13)
            {
                return "Invalid Id. It must be 13 digits";
            }
            // Checks if it is a number
            if (!long.TryParse(IDNumber, out _))
            {
                return "Invalid Id. Please enter a number";
            }

            if (age < 0)
            {
                return "Invalid Id. The BirthDate is not correct";
            }

            return $"Valid Id. Citizen is {age} years old";
        }
    }
}
