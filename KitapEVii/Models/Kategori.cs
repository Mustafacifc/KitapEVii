namespace KitapEVii.Models
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        List<KitapModel> KitapListesi = new List<KitapModel>();
    }
}
