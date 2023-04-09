﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace ViewModel
{
    public class Commands
    {
        public ICommand ClickSpawnButonCommand { get; }
        public MyCommandParameters Parameters { get; set; }

        public Commands()
        {
            Parameters = new MyCommandParameters();
            ClickSpawnButonCommand = new RelayCommand(OnClickSpawnButton, CanSpawn);
            Debug.WriteLine("zinicjalizowano commands");
        }

        private void OnClickSpawnButton(object parameter)
        {
            var parameters = parameter as MyCommandParameters;
            if (parameters == null)
            {
                return;
            }

            var canvas = parameters.Canvas;
            var text = parameters.testowy;
            Debug.WriteLine("Button clicked");
            Debug.WriteLine(text);
        }

        public bool CanSpawn(object parameter)
        {
            return true;
            
            /*
            var parameters = parameter as MyCommandParameters;
            if (parameters == null)
            {
                return false;
            }

            if (Convert.ToInt32(parameters.Text) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            */
        }

        static void Main(string[] args)
        {

        }
    }
}
