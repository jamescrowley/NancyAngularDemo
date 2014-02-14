using System;

namespace NancyAngularDemo.Web.Data
{
    public class NewsEntry
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
    }
}