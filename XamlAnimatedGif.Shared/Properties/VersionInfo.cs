﻿#if(!SDKPROJECT)
using System.Reflection;
using XamlAnimatedGif.Properties;

[assembly: AssemblyVersion(VersionInfo.Version)]
[assembly: AssemblyFileVersion(VersionInfo.Version)]
[assembly: AssemblyInformationalVersion(VersionInfo.Version + VersionInfo.PreRelease)]

namespace XamlAnimatedGif.Properties
{
    internal static class VersionInfo
    {
        public const string Version = "1.2.2.0";
        public const string PreRelease = "";
    }
}
#endif
