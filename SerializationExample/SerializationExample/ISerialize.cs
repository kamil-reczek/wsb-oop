using System.Collections.Generic;

namespace SerializationExample
{
    public interface ISerialize
    {
        void serialize(List<Person> personList);
    }
}