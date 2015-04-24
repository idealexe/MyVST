using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle("CoreTweet")]
[assembly: AssemblyDescription("Yet Another .NET Twitter Library")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCompany("CoreTweet Development Team")]
[assembly: AssemblyProduct("CoreTweet")]
[assembly: AssemblyCopyright("(c) 2014 lambdalice, karno")]
[assembly: AssemblyTrademark("")]

[assembly: InternalsVisibleTo("CoreTweet.Streaming.Reactive")]
#if DEBUG
[assembly: InternalsVisibleTo("CoreTweetDebug")]
#endif

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

