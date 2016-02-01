using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechTalk.JiraRestClient
{
    public class ExistingSessionInfo
    {
        public string self { get; set; }
        public string name { get; set; }
        public LoginInfo loginInfo { get; set; }
    }
}
