﻿using System.Collections.Generic;

namespace Unosquare.Swan.Test.Mocks
{
    public class From
    {
        public string address { get; set; }
        public bool args { get; set; }
    }

    public class To
    {
        public string address { get; set; }
        public bool args { get; set; }
    }

    public class Envelope
    {
        public From from { get; set; }
        public List<To> to { get; set; }
        public string host { get; set; }
        public string remoteAddress { get; set; }
    }

    public class SmtpMock
    {
        public Dictionary<string, string> headers { get; set; }
        public string priority { get; set; }
        public string id { get; set; }
        public string time { get; set; }
        public bool read { get; set; }
        public Envelope envelope { get; set; }
        public string source { get; set; }
    }
}
