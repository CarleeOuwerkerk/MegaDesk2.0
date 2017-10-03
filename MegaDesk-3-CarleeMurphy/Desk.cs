using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_CarleeMurphy
{
    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    };

    class Desk
    {
        private int _width;
        private int _depth;
        private int _numberOfDrawers;
        private string _purchaserName;
        private string _orderType;
        private string _price;
        private DateTime _date;
        private SurfaceMaterial _surfaceMaterial;

        public int width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int depth
        {
            get { return _depth; }
            set { _depth = value; }
        }

        public int numberOfDrawers
        {
            get { return _numberOfDrawers; }
            set { _numberOfDrawers = value; }
        }

        public string purchaserName
        {
            get { return _purchaserName; }
            set { _purchaserName = value; }
        }

        public string orderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        public string price
        {
            get { return _price; }
            set { _price = value; }
        }

        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        public SurfaceMaterial surfaceMaterial
        {
            get { return _surfaceMaterial; }
            set { _surfaceMaterial = value; }
        }
    }
 }
