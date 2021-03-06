﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("JsonTree")]
[assembly: AssemblyDescription("Inspect values in JSON strings with single line expressions and plain old CLR objects without using foreach/if to extract values from JSON. Extract the 42 from [\"first\",{\"aString\":\"HelloWorld\",\"aNumber\":42}] with C# expression: json.AsList[1].AsDictionary[\"aNumber\"].AsInt")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Heiner Wolf")]
[assembly: AssemblyProduct("JsonTree")]
[assembly: AssemblyCopyright("Copyright © 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("28c5705a-2f45-4657-8f8d-72c210986424")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.8.0")]
[assembly: AssemblyFileVersion("1.0.8.0")]
