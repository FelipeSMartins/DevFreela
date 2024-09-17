using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime createdAt)
        {
            this.id = id;
            this.title = title;
            this.createdAt = createdAt;
        }

        public int id { get; private set; }
        public string title { get; private set; }
        public DateTime createdAt { get; private set; }
    }
}
