﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Peachpie.Library.Network {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Peachpie.Library.Network.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The easy handle is already added to a multi handle.
        /// </summary>
        internal static string CURLM_ADDED_ALREADY {
            get {
                return ResourceManager.GetString("CURLM_ADDED_ALREADY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid easy handle.
        /// </summary>
        internal static string CURLM_BAD_EASY_HANDLE {
            get {
                return ResourceManager.GetString("CURLM_BAD_EASY_HANDLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid multi handle.
        /// </summary>
        internal static string CURLM_BAD_HANDLE {
            get {
                return ResourceManager.GetString("CURLM_BAD_HANDLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please call curl_multi_perform() soon.
        /// </summary>
        internal static string CURLM_CALL_MULTI_PERFORM {
            get {
                return ResourceManager.GetString("CURLM_CALL_MULTI_PERFORM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error.
        /// </summary>
        internal static string CURLM_INTERNAL_ERROR {
            get {
                return ResourceManager.GetString("CURLM_INTERNAL_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No error.
        /// </summary>
        internal static string CURLM_OK {
            get {
                return ResourceManager.GetString("CURLM_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Out of memory.
        /// </summary>
        internal static string CURLM_OUT_OF_MEMORY {
            get {
                return ResourceManager.GetString("CURLM_OUT_OF_MEMORY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error.
        /// </summary>
        internal static string UnknownError {
            get {
                return ResourceManager.GetString("UnknownError", resourceCulture);
            }
        }
    }
}
