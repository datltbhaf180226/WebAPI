using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoAPI.BizLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoAPI
{
    public class MemberHandler : IMemberHandler
    {

        private List<Member> _listMembers;

        public MemberHandler()
        {
            SeedingData();
        }

        public List<Member> AddNewMember(Member member)
        {
            _listMembers.Add(member);
            return _listMembers;
        }

        public List<Member> DeleteMember(string name)
        {
            var _name = _listMembers.Where(x => x.FirstName == name).FirstOrDefault();
            _listMembers.Remove(_name);
            return _listMembers;
        }

        public List<Member> FilterMemberByBirthPlace(string place)
        {
            var result = _listMembers.Where(x => x.BirthPlace == place).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYear(int year)
        {
            var result = _listMembers.Where(x => x.Dob.Year == year).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYearGreaterThan(int year)
        {
            var result = _listMembers.Where(x => x.Dob.Year > year).ToList();
            return result;
        }

        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            var result = _listMembers.Where(x => x.Dob.Year < year).ToList();
            return result;
        }

        public List<Member> FilterMemberByGender(string gender)
        {
            var result = _listMembers.Where(x => x.Gender == gender).ToList();
            return result;
        }

        public List<string> GetMemberWithFullNameOnly()
        {
            var result = _listMembers.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            return result;
        }

        public List<Member> GetMemberIsGraduated()
        {
            var result = _listMembers.Where(x => x.IsGraduated == true).ToList();
            return result;
        }

        public void OnGet()
        {

        }

        public Member ReturnTheOldestMember()
        {
            var minDob = _listMembers.Min(x => x.Dob);
            var result = _listMembers.FirstOrDefault(x => x.Dob == minDob);
            return result;
        }


        private void SeedingData()
        {
            _listMembers = new List<Member>
            {
                new Member
                {
                    FirstName = "Dat",
                    LastName = "Le",
                    BirthPlace = "Ha Noi",
                    Dob = DateTime.Now.AddYears(-21),
                    Gender = "Male",
                    IsGraduated = false,
                    Phone = "0123456789",
                    StartDate = DateTime.Now.AddYears(-1),
                    EndDate = DateTime.Now.AddYears(5)
                },
                 new Member
                {
                    FirstName = "Son",
                    LastName = "Vu",
                    BirthPlace = "Nam Dinh",
                    Dob = DateTime.Now.AddYears(-24),
                    Gender = "Male",
                    IsGraduated = true,
                    Phone = "0123456789",
                    StartDate = DateTime.Now.AddYears(-2),
                    EndDate = DateTime.Now.AddYears(5)
                },
                  new Member
                {
                    FirstName = "Quang",
                    LastName = "Nguyen",
                    BirthPlace = "Ha Noi",
                    Dob = DateTime.Now.AddYears(-21),
                    Gender = "Female",
                    IsGraduated = false,
                    Phone = "0123456789",
                    StartDate = DateTime.Now.AddYears(-1),
                    EndDate = DateTime.Now.AddYears(5)
                },
                   new Member
                {
                    FirstName = "Long",
                    LastName = "Nguyen",
                    BirthPlace = "Bac Giang",
                    Dob = DateTime.Now.AddYears(-18),
                    Gender = "Male",
                    IsGraduated = false,
                    Phone = "0123456789",
                    StartDate = DateTime.Now.AddYears(-1),
                    EndDate = DateTime.Now.AddYears(5)
                },
                    new Member
                {
                    FirstName = "Phuong",
                    LastName = "Vu",
                    BirthPlace = "Ha Noi",
                    Dob = DateTime.Now.AddYears(-21),
                    Gender = "Female",
                    IsGraduated = true,
                    Phone = "0123456789",
                    StartDate = DateTime.Now.AddYears(-1),
                    EndDate = DateTime.Now.AddYears(5)
                },
            };
        }
    }
}