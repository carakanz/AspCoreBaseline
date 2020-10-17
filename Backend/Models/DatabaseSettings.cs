﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string MySqlConnection { get; set; }
        public string MongoDBConnection { get; set; }
        public string MongoDBName { get; set; }
    }

    public interface IDatabaseSettings
    {
        string MySqlConnection { get; set; }
        string MongoDBConnection { get; set; }
        string MongoDBName { get; set; }
    }
}
