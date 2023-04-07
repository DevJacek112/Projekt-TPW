using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class Commands
    {
        public ICommand ClickSpawnButonCommand { get; }

        public Commands()
        {
            ClickSpawnButonCommand = new RelayCommand(OnClickSpawnButton, CanSpawn);
        }

        public void OnClickSpawnButton(object Parameter)
        {
            Debug.WriteLine("Button clicked");
            Debug.WriteLine(Parameter);

            //Logika.Controller.spawnCircles(Convert.ToInt32(Parameter));
        }

        public bool CanSpawn(object Parameter)
        {
            if(Convert.ToInt32(Parameter) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
