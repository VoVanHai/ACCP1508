﻿using System;

namespace Session06
{
    internal class InvalidRecValues : Exception
    {
        public InvalidRecValues():base()
        {
        }

        public InvalidRecValues(string message) : base(message)
        {
        }
    }
}