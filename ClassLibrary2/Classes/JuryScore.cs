﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary2.Classes
{
    [Serializable]
    public class JuryScore
    {
        public string name { get; set; }
        public float[] score { get; set; }
}
}
