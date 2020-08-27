using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;
using Feign.Core.Context;

namespace FeignCore.ValueBind
{
    internal class XmlContentBodyBind : BodyBind
    {
        internal override HttpContent Bindbody(RequestCreContext requestCreContext)
        {
            System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
            StringBuilder stringBuild = new StringBuilder();
            XmlWriter xmlWriter = new XmlTextWriter(new StringWriter(stringBuild));
            xmlDocument.WriteContentTo(xmlWriter);
            StringContent stringContent = new StringContent(stringBuild.ToString());
            return stringContent;
        }
    }
}