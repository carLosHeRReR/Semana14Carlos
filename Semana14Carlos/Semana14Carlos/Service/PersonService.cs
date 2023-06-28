﻿using System;
using System.Collections.Generic;
using System.Linq;
using Semana14Carlos.DataContext;
using Semana14Carlos.Model;

namespace Semana14Carlos
{
    public class PersonService
    {
        private readonly AppDbContext _context;

        public PersonService() => _context = App.GetContext();


        public bool Create(Person item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Person> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Person> Get()
        {
            return _context.People.ToList();
        }


        public List<Person> GetByText(string text)
        {
            return _context.People.Where(x => x.Name.Contains(text)).ToList();
        }



    }
}
