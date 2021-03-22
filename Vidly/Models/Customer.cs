﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        //Associate `Customer` Class with `MembershipType` with the help of a navigational property, `MembershipType`
        public MembershipType MembershipType { get; set; }
        //`Foreign Key` to the `MembershipType` Table
        public byte MembershipTypeId { get; set; }
    }
}