// Guids.cs
// MUST match guids.h
using System;

namespace Orchard.OrchardSeeds
{
    static class GuidList
    {
        public const string guidOrchardSeedsPkgString = "690a4473-ae14-43f9-93af-955b5614a779";
        public const string guidOrchardSeedsCmdSetString = "89001ba1-5046-4270-9449-9b8d72fb3f31";

        public static readonly Guid guidOrchardSeedsCmdSet = new Guid(guidOrchardSeedsCmdSetString);
    };
}