﻿using Feign.Core.Attributes;
using Feign.Core.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Feign.Core.Context
{
    internal class ParameterWrapContext
    {
        public List<FeignAttribute> MyFeignAttributes { get; set; } = new List<FeignAttribute>();

        public ParameterInfo Parameter { get; set; }

        public bool JsonSerialize { get; set; } = true;

        public bool XmlSerialize { get; set; } = false;

        public bool IsBody { get; set; } = false;

        public bool IsQueryStr { get; set; } = true;

        public string Name { get; set; } = string.Empty;

        private ParameterWrapContext()
        {

        }
        public ParameterWrapContext(ParameterInfo parameter) : this()
        {
            this.Parameter = parameter;
        }


        internal string Serial(MethodWrapContext methodWrapContext, ParameterInfo parameterInfo, object value)
        {

            if (value == null)
            {
                return string.Empty;
            }
            Type type = value.GetType();
            if (type.IsValueType)
            {
                return value.ToString();
            }

            if (this.XmlSerialize)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                StringBuilder stringBuilder = new StringBuilder();
                StringWriter stringWriter = new StringWriter(stringBuilder);
                xmlSerializer.Serialize(stringWriter, value);
                return stringBuilder.ToString();
            }
            if (this.JsonSerialize)
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(value);
            }
            return value.ToString();



        }


    }
}