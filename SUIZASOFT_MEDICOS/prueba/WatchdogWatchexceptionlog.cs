﻿using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class WatchdogWatchexceptionlog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Stacktrace { get; set; }
        public string Typeof { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public string Querystring { get; set; }
        public string Requestbody { get; set; }
        public DateTime Encounteredat { get; set; }
    }
}
