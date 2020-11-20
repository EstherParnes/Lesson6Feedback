using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateAListBox
{
   class zoo
   {


      //anme of the zoo
      public string ZooName { get; set; } 
      //type of zoo: caged, safari, petting, etc
      public string ZooType { get; set; }

      //list of the animals
      private List<Animal> animalList;
      public List<Animal> AnimalList { get=>animalList; set=> animalList= value; }

      public zoo(string zooName, string zooType, Animal[] chayot)
      {
         ZooName = zooName;
         ZooType = zooType;
         animalList = new List<Animal>();
         foreach (Animal an in chayot)
         {
            animalList.Add(an);
         }
      }//end ctor

         public override string ToString()
      {
         string str = "";
         foreach (var animal in AnimalList)
         {
            str += animal.Name + " " + animal.Species;
         }
         return str;
      }//end tostring

   }//end class
  }//end namespace
