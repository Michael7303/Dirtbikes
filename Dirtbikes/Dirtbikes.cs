using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dirtbikes
{
    public class Dirtbike
    {
        public enum WhatType
        {
            Enduro,
            FreeRide,
            Supercross,
            motocross,
            trial
        }

        #region FIELDS

        private string _name;
        private int _age;
        private WhatType _type;
        private int _firstMadeIn;
        private int _rank;


        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int firstMadeIn
        {
            get { return _firstMadeIn; }
            set { _firstMadeIn = value; }
        }

        public WhatType type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Dirtbike()
        {

        }

        #endregion


    }
}
