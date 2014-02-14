using System;
using System.Collections.Generic;
using System.Linq;

namespace NancyAngularDemo.Web.Data
{
    public class NewsData : INewsData
    {
        private static readonly IDictionary<Guid, NewsEntry> News = new Dictionary<Guid, NewsEntry>();

        static NewsData()
        {
            var r = new Random();
            News = Enumerable.Range(0, 10).Select(i => new NewsEntry
            {
                Id = Guid.NewGuid(),
                Title = string.Format("News Entry #{0}", i),
            }).ToDictionary(t=>t.Id,t=>t);
        }

        public ICollection<NewsEntry> GetAll()
        {
            return News.Values;
        }

        public NewsEntry Get(Guid id)
        {
            return News[id];
        }

        public void Update(NewsEntry account)
        {
            NewsEntry newsEntry = News[account.Id];
            newsEntry.Title = account.Title;
        }

        public void Delete(Guid id)
        {
            News.Remove(id);
        }

        public void Add(NewsEntry newsEntry)
        {
            News.Add(newsEntry.Id, newsEntry);
        }
    }
}