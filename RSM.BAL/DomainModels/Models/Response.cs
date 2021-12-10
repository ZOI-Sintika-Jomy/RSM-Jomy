﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RSM.BAL.DomainModels.Models
{
    [Serializable]
    public class Response
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
