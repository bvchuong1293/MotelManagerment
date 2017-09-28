using MotelManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Service.Members
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(int id);
        IEnumerable<Member> GetAll();
        IEnumerable<Member> GetAllPaging(int page, int pageSize, out int totalRow);
        Member GetById(int id);
        void SaveChanges();
    }
}
