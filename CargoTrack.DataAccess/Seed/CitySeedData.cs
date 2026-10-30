using CargoTrack.Entity.Entities;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Seed
{
    public static class CitySeedData
    {
        private static readonly DateTime SeedDate = new(2026, 1, 1);

        public static City[] Cities =>
        [
            Create(1, "Adana", Region.Akdeniz),
        Create(2, "Adıyaman", Region.GuneyDoguAnadolu),
        Create(3, "Afyonkarahisar", Region.Ege),
        Create(4, "Ağrı", Region.DoguAnadolu),
        Create(5, "Amasya", Region.Karadeniz),
        Create(6, "Ankara", Region.IcAnadolu),
        Create(7, "Antalya", Region.Akdeniz),
        Create(8, "Artvin", Region.Karadeniz),
        Create(9, "Aydın", Region.Ege),
        Create(10, "Balıkesir", Region.Marmara),
        Create(11, "Bilecik", Region.Marmara),
        Create(12, "Bingöl", Region.DoguAnadolu),
        Create(13, "Bitlis", Region.DoguAnadolu),
        Create(14, "Bolu", Region.Karadeniz),
        Create(15, "Burdur", Region.Akdeniz),
        Create(16, "Bursa", Region.Marmara),
        Create(17, "Çanakkale", Region.Marmara),
        Create(18, "Çankırı", Region.IcAnadolu),
        Create(19, "Çorum", Region.Karadeniz),
        Create(20, "Denizli", Region.Ege),
        Create(21, "Diyarbakır", Region.GuneyDoguAnadolu),
        Create(22, "Edirne", Region.Marmara),
        Create(23, "Elazığ", Region.DoguAnadolu),
        Create(24, "Erzincan", Region.DoguAnadolu),
        Create(25, "Erzurum", Region.DoguAnadolu),
        Create(26, "Eskişehir", Region.IcAnadolu),
        Create(27, "Gaziantep", Region.GuneyDoguAnadolu),
        Create(28, "Giresun", Region.Karadeniz),
        Create(29, "Gümüşhane", Region.Karadeniz),
        Create(30, "Hakkari", Region.DoguAnadolu),
        Create(31, "Hatay", Region.Akdeniz),
        Create(32, "Isparta", Region.Akdeniz),
        Create(33, "Mersin", Region.Akdeniz),
        Create(34, "İstanbul", Region.Marmara),
        Create(35, "İzmir", Region.Ege),
        Create(36, "Kars", Region.DoguAnadolu),
        Create(37, "Kastamonu", Region.Karadeniz),
        Create(38, "Kayseri", Region.IcAnadolu),
        Create(39, "Kırklareli", Region.Marmara),
        Create(40, "Kırşehir", Region.IcAnadolu),
        Create(41, "Kocaeli", Region.Marmara),
        Create(42, "Konya", Region.IcAnadolu),
        Create(43, "Kütahya", Region.Ege),
        Create(44, "Malatya", Region.DoguAnadolu),
        Create(45, "Manisa", Region.Ege),
        Create(46, "Kahramanmaraş", Region.Akdeniz),
        Create(47, "Mardin", Region.GuneyDoguAnadolu),
        Create(48, "Muğla", Region.Ege),
        Create(49, "Muş", Region.DoguAnadolu),
        Create(50, "Nevşehir", Region.IcAnadolu),
        Create(51, "Niğde", Region.IcAnadolu),
        Create(52, "Ordu", Region.Karadeniz),
        Create(53, "Rize", Region.Karadeniz),
        Create(54, "Sakarya", Region.Marmara),
        Create(55, "Samsun", Region.Karadeniz),
        Create(56, "Siirt", Region.GuneyDoguAnadolu),
        Create(57, "Sinop", Region.Karadeniz),
        Create(58, "Sivas", Region.IcAnadolu),
        Create(59, "Tekirdağ", Region.Marmara),
        Create(60, "Tokat", Region.Karadeniz),
        Create(61, "Trabzon", Region.Karadeniz),
        Create(62, "Tunceli", Region.DoguAnadolu),
        Create(63, "Şanlıurfa", Region.GuneyDoguAnadolu),
        Create(64, "Uşak", Region.Ege),
        Create(65, "Van", Region.DoguAnadolu),
        Create(66, "Yozgat", Region.IcAnadolu),
        Create(67, "Zonguldak", Region.Karadeniz),
        Create(68, "Aksaray", Region.IcAnadolu),
        Create(69, "Bayburt", Region.Karadeniz),
        Create(70, "Karaman", Region.IcAnadolu),
        Create(71, "Kırıkkale", Region.IcAnadolu),
        Create(72, "Batman", Region.GuneyDoguAnadolu),
        Create(73, "Şırnak", Region.GuneyDoguAnadolu),
        Create(74, "Bartın", Region.Karadeniz),
        Create(75, "Ardahan", Region.DoguAnadolu),
        Create(76, "Iğdır", Region.DoguAnadolu),
        Create(77, "Yalova", Region.Marmara),
        Create(78, "Karabük", Region.Karadeniz),
        Create(79, "Kilis", Region.GuneyDoguAnadolu),
        Create(80, "Osmaniye", Region.Akdeniz),
        Create(81, "Düzce", Region.Karadeniz)
        ];

        private static City Create(int plateCode, string name, Region region) => new()
        {
            Id = plateCode,
            PlateCode = plateCode,
            Name = name,
            Region = region,
            CreatedDate = SeedDate
        };
    }
}
