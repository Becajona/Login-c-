    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    namespace Login.Model
    {
        public class ModeloLog
        {
            public int Id { get; set; }
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }