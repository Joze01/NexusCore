using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.BLL.Util
{
    public static class CoreConfiguration
    {
        public const string FieldSeparator = "|";
        public const string EncodeingCaracters = @"^~\&";
        public const string ApplicationName = "Diagnostika Hl7 Service";
        public const string NameSpaceId = "7";
        public const string UniversalIDd = "Diagnotika Capris";
        public const string ReceivingApplication = "SIAP";
        public const string ReceivingFacility = "MINSAL";
        public const string MessageCode = "OUL";
        public const string TriggerEvent = "R22";
        public const string ProcessingID = "D";
        public const string VersionId = "2.5.1";
        public const string AcceptAcknowledgemeType = "AL";
        public const string ApplicationAcknowledgmeType = "AL";
    }
}
