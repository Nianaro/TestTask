using System;
using System.Linq;
using System.Reflection;

namespace Autotests
{
    public static class UrlBuilder
    {
        public static string GetUrl(Type pageType) =>
            pageType.GetCustomAttributes<PageUrlAttribute>().Select(a => a.Url).ToArray().First();
    }
}