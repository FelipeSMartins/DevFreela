using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, 
            DateTime? startedAt, DateTime? finishedAt)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.totalCost = totalCost;
            this.startedAt = startedAt;
            this.finishedAt = finishedAt;
        }

        public int id { get; private set; }
        public string title { get; private set; }
        public string description { get; private set; }
        public decimal totalCost { get; private set; }
        public DateTime? startedAt { get; private set; }
        public DateTime? finishedAt { get; private set; }
    }
}
