using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class CRUD
    {

        public void Create(User user)
        {
            DB.Users.Add(user);
        }
        public void Delete(User user)
        {
            DB.Users.Remove(user);
        }
        public List<User> GetAllL()
        {
            return DB.Users;
        }

    }
}
