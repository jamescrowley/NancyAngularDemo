using System;
using System.Collections.Generic;

namespace NancyAngularDemo.Web.Data
{
    public interface INewsData
    {
        ICollection<NewsEntry> GetAll();
        NewsEntry Get(Guid id);
        void Update(NewsEntry account);
        void Delete(Guid id);
        void Add(NewsEntry newsEntry);
    }
}