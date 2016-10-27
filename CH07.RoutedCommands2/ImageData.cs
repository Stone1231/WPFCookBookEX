using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CH07.RoutedCommands
{
    class ImageData : INotifyPropertyChanged
    {
        ICommand _openImageFileCommand, _zoomCommand;
        public ICommand OpenImageFileCommand
        {
            get { return _openImageFileCommand; }
        }
        public ICommand ZoomCommand
        {
            get { return _zoomCommand; }
        }

        public ImageData()
        {
            _openImageFileCommand = new Commands.OpenImageFileCommand(this);
            _zoomCommand = new Commands.ZoomCommand(this);
        }

        string _imagePath;
        public string ImagePath 
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        double _zoom = 1.0;
        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                OnPropertyChanged("Zoom");
            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
