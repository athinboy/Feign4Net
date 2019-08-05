﻿using Feign.Core.ProxyFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feign.Core.Context
{
    internal class RequestCreContext
    {
        public InterfaceWrapContext InfaceContext { get; set; }
        public MethodWrapContext MethodWrap { get; set; }

        public WrapBase WrapInstance { get; set; }


        private string queryString = "";

        public string URL
        {
            get
            {
                return this.WrapInstance.Url + this.MethodWrap.Url;
            }
            private set
            {
            }
        }

        public System.Net.Http.HttpMethod HttpMethod { get; set; } = new System.Net.Http.HttpMethod("GET");



    }
}
