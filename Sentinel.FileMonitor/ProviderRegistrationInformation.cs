namespace Sentinel.FileMonitor
{
    using System;

    using Interfaces.Providers;

    public class ProviderRegistrationInformation : IProviderRegistrationRecord
    {
        public ProviderRegistrationInformation(IProviderInfo providerInfo)
        {
            Info = providerInfo;
        }

        public Guid Identifier
        {
            get
            {
                return Info.Identifier;
            }
        }

        public IProviderInfo Info { get; private set; }

        public Type Settings
        {
            get
            {
                return typeof(FileMonitorProviderPage);
            }
        }

        public Type Implementor
        {
            get
            {
                return typeof(FileMonitoringProvider);
            }
        }
    }
}