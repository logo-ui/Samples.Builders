using System;
using System.Collections.Generic;
using System.Threading;
using Attest.Fake.Builders;
using LogoUI.Samples.Client.Data.Contracts;
using LogoUI.Samples.Client.Data.Providers.Contracts;
using LogoUI.Samples.Fake.Builders;

namespace LogoUI.Samples.Client.Data.Providers.Fake
{
    class FakeComplianceProvider : FakeProviderBase<ComplianceProviderBuilder,IComplianceProvider>, IComplianceProvider
    {
        private const int ComplianceRecordCount = 100;

        public IEnumerable<ComplianceRecordDto> GetComplianceRecords(DateTime? startTime, DateTime? endTime)
        {
            var provider = GetService(ComplianceProviderBuilder.CreateBuilder,
                t => t.WithComplianceRecord(ComplianceRecordCount));
            foreach (var complianceRecord in provider.GetComplianceRecords(startTime, endTime))
            {
                Thread.Sleep(5);
                yield return complianceRecord;                
            }           
        }
    }
}
