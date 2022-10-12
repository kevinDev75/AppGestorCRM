using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKST.Models
{
    public class ApiResponseDTO
    {
        public int pcode { get; set; }
        public string pmessage { get; set; }
        public dynamic data { get; set; }

    }
}
