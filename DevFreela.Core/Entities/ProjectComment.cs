namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, int idProject, int idUser)
        {
            this.content = content;
            this.idProject = idProject;
            this.idUser = idUser;

            createdAt = DateTime.Now;
        }

        public string content { get; private set; }
        public int idProject { get; private set; }
        public Project project { get; private set; }
        public int idUser { get; private set; }
        public User user { get; private set; }
        public DateTime createdAt { get; private set; }
    }
}