using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]

namespace Intent.Modules.IdentityServer4.X509CertSigning.Tests.GeneratedTemplates
{
    /// <summary>
    /// Convenient way to obtain X509 Certificates from various sources
    /// </summary>
    static class CertificateRepo
    {
        public static X509Certificate2 GetFromCertificateStore(
            string findType,
            string findValue,
            StoreName storeName = StoreName.My,
            StoreLocation storeLocation = StoreLocation.LocalMachine)
        {
            X509FindType parsedFindType;
            if (!Enum.TryParse(findType, out parsedFindType))
            {
                throw new ArgumentException($"Could not parse string '{findType}' for type '{nameof(X509FindType)}'", nameof(findType));
            }

            return GetFromCertificateStore(
                findValue: findValue,
                findType: parsedFindType,
                storeName: storeName,
                storeLocation: storeLocation);
        }

        public static X509Certificate2 GetFromCertificateStore(
            X509FindType findType,
            string findValue,
            StoreName storeName = StoreName.My,
            StoreLocation storeLocation = StoreLocation.LocalMachine)
        {
            var store = new X509Store(storeName, storeLocation);
            store.Open(OpenFlags.ReadOnly);

            var certs = store.Certificates.Find(findType, findValue, true);
            store.Close();

            if (certs.Count == 0)
            {
                throw new CertificateStoreException(
                    message: "Could not find any matching certificate",
                    findType: findType,
                    findValue: findValue,
                    storeName: storeName,
                    storeLocation: storeLocation);
            }

            if (certs.Count > 1)
            {
                throw new CertificateStoreException(
                    message: "Found more than one matching certificate",
                    findType: findType,
                    findValue: findValue,
                    storeName: storeName,
                    storeLocation: storeLocation);
            }

            return certs[0];
        }

        public static X509Certificate2 GetEmbeddedCertificate(string resourceName, string password = null)
        {
            var assembly = typeof(CertificateRepo).Assembly;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                return new X509Certificate2(ReadStream(stream), password);
            }
        }

        public static X509Certificate2 GetFromFile(string fileName, string password = null)
        {
            return new X509Certificate2(fileName, password);
        }

        private static byte[] ReadStream(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }

    public class CertificateStoreException : Exception
    {
        public CertificateStoreException() : base()
        {
        }

        public CertificateStoreException(string message) : base(message)
        {
        }

        public CertificateStoreException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public CertificateStoreException(
            string message,
            X509FindType findType,
            string findValue,
            StoreName storeName,
            StoreLocation storeLocation)
            : base(message)
        {
            FindType = findType;
            FindValue = findValue;
            StoreName = storeName;
            StoreLocation = storeLocation;
        }

        public X509FindType FindType { get; }
        public string FindValue { get; }
        public StoreName StoreName { get; }
        public StoreLocation StoreLocation { get; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FindValue))
            {
                return base.ToString();
            }

            return $"{Message}{Environment.NewLine}" +
                $"{nameof(FindType)} = {FindType}{Environment.NewLine}" +
                $"{nameof(FindValue)} = {FindValue}{Environment.NewLine}" +
                $"{nameof(StoreName)} = {StoreName}{Environment.NewLine}" +
                $"{nameof(StoreLocation)} = {StoreLocation}{Environment.NewLine}" +
                StackTrace;
        }
    }
}