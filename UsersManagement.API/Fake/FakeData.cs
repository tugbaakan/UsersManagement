using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;
        public static List<User> GetUsers(int number)
        { 
            if ( _users == null) 
            {             _users= new Faker<User>()
                .RuleFor(u=>u.Id, f=>f.IndexFaker+1)
                .RuleFor(u=>u.FirstName,f=>f.Name.FirstName())
                .RuleFor(u=>u.LastName, f=>f.Name.LastName())
                .RuleFor(u=>u.Address, f=>f.Address.FullAddress())
                .Generate(number);
            }
            
            return _users;

        }
    }
}
