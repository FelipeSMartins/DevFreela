using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class SkillViewModel
    {
        public SkillViewModel(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public int id { get; private set; }
        public string description { get; private set; }
    }
}
