﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tabster.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StartupUpdate {
            get {
                return ((bool)(this["StartupUpdate"]));
            }
            set {
                this["StartupUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Maximized")]
        public global::System.Windows.Forms.FormWindowState ClientState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["ClientState"]));
            }
            set {
                this["ClientState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Top")]
        public global::System.Windows.Forms.DockStyle ToolbarDock {
            get {
                return ((global::System.Windows.Forms.DockStyle)(this["ToolbarDock"]));
            }
            set {
                this["ToolbarDock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024, 625")]
        public global::System.Drawing.Size ClientSize {
            get {
                return ((global::System.Drawing.Size)(this["ClientSize"]));
            }
            set {
                this["ClientSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Horizontal")]
        public global::Tabster.PreviewPanelOrientation SearchPreviewOrientation {
            get {
                return ((global::Tabster.PreviewPanelOrientation)(this["SearchPreviewOrientation"]));
            }
            set {
                this["SearchPreviewOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Horizontal")]
        public global::Tabster.PreviewPanelOrientation LibraryPreviewOrientation {
            get {
                return ((global::Tabster.PreviewPanelOrientation)(this["LibraryPreviewOrientation"]));
            }
            set {
                this["LibraryPreviewOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("365")]
        public int LibraryPreviewPanelDistance {
            get {
                return ((int)(this["LibraryPreviewPanelDistance"]));
            }
            set {
                this["LibraryPreviewPanelDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("365")]
        public int SearchPreviewPanelDistance {
            get {
                return ((int)(this["SearchPreviewPanelDistance"]));
            }
            set {
                this["SearchPreviewPanelDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyAddress {
            get {
                return ((string)(this["ProxyAddress"]));
            }
            set {
                this["ProxyAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyUsername {
            get {
                return ((string)(this["ProxyUsername"]));
            }
            set {
                this["ProxyUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyPassword {
            get {
                return ((string)(this["ProxyPassword"]));
            }
            set {
                this["ProxyPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public string ProxyConfig {
            get {
                return ((string)(this["ProxyConfig"]));
            }
            set {
                this["ProxyConfig"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n        <?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n        <ArrayOfString xmlns:x" +
            "si=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001" +
            "/XMLSchema\" />\r\n      ")]
        public global::System.Collections.Specialized.StringCollection DisabledPlugins {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DisabledPlugins"]));
            }
            set {
                this["DisabledPlugins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color PrintColor {
            get {
                return ((global::System.Drawing.Color)(this["PrintColor"]));
            }
            set {
                this["PrintColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PrintPageNumbers {
            get {
                return ((bool)(this["PrintPageNumbers"]));
            }
            set {
                this["PrintPageNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Tabster.LocalUtilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PrintTimestamp {
            get {
                return ((bool)(this["PrintTimestamp"]));
            }
            set {
                this["PrintTimestamp"] = value;
            }
        }
    }
}
