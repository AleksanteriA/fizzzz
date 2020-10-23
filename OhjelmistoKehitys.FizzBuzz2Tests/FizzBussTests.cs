using NUnit.Framework;
using OhjelmistoKehitys.FizzBuzz2;

namespace OhjelmistoKehitys.FizzBuzz2Tests

{
    public class FizzBussTests
    {
        FizzBuzz _fizzBuzz = null;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void LuodaanFizzBussLuokka()
        {
            
            Assert.IsInstanceOf<FizzBuzz>(_fizzBuzz);
        }

        [Test]
        public void TulostaLukuKunSy�tteen�AnnettuYksi()
        {
            string vastaus = _fizzBuzz.Luku(1);

            Assert.AreEqual("1", vastaus);

        }


        [Test]
        public void TulostaLukuKunSy�tteen�AnnettuKaksi()
        {
            string vastaus = _fizzBuzz.Luku(2);

            Assert.AreEqual("2", vastaus);

        }



        //Jos luku on kolmella jaollinen, printtaa Fizz
        [Test]
        public void TulostaFizzJosLukuOnKolmellaJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(3);

            Assert.AreEqual("Fizz", vastaus);
        }

        // Jos luku on viidell� jaollinen, printtaa Buzz 
        public void TulostaBuzzJosLukuOnViidell�Jaollinen()
        {
            string vastaus = _fizzBuzz.Luku(5);

            Assert.AreEqual("Buzz", vastaus);
        }


        [Test]
        public void TulostaLukuKunSy�tteen�AnnettuKuusi()
        {
            string vastaus = _fizzBuzz.Luku(6);

            Assert.AreEqual("Fizz", vastaus);

        }

        // Jos luku on sek� kolmell� ett� viidell� jaollinen, printtaa FizzBuzz
        public void TulostaFizzBuzzJosLukuOnKolmellaJaViidell�Jaollinen()
        {
            string vastaus = _fizzBuzz.Luku(15);

            Assert.AreEqual("FizzBuzz", vastaus);
        }

    }
}