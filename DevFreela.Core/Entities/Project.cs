using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreeLancer, decimal totalCost)
        {
            this.title = title;
            this.description = description;
            this.idClient = idClient;
            this.idFreeLancer = idFreeLancer;
            this.totalCost = totalCost;

            status = ProjectStatusEnum.Created;
            createdAd = DateTime.Now;
            comments = new List<ProjectComment>();

        }

        public string title { get; private set; }
        public string description { get; private set; }
        public User client { get; private set; }
        public int idClient { get; private set; }
        public User freelancer { get; private set; }
        public int idFreeLancer { get; private set; }
        public decimal totalCost { get; private set; }
        public DateTime createdAd { get; private set; }
        public DateTime? startedAt { get; private set; }
        public DateTime? finishedAt { get; private set; }
        public ProjectStatusEnum status { get; private set; }
        public List<ProjectComment> comments { get; private set; }
        public void cancel()
        {
            if(status == ProjectStatusEnum.InProgress || status == ProjectStatusEnum.Created)
            {
                status = ProjectStatusEnum.Cancelled;
            }
            
        }

        public void finish()
        {
            if(status == ProjectStatusEnum.Created || status == ProjectStatusEnum.InProgress)
            {
                status = ProjectStatusEnum.Finished;
                finishedAt = DateTime.Now;
            }
        }

        public void start()
        {
            if(status == ProjectStatusEnum.Created)
            {
                status = ProjectStatusEnum.InProgress;
                startedAt = DateTime.Now;
            }
        }
    }
}