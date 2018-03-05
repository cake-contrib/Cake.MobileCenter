using Cake.MobileCenter;
using NUnit.Framework;
using System;

namespace Cake.MobilityCenter.Tests.Apps.Create
{
    [TestFixture]
    public class MobileCenter
    {
        [Test]
        public void WhenTokenAndPlatformAreSet_CommandLineIsCorrect()
        {
            var fixture = new MobileCenterAppsCreateFixture
            {
                Settings = new MobileCenterAppsCreateSettings { Platform = "x86", Token = "AlfaBeta" }
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("apps create --platform \"x86\" --token \"AlfaBeta\""));
        }
    }
}
