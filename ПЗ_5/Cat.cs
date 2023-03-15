using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ПЗ_5
{

    enum Paroda
    {
        Siamskaya,
        Britanskaya,
        Sfinks
    }

    internal class Cat : ICloneable, IComparable<Cat>
    {

        private string _name;
        private int _yo;
        private Paroda _paroda;

        public Cat(string name, int yo, Paroda paroda)
        {
            _name = name;
            _yo = yo;
            _paroda = paroda;
        }

        public string NAME
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int YO
        {
            get
            {
                return _yo;
            }
            set
            {
                _yo = value;
            }
        }

        public Paroda PARODA
        {
            get
            {
                return _paroda;
            }
            set
            {
                _paroda = value;
            }
        }

        public object Clone()
        {
            return new Cat(NAME, YO, PARODA);
        }

        public int CompareTo(Cat? other)
        {
            if (other is Cat cat) return NAME.CompareTo(cat.NAME);
            else throw new ArgumentException("Некорректное значение параметра"); throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{_name}, {_yo} лет, порода: {_paroda}";
        }

    }
}
