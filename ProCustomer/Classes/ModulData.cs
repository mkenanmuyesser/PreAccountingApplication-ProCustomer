using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProCustomer.Classes
{
    public class SiparisData
    {
        public int ID { get; set; }
        public string SiparişDurum { get; set; }
        public string Tutar { get; set; }
        public DateTime SiparişTarih { get; set; }
        public string Ad_Unvan { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Açıklama { get; set; }
    }

    public class SiparisDetayData
    {
        public int ID { get; set; }
        public string Urun { get; set; }
        public int Adet { get; set; }        
        public decimal Fiyat { get; set; }
        public byte KdvOran { get; set; }
        public decimal KdvTutar { get; set; }
        public decimal Toplam { get; set; }
        public string Acıklama { get; set; }
    }

    public class TaksitData
    {
        public int ID { get; set; }
        public string Musteri { get; set; }
        public DateTime SiparisTarih { get; set; }
        public string SiparisTutar { get; set; }
    }

    public class MusteriData
    {
        public int ID { get; set; }
        public string Ad_Unvan { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string GoldUye { get; set; }
        public string ParaPuan { get; set; }
        public string Adres { get; set; }
    }

    public class MusteriCariHareketData
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string Tutar { get; set; }
        public string OdemeTipi { get; set; }
        public string Durum { get; set; }
        public string Aciklama { get; set; }
    }

    public class UrunData
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public string Fiyat1 { get; set; }
        public string Fiyat2 { get; set; }
        public string Fiyat3 { get; set; }
        public string Fiyat4 { get; set; }
        public string Fiyat5 { get; set; }
        public string Fiyat6 { get; set; }
        public int KdvOran { get; set; }
        public string KdvDahil { get; set; }
        public string Aciklama { get; set; }
    }

    public class UrunStokData
    {
        public int ID { get; set; }
        public string KasaAdi { get; set; }
        public int Miktar { get; set; }
        public string GirisCikis { get; set; }
    }

    public class KasaData
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string MusteriAdi { get; set; }
        public string Tutar { get; set; }
        public string GirisCikis { get; set; }
    }

    public class Siparis2
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string Musteri { get; set; }
        public string Tutar { get; set; }
        public string Personel { get; set; }
        public string TaksitliSatış { get; set; }
        public string Aciklama { get; set; }
    }

    public class BolgeData
    {
        public int ID { get; set; }
        public string Tanım { get; set; }
        public string Personel { get; set; }
        public int FiyatKademe { get; set; }
    }

    public class AramaData
    {
        public DateTime Tarih { get; set; }
        public string Urun { get; set; }
    }

    public class PetData
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Türü { get; set; }
        public bool Cinsi { get; set; }
        public int Aylık { get; set; }
        public string Müşteri { get; set; }
    }

    public class RaporData
    {
        public string UrunAdi { get; set; }
        public int UrunAdeti { get; set; }
        public string UrunTutarı { get; set; }
    }

    public class HatirlatmaData
    {
        public string TedaviAdı { get; set; }
        public DateTime TedaviTarihi { get; set; }
    }

    public class UrunMu
    {
        public string UrunAdı { get; set; }
        public int Adeti { get; set; }
    }

    public class MuayeneData
    {
        public int ID { get; set; }
        public string Musteri { get; set; }
        public string Hayvan { get; set; }
        public string Doktor { get; set; }
        public string MauyeneNedeni { get; set; }
        public string Tutar { get; set; }
        public DateTime Tarih { get; set; }
    }

    public class RandevuData
    {
        public string MusteriAdi { get; set; }
        public DateTime RandevuTarihi { get; set; }
    }
}
