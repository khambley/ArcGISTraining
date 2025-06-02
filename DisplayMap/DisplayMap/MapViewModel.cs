using Esri.ArcGISRuntime.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DisplayMap
{
    class MapViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Map _map;
        public Map Map
        {
            get { return _map; }
            set
            {
                _map = value; OnPropertyChanged();
            }
        }
        public MapViewModel()
        {
            SetupMap();
        }
        private void SetupMap()
        {
            // Create a new map with a 'topographic vector' basemap
            Map = new Map(BasemapStyle.ArcGISTopographic);
        }
    }
}
