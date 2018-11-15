using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _21WCFFSDCalculator
{
    [DataContract]
    public class Calc

    {

        [DataMember]
        public double n1;

        [DataMember]
        public double n2;

    }
}
