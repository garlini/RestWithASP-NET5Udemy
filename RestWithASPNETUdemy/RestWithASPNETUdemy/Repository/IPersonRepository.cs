﻿using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindById(long id);

        Person Update(Person person);

        void Delete(long id);

        List<Person> findAll();

        bool Exists(long id);
    }
}
