using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    internal static class ApplicationLicense
    {
        internal const string proKey = "3875A3E8FDDB6184EF345BBF571F6";
        internal const string trialKey = "5892BA656E66E2D6DEFA97E173DBD";
        public enum LicenseTypes
        {
            Common,
            Trial,
            Pro
        }

        static LicenseTypes _currentLicense = LicenseTypes.Common;

        public static LicenseTypes License
        {
            get => _currentLicense;
        }

        internal static void PrintLicense()
        {
            switch (License)
            {
                case LicenseTypes.Trial:
                    Console.WriteLine("Триальний режим");
                    break;
                case LicenseTypes.Pro:
                    Console.WriteLine("Платна версiя");
                    break;
                default:
                    Console.WriteLine("Безкоштовна версiя");
                    break;
            }
        }

        internal static void AllowTrial()
        {
            Console.Title = "Триальний режим";
            _currentLicense = LicenseTypes.Trial;
            PrintLicense();
        }
        internal static void AllowCommon()
        {
            Console.Title = "Безкоштовна версiя";
            _currentLicense = LicenseTypes.Common;
            PrintLicense();
        }
        internal static void AllowPro()
        {
            Console.Title = "Платна версiя";
            _currentLicense = LicenseTypes.Pro;
            PrintLicense();
        }
    }
}
