﻿using System;
using System.Collections.Generic;

namespace TechTalk.JiraRestClient
{
    public class Transition
    {
        public string id { get; set; }
        public string name { get; set; }

        public Status to { get; set; }

        public Dictionary<string, object> fields { get; set; }
    }
}
