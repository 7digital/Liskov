using NUnit.Framework;

namespace LiskovSubstitutionPrinciple {

    public class _7digitalExample {

        [Test]
        public void Is_a_release_a_product()
        {
            var expectedPrice = 9.99M;
            var album = new Release(expectedPrice);
            Assert.That(album.Price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Is_a_single_a_product() {
            var expectedPrice = 0.99M;
            var single = new Single(expectedPrice);
            Assert.That(single.Price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Is_a_smart_bundle_a_product() {
            var expectedPrice = 8.99M;
            var smartBundle = new SmartBundle(expectedPrice);
            Assert.That(smartBundle.Price, Is.EqualTo(expectedPrice));
        }
    
    }


    class product
    {
        public decimal Price { get; set; }

        public product(decimal salePrice)
        {
            Price = salePrice;
        }

        public string Name { get; set; }
      
        public decimal SmartBundlePrice { get; set; }

    }

    class Single : product {
        public Single(decimal salePrice) : base(salePrice)
        {
        }
    }
    
    class Release : product
    {
        public Release(decimal salePrice) : base(salePrice)
        {
        }
    }

    class SmartBundle : product
    {
        public decimal SmartBundlePrice { get; set; }

        public SmartBundle(decimal salePrice) : base(salePrice)
        {
            Price = 0;
            SmartBundlePrice = salePrice;
        }



    }




}
