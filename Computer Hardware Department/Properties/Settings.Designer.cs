﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computer_Hardware_Department.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\БД Отдел комп. ком" +
            "плектующих.accdb\"")]
        public string БД_Отдел_комп__комплектующихConnectionString {
            get {
                return ((string)(this["БД_Отдел_комп__комплектующихConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\БД\\БД Лаба 2 - MS SQL Ser" +
            "ver\\Computer Hardware Department\\Computer Hardware Department\\Computer Hardware " +
            "Department.mdf\";Integrated Security=True")]
        public string Computer_Hardware_DepartmentConnectionString {
            get {
                return ((string)(this["Computer_Hardware_DepartmentConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"E:\\БД\\БД Лаба 2 - MS SQL Server\\Com" +
            "puter Hardware Department\\Computer Hardware Department\\БД Отдел комп. комплектую" +
            "щих.mdb\"")]
        public string БД_Отдел_комп__комплектующихConnectionString1 {
            get {
                return ((string)(this["БД_Отдел_комп__комплектующихConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Computer Har" +
            "dware Department.mdf\";Integrated Security=True")]
        public string Computer_Hardware_DepartmentConnectionString1 {
            get {
                return ((string)(this["Computer_Hardware_DepartmentConnectionString1"]));
            }
        }
    }
}
