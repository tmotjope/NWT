﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NWT.Data.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NWT.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to DELETE FROM [dbo].[EmployeeTerritories]
        ///DELETE FROM [dbo].[Territories]
        ///DELETE FROM [dbo].[Region]
        ///DELETE FROM [dbo].[Order Details]
        ///DELETE FROM [dbo].[Orders]
        ///DELETE FROM [dbo].[Employees]
        ///DELETE FROM [dbo].[Products]
        ///DELETE FROM [dbo].[Categories]
        ///DELETE FROM [dbo].[Shippers]
        ///DELETE FROM [dbo].[Suppliers]
        ///DELETE FROM [dbo].[Customers]
        ///.
        /// </summary>
        internal static string SeedData_Down {
            get {
                return ResourceManager.GetString("SeedData_Down", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (N&apos;ALFKI&apos;, N&apos;Alfreds Futterkiste&apos;, N&apos;Maria Anders&apos;, N&apos;Sales Representative&apos;, N&apos;Obere Str. 57&apos;, N&apos;Berlin&apos;, NULL, N&apos;12209&apos;, N&apos;Germany&apos;, N&apos;030-0074321&apos;, N&apos;030-0076545&apos;)
        ///INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (N&apos;ANATR&apos;, N&apos;Ana Tr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SeedData_Up {
            get {
                return ResourceManager.GetString("SeedData_Up", resourceCulture);
            }
        }
    }
}
