using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comisionesapi.Utils
{
    public class ResolverUser
    {
        public User GetUser(HttpContext httpContext)
        {
            var id = httpContext.User.Claims.Where(user => user.Type == "id").FirstOrDefault();
            var colaboradorId = httpContext.User.Claims.Where(user => user.Type == "id").FirstOrDefault();
            return new User
            {
                id = Convert.ToInt32(id.Value),
                colaboradorId = Convert.ToInt32(colaboradorId.Value),
            };
        }
    }
    public class User
    {
        public int id { get; set; }
        public int colaboradorId { get; set; }
    }
}