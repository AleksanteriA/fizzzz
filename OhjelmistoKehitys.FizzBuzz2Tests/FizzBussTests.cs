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
        public void TulostaLukuKunSyötteenäAnnettuYksi()
        {
            string vastaus = _fizzBuzz.Luku(1);

            Assert.AreEqual("1", vastaus);

        }


        [Test]
        public void TulostaLukuKunSyötteenäAnnettuKaksi()
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

        // Jos luku on viidellä jaollinen, printtaa Buzz 
        public void TulostaBuzzJosLukuOnViidelläJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(5);

            Assert.AreEqual("Buzz", vastaus);
        }


        [Test]
        public void TulostaLukuKunSyötteenäAnnettuKuusi()
        {
            string vastaus = _fizzBuzz.Luku(6);

            Assert.AreEqual("Fizz", vastaus);

        }

        // Jos luku on sekä kolmellä että viidellä jaollinen, printtaa FizzBuzz
        public void TulostaFizzBuzzJosLukuOnKolmellaJaViidelläJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(15);

            Assert.AreEqual("FizzBuzz", vastaus);
        }

    }
}