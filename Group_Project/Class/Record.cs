using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project.Class
{
    internal class Record
    {
        private string _name;
        private int _totalExp;
        private int _blocksBroken;
        public Record(string name, int totalExp, int blockBroken)
        {
            _name = name;
            _totalExp = totalExp;
            _blocksBroken = blockBroken;
        }

        public string Name
        {   get{ return _name; } }

        public int TotalExp
        {   get { return _totalExp; } }

        public int BlocksBroken
        {   get { return _blocksBroken; } }
    }
}
