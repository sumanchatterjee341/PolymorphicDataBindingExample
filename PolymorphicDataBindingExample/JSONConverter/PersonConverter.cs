using Newtonsoft.Json.Linq;
using PolymorphicDataBindingExample.Model;

namespace PolymorphicDataBindingExample.JSONConverter
{
    public class PersonConverter : JsonCreationConverter<Person>
    {
        protected override Person Create(Type objectType, JObject jObject)
        {
            if(jObject == null) throw new ArgumentNullException(nameof(jObject));
            if (jObject["SchoolName"] != null)
                return new Student();
            else if (jObject["HospitalName"] != null)
                return new Doctor();
            else
                return new Person();
        }
    }
}
