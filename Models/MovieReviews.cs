using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApplication.Models
{
    public class MovieReviews
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerComments { get; set; }
        public int ReviewerRatings { get; set; }
    }
}