﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    internal interface INotificationService
    {
        
        public void SendNotification(string recipient , String message);
    }
}
