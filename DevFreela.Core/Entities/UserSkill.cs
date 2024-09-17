namespace DevFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public UserSkill(int idUser, int idSkill)
        {
            this.idUser = idUser;
            this.idSkill = idSkill;
        }

        public int idUser {  get; private set; }
        public int idSkill { get; private set; }
        public Skill skill { get; private set; }
    }
}