using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM
{
    class AlbumViewModel
    {
        #region Members
        ObservableCollection<Song> _songs = new ObservableCollection<Song>();
        #endregion
    }
}
