using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Group_Project.Class
{
    [Serializable]
    internal class GameClass
    {
        string _Name;
        int _Score;
        int _Attempts;
        GameClass(string name) 
        {
            _Name = name;
            _Score = 0;
            _Attempts = 10;
        }

        public int attempts
        {
            get{ return _Attempts; }
            set { _Attempts = value; }
        }


    }
}
