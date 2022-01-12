using Newtonsoft.Json;
using PolymorphicDataBindingExample.JSONConverter;

namespace PolymorphicDataBindingExample.Model
{
    [JsonConverter(typeof(PersonConverter))]
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
    public class Student : Person
    {
        public string SchoolName { get; set; }
    }
    public class Doctor : Person
    {
        public string HospitalName { get; set; }
    }

}
