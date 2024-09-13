namespace Domain.Entities
{
    public class SehirHavaDurumu
    {
        public Guid Id { get; set; }
        public string SehirAdi { get; set; }
        public DateTime SorguZamani { get; set; }
        public string Gun { get; set; }
        public string Derece { get; set; }
        public string HavaDurumuAciklama { get; set; }

    }
}
