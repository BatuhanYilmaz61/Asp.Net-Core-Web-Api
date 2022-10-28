using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.InterFaceM
{
    public interface IMembers
    {
        List<Member> GetAllMember();
        Member GetMemberById(int ID);

        Member CreateMember(Member member);

        Member UpdateMember(Member member);

        void DeleteMember(int ID);



    }
}
