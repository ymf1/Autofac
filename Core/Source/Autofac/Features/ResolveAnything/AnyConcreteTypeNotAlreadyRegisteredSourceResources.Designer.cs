﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autofac.Features.ResolveAnything {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AnyConcreteTypeNotAlreadyRegisteredSourceResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AnyConcreteTypeNotAlreadyRegisteredSourceResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
#if !ASPNETCORE50
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSourceResourc" +
                            "es", typeof(AnyConcreteTypeNotAlreadyRegisteredSourceResources).GetTypeInfo().Assembly);
#else
                    //TODO: Removed namespace to work around https://github.com/aspnet/KRuntime/issues/738
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Autofac.AnyConcreteTypeNotAlreadyRegisteredSourceResourc" +
                            "es", typeof(AnyConcreteTypeNotAlreadyRegisteredSourceResources).GetTypeInfo().Assembly);
#endif
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Resolve Anything&quot; Support.
        /// </summary>
        internal static string AnyConcreteTypeNotAlreadyRegisteredSourceDescription {
            get {
                return ResourceManager.GetString("AnyConcreteTypeNotAlreadyRegisteredSourceDescription", resourceCulture);
            }
        }
    }
}
