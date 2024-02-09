namespace Domain.Entities
{
    public class SortieDTO
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int OrganisateurId { get; set; }
        public int LieuId { get; set; }
        public int EtatId { get; set; }
        public virtual ParticipantDTO Organisateur { get; set; }
        public virtual LieuDTO Lieu { get; set;}
        public virtual EtatDTO Etat { get;}
    }
}
