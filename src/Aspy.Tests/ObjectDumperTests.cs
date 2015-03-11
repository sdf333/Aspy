
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using ByteCarrot.Aspy.Infrastructure;
using ByteCarrot.Aspy.Tree;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace ByteCarrot.Aspy.Tests
{
    public class ObjectDumperTests : TestFixture
    {
        [Test]
        public void A()
        {
            var t = new object().GetType();
            var s2 = new JavaScriptSerializer().Serialize(t);
            Assert.IsNull(s2);
        }
    }
}
