using Business.InterfaceB;
using Data.InterFaceM;
using Data.Model;
using Data.Repository;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.concrete
{
    public class MemberMenager : IMemberService

    {
        private IMembers _member;
        public MemberMenager(IMembers members)
        {
            _member = members;
        }
        public Member CreateMember(Member member)
        {
            MemberValidator Cmembervalidator = new MemberValidator();
            ValidationResult result = Cmembervalidator.Validate(member);
            var CMember = GetMemberById(member.ID);

            if (CMember == null)
            {
                if (result.IsValid) { return _member.CreateMember(member); }
                else
                {
                    throw new Exception("Hatali giriş");
                }

            }
            else

                throw new Exception("Farkli ID deneyin");
        }
        public void DeleteMember(int ID)
        {
            var DMember = GetMemberById(ID);
            if (DMember != null)
            {
                _member.DeleteMember(ID);

            }
            else
            {
                throw new Exception("kullanici yok");
            }
        }
        public List<Member> GetAllMembers()
        {
            return _member.GetAllMember();
        }
        public Member GetMemberById(int ID)
        {

            return _member.GetMemberById(ID);
        }

        public Member UpdateMember(Member member)
        {
            MemberValidator memberValidator = new MemberValidator();
            ValidationResult result = memberValidator.Validate(member);
            var SMember = GetMemberById(member.ID);
            if (SMember != null)
            {
                if (result.IsValid) { return _member.UpdateMember(member); }
                else
                {
                    throw new Exception("Hatali giriş");
                }

            }
            else

                throw new Exception("Kullanici yok");
        }
    }
}
