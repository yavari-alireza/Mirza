﻿using System;

namespace Mirza.Cli
{
    internal class AddWorkLogServiceInput
    {
        public AddWorkLogServiceInput(TimeSpan start, TimeSpan end, string description = "-", string detail = "-")
        {
            Start = start.ToString("hh\\:mm");
            End = end.ToString("hh\\:mm");
            Description = description;
            Detail = detail;
        }

        public string Start { get; set; }
        public string End { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
    }
}