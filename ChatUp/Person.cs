using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class Person
    {
        #region Properties to be continued
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string EmailAddress { get; set; }
        public string LinkedinProfile { get; set; }
        public string FacebookProfile { get; set; }
        public string InstagramProfile { get; set; }
        public string TwitterProfile { get; set; }

        #endregion

        public bool IsBlocked { get; set; } // bool is false by default
        public bool IsGhosted { get; set; }
    }
}
