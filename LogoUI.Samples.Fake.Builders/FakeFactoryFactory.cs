using Attest.Fake.Core;
using Attest.Fake.Moq;

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
