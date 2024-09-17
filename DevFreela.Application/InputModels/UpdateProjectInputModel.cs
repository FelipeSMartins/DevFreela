using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal TotalCost { get; set; }
    }
}
