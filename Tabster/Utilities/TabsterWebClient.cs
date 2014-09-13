﻿#region

using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Tabster.Utilities
{
    public class TabsterWebClient : WebClient
    {
        public TabsterWebClient(IWebProxy proxy = null, Version version = null)
        {
            Proxy = proxy;
            Encoding = Encoding.UTF8;

            var userAgent = "Tabster Web Client";

            if (version != null)
                userAgent += " " + version.ToShortString();

            Headers.Add("user-agent", userAgent);
        }
    }
}