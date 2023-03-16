using System;

namespace Autotests
{
    public class PageUrlAttribute : Attribute
    {
        public string Url { get; }
        public PageUrlAttribute(string url) => Url = url;

    }
}