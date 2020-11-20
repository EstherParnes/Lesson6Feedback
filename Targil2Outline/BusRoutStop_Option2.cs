using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil2Outline
{
   //this class has information about the bus route stop
   //this is section 2.
   //in this option, we say 
   //"a bus_route_stop  HAS A bus stop"
   //that means Composition
   class BusRoutStop_Option2
   {


      //HAS-A property for the bus stop
      public BusStop busStop { get; }

      //to the base fields/properties you need to add:
      // field/property for Distance
      //field/property for Time

      //ctor
      public BusRoutStop_Option2(BusStop busStop)
      {
         //since busStop is read only you  have to assign it in ctor
         this.busStop = busStop;
      }

   }
}
