﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.Domain.Entities
{
    public class Blab : BaseEntity
    {
        public string Message { get; set; }
        public string UserID { get; set; }

    }
}
