using NUnit.Framework;
using NUnitLite;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        [Test]
        public void TestVergelijkStrings()
        {
            Assert.That(First.Program.VergelijkStrings("een", "twee"), Is.EqualTo("Verschillend"));
            Assert.That(First.Program.VergelijkStrings("een", "een"), Is.EqualTo("Identiek"));
            Assert.That(First.Program.VergelijkStrings("een", "Een"), Is.EqualTo("Verschil letters"));

        }

        [Test]
        public void TestZoekWoord()
        {
            Assert.That(First.Program.ZoekWoord("test", "Het woord test komt in deze zin."), Is.EqualTo(true));
            Assert.That(First.Program.ZoekWoord("test", "Het woord komt niet in de zin voor."), Is.EqualTo(false));

        }

        [Test]
        public void TestTelLetter()
        {
            Assert.That(First.Program.TelLetter('o', "Hoe hoog is de berg?"), Is.EqualTo(3));
            Assert.That(First.Program.TelLetter('o', "De weg is lang."), Is.EqualTo(0));
        }

        [Test]
        public void TestVeranderKlinkers()
        {
            Assert.That(First.Program.VeranderKlinkers("Dit is een testje."), Is.EqualTo("D*t *s **n t*stj*."));

        }

        [Test]
        public void TestTelKarakters()
        {
            Assert.That(First.Program.TelKarakters("     Een klavier is een invoerapparaat.  "), Is.EqualTo(34));

        }

        [Test]
        public void TestZoekLangsteWoord()
        {
            Assert.That(First.Program.ZoekLangsteWoord("Het woord toetsenbord is een lang woord."), Is.EqualTo("toetsenbord"));

        }

        [Test]
        public void TestControleerOndNr()
        {
            Assert.That(First.Program.ControleerOndNr("BE 0461.324.971"), Is.EqualTo(true));
            Assert.That(First.Program.ControleerOndNr("BE 0461.324.970"), Is.EqualTo(false));

        }
    }
}
