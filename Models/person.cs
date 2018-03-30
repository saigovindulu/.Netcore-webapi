using System;

namespace PersonApi.Models
{
    public class person
    {
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName{get;set;}
        public DateTime StartDate{get;set;}
        public int Rating {get;set;}
        public override string ToString()
        {
return string.Format("{0} {1}",FirstName,LastName);
        }
    }
}