using NUnit.Framework;

namespace LiskovSubstitutionPrinciple {
    public class CounterTests {

        private ICounter GetCounter() {
            return new GoodCounter();
        }

        [Test]
        public void GoodCounterConstructor()
        {
            ICounter counter = GetCounter();

            Assert.That(counter.Count, Is.EqualTo(0));
        }

        [Test]
        public void GoodCounterSetInitialCount() {
            ICounter counter = GetCounter();
            counter.InitialCount(10);
            Assert.That(counter.Count, Is.EqualTo(10));
        }

        [Test]
        public void GoodCounterSetIncreaseDecrease() {
            ICounter counter = GetCounter();
            counter.Increase();
            counter.Increase();
            counter.Increase();
            counter.Decrease();
            Assert.That(counter.Count, Is.EqualTo(2));
        }
    }
    public class GoodCounter : ICounter {
        private int _Count;

        public GoodCounter() {
            _Count = 0;
        }

        public virtual void InitialCount(int count) {
            _Count = count;
        }
        public void Increase() {
            _Count++;
        }
        public void Decrease() {
            _Count--;
        }

        public int Count {
            get { return (_Count); }
        }
    }

    public class BadCounter : GoodCounter {
        private int _Count;

        public BadCounter() {
            _Count = 10;
        }

        public override void InitialCount(int count) {
            _Count = 0;
        }
    }


    public interface ICounter {
        void InitialCount(int count);
        void Increase();
        void Decrease();
        int Count { get; }
    }
}
