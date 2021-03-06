﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogImporter.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LogImporter.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[#w3clog_staging]
        ///(
        ///    [RowId] bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,
        ///    [LogFilename] varchar(255) NOT NULL,
        ///    [LogRow] int NOT NULL,
        ///    [date] date NULL,
        ///    [time] datetime NULL,
        ///    [c-ip] varchar(50) NULL,
        ///    [cs-username] varchar(255) NULL,
        ///    [s-sitename] varchar(255) NULL,
        ///    [s-computername] varchar(255) NOT NULL,
        ///    [s-ip] varchar(50) NULL,
        ///    [s-port] varchar(255) NULL,
        ///    [cs-method] varchar(255) NULL,
        ///    [cs-uri-stem] varchar(2048) NULL,
        ///    [cs [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateStagingTable {
            get {
                return ResourceManager.GetString("CreateStagingTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE
        ///    s
        ///FROM
        ///    [#w3clog_staging] s
        ///INNER JOIN
        ///    dbo.[w3clog] p
        ///  ON
        ///    s.[LogFilename] = p.[LogFilename]
        ///  AND
        ///    s.[LogRow] = p.[LogRow]
        ///
        ///DELETE FROM
        ///    [#w3clog_staging]
        ///WHERE
        ///    ROW_NUMBER() OVER (ORDER BY [RowId] PARTITION BY [LogFilename], [LogRow]) &gt; 1
        ///
        ///INSERT INTO
        ///    [w3clog]
        ///    (
        ///        [LogFilename], [LogRow], [date],
        ///        [time], [c-ip], [cs-username],
        ///        [s-sitename], [s-computername], [s-ip],
        ///        [s-port], [cs-method], [cs-uri-stem],
        ///        [cs [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MergeFromStaging {
            get {
                return ResourceManager.GetString("MergeFromStaging", resourceCulture);
            }
        }
    }
}
