using MotelManagement.Data.Infrastructure;
using MotelManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Data.Repository
{
    public interface IMemberRepository : IRepository<Member>
    {
        
    }
    public class MemberRepository: RepositoryBase<Member>,IMemberRepository
    {
        public MemberRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
