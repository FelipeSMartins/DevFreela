using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate)
        {
            this.fullName = fullName;
            this.email = email;
            this.birthDate = birthDate;
            active = true;
            createdAt = DateTime.Now;
            Skills = new List<UserSkill>();
            ownedProjects = new List<Project>();
            freeLanceProjects = new List<Project>();
        }

        public string fullName { get; private set; }
        public string email { get; private set; }
        public DateTime birthDate { get; private set; }
        public DateTime createdAt { get; private set; }
        public bool active { get; private set; }
        public List<UserSkill> Skills { get; private set; }
        public List<Project> ownedProjects { get; private set; }
        public List<Project> freeLanceProjects { get; private set; }
        public List<ProjectComment> comments { get; private set; }
    }
}
