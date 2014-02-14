using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Security;
using NancyAngularDemo.Web.Data;

namespace NancyAngularDemo.Web.Api
{
    public class NewsModule : NancyModule
    {
        readonly INewsData _newsData;

        public NewsModule(INewsData newsData) //: base("/api/news")
        {
            _newsData = newsData;
            this.RequiresAuthentication();

            Get["/api/news"] = _ => View["News"];
                //Negotiate
                //.WithModel()
                //.WithView("News");
                //Response.AsJson();
        }
    }

}