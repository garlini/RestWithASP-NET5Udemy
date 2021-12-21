using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private volatile int count;

        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        Person IPersonBusiness.Create(Person person)
        {
            return _repository.Create(person);
        }

        void IPersonBusiness.Delete(long id)
        {
            _repository.Delete(id);
        }

        List<Person> IPersonBusiness.findAll()
        {
            return _repository.findAll();
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person Lastname",
                Address = "Some Address",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        Person IPersonBusiness.FindById(long id)
        {
            return _repository.FindById(id);
        }

        Person IPersonBusiness.Update(Person person)
        {
            return _repository.Update(person);
        }

    }
}
