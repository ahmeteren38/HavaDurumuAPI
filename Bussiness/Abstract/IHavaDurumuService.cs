namespace Bussiness.Abstract
{
    public interface IHavaDurumuService
    {
        public Task<string> HavaDurumuSorgula(string sehirAdi);
    }
}
