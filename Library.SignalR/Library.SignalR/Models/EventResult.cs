﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  Library.SignalR.Models
{
    public class EventResult
    {
        public string EventName { get; set; }

        public bool IsFinished { get; set; }

        public bool IsError { get; set; }
    }
}