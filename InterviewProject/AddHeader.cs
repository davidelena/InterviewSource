using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public class AddHeader
    {
        public AddHeader()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Password = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
