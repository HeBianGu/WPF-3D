using HeBianGu.Base.WpfBase;
using HeBianGu.Service.AppConfig;
using HeBianGu.Systems.Print;
using HeBianGu.Systems.Project;
using HeBianGu.Systems.WinTool;
using HeBianGu.Systems.XmlSerialize;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace HeBianGu.App.Unit3D
{
    internal class ShellViewModel : NotifyPropertyChanged
    {
        protected override void Loaded(object obj)
        {
            base.Loaded(obj);

            //this.FileName = @"C:\Users\LENOVO\My project (1)\新建文件夹\My project (1).exe";
            this.FileName = "C:\\Users\\LENOVO\\My project (3)\\exe\\My project (3).exe";
        }

        private string _fileName;
        /// <summary> 说明  </summary>
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                RaisePropertyChanged();
            }
        }

    }
}
