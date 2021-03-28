using System;
using System.Collections.Generic;
using demoAPI.BizLogic;


namespace demoAPI.BizLogic
{
    public interface IMemberHandler
    {
        List<Member> FilterMemberByGender(string gender);

        Member ReturnTheOldestMember();

        List<string> GetMemberWithFullNameOnly();

        List<Member> FilterMemberByBirthYear(int year);

        List<Member> FilterMemberByBirthYearLessThan(int year);

        List<Member> FilterMemberByBirthYearGreaterThan(int year);
        
        List<Member> FilterMemberByBirthPlace(string place);

        List<Member> GetMemberIsGraduated();

        List<Member> AddNewMember(Member member);

        List<Member> DeleteMember(string name);
    }
}