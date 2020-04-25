using Feign.Core.ProxyFactory;
using NUnit.Framework;
using TestInterface;
using System;
using Feign.Core;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Net.Http;

namespace TestClient.Test.AttributeTest
{
    public class QueryStringAttribureTest : TestBase
    {

        [SetUp]
        public void BaseSetup1()
        {
            Feign.Core.InternalConfig.NotRequest = true;
        }


        [NUnit.Framework.Test]
        public void Test()
        {
            IStudentService student = Feign.Core.Feign.Wrap<IStudentService>("http://localhost:6346");
            student.QueryEmpty();
            WrapBase wrap = (WrapBase)student;
            HttpRequestHeaders HttpRequestHeaders = wrap.MyHttpRequestMessagea.Headers;
            HttpContent httpContent = wrap.MyHttpRequestMessagea.Content;
 



        }

    }
}