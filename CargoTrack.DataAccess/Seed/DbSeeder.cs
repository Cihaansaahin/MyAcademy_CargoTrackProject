using CargoTrack.DataAccess.Context;
using CargoTrack.Entity.Entities;
using CargoTrack.Entity.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Seed
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(CargoTrackDbContext context, bool includeDemoData)
        {
            // Zorunlu: her ortamda
            await SeedExtraServiceFeesAsync(context);
            await SeedCargoPricesAsync(context);

            // Demo: sadece geliştirme ortamında
            if (includeDemoData)
                await SeedTransferCentersAndBranchesAsync(context);

            await context.SaveChangesAsync();
        }

        private static async Task SeedExtraServiceFeesAsync(CargoTrackDbContext context)
        {
            if (await context.ExtraServiceFees.IgnoreQueryFilters().AnyAsync())
                return;

            context.ExtraServiceFees.AddRange(
                new ExtraServiceFee { Service = ExtraService.Insurance, Fee = 25 },
                new ExtraServiceFee { Service = ExtraService.Fragile, Fee = 15 },
                new ExtraServiceFee { Service = ExtraService.SmsNotification, Fee = 5 },
                new ExtraServiceFee { Service = ExtraService.SignatureRequired, Fee = 10 });
        }

        private static async Task SeedCargoPricesAsync(CargoTrackDbContext context)
        {
            if (await context.CargoPrices.IgnoreQueryFilters().AnyAsync())
                return;

            (decimal Min, decimal Max)[] bands = [(0, 2), (2, 5), (5, 10), (10, 20), (20, 30)];

            var standardPrices = new Dictionary<DistanceZone, decimal[]>
            {
                [DistanceZone.SameCity] = [80, 110, 150, 220, 300],
                [DistanceZone.SameRegion] = [100, 135, 180, 260, 350],
                [DistanceZone.DifferentRegion] = [140, 185, 240, 340, 450]
            };

            foreach (var (zone, prices) in standardPrices)
            {
                for (int i = 0; i < bands.Length; i++)
                {
                    context.CargoPrices.Add(new CargoPrice
                    {
                        Zone = zone,
                        DeliveryType = DeliveryType.Standard,
                        MinWeight = bands[i].Min,
                        MaxWeight = bands[i].Max,
                        Price = prices[i]
                    });

                    context.CargoPrices.Add(new CargoPrice
                    {
                        Zone = zone,
                        DeliveryType = DeliveryType.Express,
                        MinWeight = bands[i].Min,
                        MaxWeight = bands[i].Max,
                        Price = Math.Round(prices[i] * 1.5m)
                    });
                }
            }
        }

        private static async Task SeedTransferCentersAndBranchesAsync(CargoTrackDbContext context)
        {
            if (await context.TransferCenters.IgnoreQueryFilters().AnyAsync())
                return;

            var istanbulTm = new TransferCenter
            {
                Name = "İstanbul Anadolu Transfer Merkezi",
                Code = "TM-IST-AND",
                AddressLine = "Tuzla Organize Sanayi Bölgesi",
                CityId = 34
            };
            var ankaraTm = new TransferCenter
            {
                Name = "Ankara Transfer Merkezi",
                Code = "TM-ANK",
                AddressLine = "Sincan Lojistik Merkezi",
                CityId = 6
            };
            var izmirTm = new TransferCenter
            {
                Name = "İzmir Transfer Merkezi",
                Code = "TM-IZM",
                AddressLine = "Kemalpaşa Lojistik Bölgesi",
                CityId = 35
            };

            context.TransferCenters.AddRange(istanbulTm, ankaraTm, izmirTm);

            context.Branches.AddRange(
                new Branch
                {
                    Name = "Ataşehir Şubesi",
                    Code = "IST-ATA",
                    District = "Ataşehir",
                    AddressLine = "Atatürk Mah. Ataşehir Bulvarı No:10",
                    Phone = "0216 555 10 10",
                    CityId = 34,
                    TransferCenter = istanbulTm
                },
                new Branch
                {
                    Name = "Kadıköy Şubesi",
                    Code = "IST-KAD",
                    District = "Kadıköy",
                    AddressLine = "Caferağa Mah. Moda Cad. No:25",
                    Phone = "0216 555 20 20",
                    CityId = 34,
                    TransferCenter = istanbulTm
                },
                new Branch
                {
                    Name = "Çankaya Şubesi",
                    Code = "ANK-CAN",
                    District = "Çankaya",
                    AddressLine = "Kızılay Mah. Atatürk Bulvarı No:50",
                    Phone = "0312 555 30 30",
                    CityId = 6,
                    TransferCenter = ankaraTm
                },
                new Branch
                {
                    Name = "Keçiören Şubesi",
                    Code = "ANK-KEC",
                    District = "Keçiören",
                    AddressLine = "Etlik Mah. Yunus Emre Cad. No:12",
                    Phone = "0312 555 40 40",
                    CityId = 6,
                    TransferCenter = ankaraTm
                },
                new Branch
                {
                    Name = "Konak Şubesi",
                    Code = "IZM-KON",
                    District = "Konak",
                    AddressLine = "Alsancak Mah. Kıbrıs Şehitleri Cad. No:8",
                    Phone = "0232 555 50 50",
                    CityId = 35,
                    TransferCenter = izmirTm
                },
                new Branch
                {
                    Name = "Bornova Şubesi",
                    Code = "IZM-BOR",
                    District = "Bornova",
                    AddressLine = "Kazımdirik Mah. Üniversite Cad. No:30",
                    Phone = "0232 555 60 60",
                    CityId = 35,
                    TransferCenter = izmirTm
                });
        }
    }
}
