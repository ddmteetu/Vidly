using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        //Associate `Customer` Class with `MembershipType` with the help of a navigational property, `MembershipType`
        public MembershipType MembershipType { get; set; }
        //`Foreign Key` to the `MembershipType` Table
        public byte MembershipTypeId { get; set; }
    }
}