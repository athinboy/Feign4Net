using System.Collections.Generic;
using Lark.Core.Enum;

namespace Lark.Core
{
    public class DefaultConfig
    {
        public static string DefaultHttpMethod = "GET";

        public static List<string> SupportHttpMethod = new List<string> { "GET", "POST" };
        internal static bool HeaderUnique = true;

        internal static SerializeTypes DefaultSerilizeType = SerializeTypes.json;

        internal static HttpContentTypes DefaultHttpContentType = HttpContentTypes.json;
    }
}