﻿using System;
using System.Collections.Specialized;
using System.Net;

namespace Nock.net
{

    internal class NockedRequest
    {
        public NockedRequest(string url)
        {
            Url = url;
        }

        public Method Method { get; internal set; }
        public string Url { get; internal set; }
        public string Path { get; internal set; }
        public string Response { get; internal set; }
        public HttpStatusCode StatusCode { get; internal set; }
        public string Body { get; internal set; }
        public BodyMatcher BodyMatcher { get; internal set; }
        public Func<string, bool> BodyMatcherString { get; internal set; }
        public Type BodyMatcherType { get; internal set; }
        public object BodyMatcherFunc { get; internal set; }
        public HeaderMatcher HeaderMatcher { get; internal set; }
        public NameValueCollection RequestHeaders { get; internal set; }
        public Func<NameValueCollection, bool> RequestHeaderMatcher { get; internal set; }
        public NameValueCollection ResponseHeaders { get; internal set; }
        public Func<string, NameValueCollection, string, WebResponse> ResponseCreator { get; internal set; }
        public bool IsDone { get; internal set; }
        public int Times { get; internal set; }
        public Action<string> Logger { get; internal set; }
        
    }
}
