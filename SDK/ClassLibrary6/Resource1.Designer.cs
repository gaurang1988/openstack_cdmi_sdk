﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObjectStoreSDK {
    using System;
    
    
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
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ObjectStoreSDK.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to CreateAccountHTTPRequest.
        /// </summary>
        internal static string AccountRequest {
            get {
                return ResourceManager.GetString("AccountRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateAuthHTTPRequest.
        /// </summary>
        internal static string AuthRequest {
            get {
                return ResourceManager.GetString("AuthRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container does not exist therefore cannot be deleted.
        /// </summary>
        internal static string CantDeleteContainer {
            get {
                return ResourceManager.GetString("CantDeleteContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object does not exist therefore cannot be deleted.
        /// </summary>
        internal static string CantDeleteObject {
            get {
                return ResourceManager.GetString("CantDeleteObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container already exists.
        /// </summary>
        internal static string ContainerExists {
            get {
                return ResourceManager.GetString("ContainerExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateContainerHTTPRequest.
        /// </summary>
        internal static string ContainerRequest {
            get {
                return ResourceManager.GetString("ContainerRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Child container does not exist.
        /// </summary>
        internal static string NoChild {
            get {
                return ResourceManager.GetString("NoChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container does not exist.
        /// </summary>
        internal static string NoContainer {
            get {
                return ResourceManager.GetString("NoContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object does not exist.
        /// </summary>
        internal static string NoObject {
            get {
                return ResourceManager.GetString("NoObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateObjectHTTPRequest.
        /// </summary>
        internal static string ObjectRequest {
            get {
                return ResourceManager.GetString("ObjectRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to overwrite existing child container? (y/n).
        /// </summary>
        internal static string OverwriteContainer {
            get {
                return ResourceManager.GetString("OverwriteContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to overwrite existing object: y/n.
        /// </summary>
        internal static string OverwriteObject {
            get {
                return ResourceManager.GetString("OverwriteObject", resourceCulture);
            }
        }
    }
}