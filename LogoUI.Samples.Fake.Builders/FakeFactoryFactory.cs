using Solid.Fake.Core;
using Solid.Fake.Moq;

namespace LogoUI.Samples.Fake.Builders
{
    class FakeFactoryFactory
    {
        private static readonly IFakeFactory FakeFactory = new FakeFactory();

        internal static IFakeFactory CreateFakeFactory()
        {
            return FakeFactory;
        }
    }
}
