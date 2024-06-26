﻿using Kitware.VTK;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HeBianGu.Drawing3D.VTK
{
    public class VtkGraphWindowControl : VtkRenderWindowControl, INotifyPropertyChanged
    {
        protected vtkContextView _contextView;
        private bool _contextMenuShow;

        public vtkContextView ContextView
        {
            get { return _contextView; }
        }

        public VtkGraphWindowControl()
        {
            //_contextView = new vtkContextView();
        }

        protected override void OnInitialize(IntPtr hWnd)
        {
            try
            {
                _renderer = _contextView.GetRenderer();
                _renderWindow = _contextView.GetRenderWindow();

                _renderWindowInteractor = vtkRenderWindowInteractor.New();

                //vtkInteractorStyleSwitch interactorStyleSwitch = _renderWindowInteractor.GetInteractorStyle() as vtkInteractorStyleSwitch;

                //if (null != interactorStyleSwitch)
                //    interactorStyleSwitch.SetCurrentStyleToTrackballCamera();

                _renderWindow.SetParentId(hWnd);

                AttachInteractor();
            }
            catch (Exception ex)
            {
                //log.ErrorException("OnInitialize()", ex);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
