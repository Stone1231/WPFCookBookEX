using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM
{
    public class SongViewModel : INotifyPropertyChanged
    {
        #region Construction
        /// Constructs the default instance of a SongViewModel
        public SongViewModel()
        {
            _song = new Song { ArtistName = "Unknown", SongTitle = "Unknown" };
        }
        #endregion

        #region Members
        Song _song;
        #endregion

        #region Properties
        public Song Song
        {
            get
            {
                return _song;
            }
            set
            {
                _song = value;
            }
        }

        public string ArtistName
        {
            get { return Song.ArtistName; }
            set
            {
                if (Song.ArtistName != value)
                {
                    Song.ArtistName = value;
                    RaisePropertyChanged("ArtistName");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
