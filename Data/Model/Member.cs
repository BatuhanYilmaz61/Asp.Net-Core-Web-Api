using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InterFaceM;

using FluentValidation;


namespace Data.Model
{
    public class Member
    {
        public int ID { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }

    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.ID).NotNull();
            RuleFor(x => x.Name).Length(0, 30);
            RuleFor(x => x.Email).NotNull();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Age).InclusiveBetween(0, 70);
        }
    }
}
