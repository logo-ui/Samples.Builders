using System;
using System.Collections.Generic;
using LogoUI.Samples.Client.Data.Contracts;
using LogoUI.Samples.Client.Data.Providers.Contracts;
using Solid.Fake.Builders;
using Solid.Fake.Moq;

namespace LogoUI.Samples.Fake.Builders
{
    public class ComplianceProviderBuilder : FakeBuilderBase<IComplianceProvider>
    {
        private static readonly string[] AppNames =
        {
            "Security Update for Windows",
            "Skype",
            "TeamViewer",
            "USB Removable Storage",
            "WebEx",
            "Windows Live Messenger",
            "Windows Messenger",
            "WinPcap",
            "WinSCP",
            "Wireshark",
            "Google Talk",
        };

        Random _random = new Random();

        private int _complianceRecordCount;

        private ComplianceProviderBuilder() : base(FakeFactoryFactory.CreateFakeFactory())
        {
            
        }

        public static ComplianceProviderBuilder CreateBuilder()
        {
            return new ComplianceProviderBuilder();
        }

        public ComplianceProviderBuilder WithComplianceRecord()
        {
            _complianceRecordCount++;
            return this;
        }

        public ComplianceProviderBuilder WithComplianceRecord(int numberOfComplianceRecordsToAdd)
        {
            _complianceRecordCount+=numberOfComplianceRecordsToAdd;
            return this;
        }

        protected override void SetupFake()
        {
            FakeService.SetupWithResult(t => t.GetComplianceRecords(It.IsAny<DateTime?>(), It.IsAny<DateTime?>()),
                GenerateComplianceRecords());
        }

        private IEnumerable<ComplianceRecordDto> GenerateComplianceRecords()
        {
            for (int i = 0; i < _complianceRecordCount; i++)
            {
                yield return GenerateComplianceRecord(_random, i);
            }
        }

        private static ComplianceRecordDto GenerateComplianceRecord(Random rnd, int index)
        {
            byte hostIndex = (byte)rnd.Next(1, 4);

            var result = new ComplianceRecordDto
            {
                LastDate = new DateTime(2012, 1, 1) + new TimeSpan(rnd.Next(0, 100000000) * 1000),
                Host = "HOST" + hostIndex,
                IpAddress = "192.168.0." + hostIndex,
                Object = AppNames[rnd.Next(AppNames.Length)],
                Status = rnd.Next(2) == 0 ? "Installed" : "NotInstalled",
                Information = "Record N " + (index + 1)
            };

            return result;
        }
    }
}
