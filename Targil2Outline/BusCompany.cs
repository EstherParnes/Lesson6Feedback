using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil2Outline
{
   //this class has information about a collection of bus lines
   //this is section 4.
   //a Bus Companay "is composed of a list of bus lines"
   //this means Composition
   class BusCompany : IEnumerable
   {
      private List<BusLine> listOfBusLines;

      public IEnumerator GetEnumerator()
      {
         return listOfBusLines.GetEnumerator();
         //throw new NotImplementedException();
      }
   }
}
