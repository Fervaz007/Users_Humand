using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Send_Json
{
    internal class Users
    {

            [JsonPropertyName("password")]
            public string password { get; set; }
            [JsonPropertyName("relationships")]
            public List<Relationships> relationships { get; set; }

            public string employeeInternalId { get; set; }

            public string firstName { get; set; }

            public string lastName { get; set; }
      
    }
}
