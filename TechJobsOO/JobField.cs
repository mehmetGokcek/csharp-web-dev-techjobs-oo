using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Value { get; set; }


        public JobField() 
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value)
        {
            if (value.Length == 0)
            {
                Value = "Data not available";
            }

            else
            {
                Value = value;
            }
        }


        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }




    }

}
