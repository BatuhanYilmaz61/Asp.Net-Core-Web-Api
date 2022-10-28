using Data.InterFaceM;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data.Repository
{
    public class MemberRepository : IMembers
    { 
        public List<Member> GetAllMember()
        {
            using (var _memberDb = new MemberDbContext())
            {
                return _memberDb.Members.ToList();
            }
        }
        public Member CreateMember(Member member)
        {

            using (var _memberDb = new MemberDbContext())
            {
                _memberDb.Members.Add(member);

                _memberDb.SaveChanges();


                return member;

            }
        }
        public void DeleteMember(int ID)
        {
            using (var _memberDb = new MemberDbContext())
            {
                var DeleteMember = GetMemberById(ID);
                _memberDb.Members.Remove(DeleteMember);
                _memberDb.SaveChanges();

            }
        }
        public Member GetMemberById(int ID)
        {
            using (var _memberDb = new MemberDbContext())
            {
                return _memberDb.Members.Find(ID);
            }
        }

        public Member UpdateMember(Member member)
        {

            using (var _memberDb = new MemberDbContext())
            {
                _memberDb.Members.Update(member);
                _memberDb.SaveChanges();
                return member;

            }


        }
    }
}
