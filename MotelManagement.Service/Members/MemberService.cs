using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotelManagement.Model.Models;
using MotelManagement.Data.Repository;
using MotelManagement.Data.Infrastructure;

namespace MotelManagement.Service.Members
{
    public class MemberService : IMemberService
    {
        private IMemberRepository _memberRepository;
        private IUnitOfWork _unitOfWork;

        public MemberService(IMemberRepository memberRepository, IUnitOfWork unitOfWork)
        {
            this._memberRepository = memberRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Member member)
        {
            _memberRepository.Add(member);
        }

        public void Delete(int id)
        {
            _memberRepository.Delete(id);
        }

        public IEnumerable<Member> GetAll()
        {
            return _memberRepository.GetAll(new string[] { "Personnel" });
        }

        public IEnumerable<Member> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Member GetById(int id)
        {
            return _memberRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Member member)
        {
            _memberRepository.Update(member);
        }
    }
}
