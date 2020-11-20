using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PopulateAListBox
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      //create a collection of zoos
      private List<zoo> zooList;
      //save the current selected zoo
      private zoo currentZoo; 
      public MainWindow()
      {
         FillZooList();
         InitializeComponent();

         //link the collection to the combo box
         CBzooName.ItemsSource = zooList;
         CBzooName.DisplayMemberPath = "ZooName";
         CBzooName.SelectedIndex = 0;
       // ShowZoo();


      }

      //method used to fill the list of zoos
      private void FillZooList()
      {
         zooList = new List<zoo>();

         //have an animal array that will used for the zoos

         Animal [ ] animalArray1 = {new Animal("simba", 10, "lion"),
                              new Animal ("dumbo", 2, "elephant"),
                              new Animal ("goldi", 5, "giraffe")
                              };
         Animal[] animalArray2 = {new Animal("yogi", 10, "bear"),
                              new Animal ("george", 2, "monkey"),
                              new Animal ("otto", 5, "ostrich")
                              };
         Animal[] animalArray3 = {new Animal("elsa", 10, "calf"),
                              new Animal ("baba", 2, "sheep"),
                              new Animal ("gadya", 5, "goat")
                              };
         zoo zoo1 = new zoo("ramat gan", "safari", animalArray1);
         zoo zoo2 = new zoo("Tanachi", "cages", animalArray2);      
         zoo zoo3 = new zoo("Chavayot", "petting", animalArray3);

         zooList.Add(zoo1);
         zooList.Add(zoo2);
         zooList.Add(zoo3);
      }//end of FillZooList

      private void CBzooName_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         ShowZoo((CBzooName.SelectedValue as zoo).ZooName); //get the selected zoo, and call method to display it
      }

      //method to display the animals in the selected zoo
      //parameter is the name of the zoo you want to display
      private void ShowZoo (string zooName)
      {
         //find the reqested zoo
         bool found = false;
         foreach (var gan in zooList)
         {
            if (gan.ZooName == zooName)
            {
               found = true;   //you found your zoo
               currentZoo = gan;//save the found zoo
               break;
            }
         }//end foreach
         if (found)
         {
            UpGrid.DataContext = currentZoo; // have the data for upper grid come from selected zoo
            LBAnimalList.DataContext = currentZoo.AnimalList;  //have the listbox display the animals in the zoo
         }
         else
            throw new KeyNotFoundException();

      }


   }//end of class
}
