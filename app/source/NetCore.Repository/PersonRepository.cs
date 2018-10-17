using System;
using NetCore.Entities;

namespace NetCore.Repository
{
    public class PersonRepository
    {
        public PersonEntity[] GetAll()
        {
            var persons = new PersonEntity[3]
            {
                new PersonEntity
                {
                    Name = "Jesus", Lastname = "Ramirez", EmailAddress = "jramirez@gmail.com", Age = 25,
                    Dni = "40124578"
                },
                new PersonEntity
                {
                    Name = "Alfredo", Lastname = "Magallanes", EmailAddress = "amagallanes@gmail.com", Age = 27,
                    Dni = "40124570"
                },
                new PersonEntity
                {
                    Name = "Vladimir", Lastname = "Estrada", EmailAddress = "vestrada@gmail.com", Age = 29,
                    Dni = "40124579"
                }
            };
            return persons;
        }
    }
}
