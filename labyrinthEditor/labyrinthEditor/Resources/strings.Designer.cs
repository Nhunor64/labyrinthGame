//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labyrinthEditor.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    ///   This class was generated by MSBuild using the GenerateResource task.
    ///   To add or remove a member, edit your .resx file then rerun MSBuild.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "15.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("labyrinthEditor.Resources.strings", typeof(strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change language.
        /// </summary>
        public static string ChangeLanguage {
            get {
                return ResourceManager.GetString("ChangeLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit from the map editor.
        /// </summary>
        public static string ExitMenu {
            get {
                return ResourceManager.GetString("ExitMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new map.
        /// </summary>
        public static string MenuItemCreateMap {
            get {
                return ResourceManager.GetString("MenuItemCreateMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load map file into the editor.
        /// </summary>
        public static string MenuItemLoadMap {
            get {
                return ResourceManager.GetString("MenuItemLoadMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Main menu.
        /// </summary>
        public static string MenuTitle {
            get {
                return ResourceManager.GetString("MenuTitle", resourceCulture);
            }
        }
    }
}
