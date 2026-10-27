using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class Cargo : BaseEntity
    {
        // kimlik doğrulama 
        public string TrackingNumber { get; set; } = null!;
        public  CargoStatus Status { get; set; }
        public string? Content { get; set; }

        //Ölçüler
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Desi { get; set; }
        public decimal ChargeableWeight { get; set; }


        // Hizmet Ve Ücret
        public DeliveryType DeliveryType { get; set; }
        public ExtraService ExtraService { get; set; }
        public decimal Price{ get; set; }
        public DateTime EstimatedDeliveryDate{ get; set; }


        // Teslimat kontrolu
        public string? DeliveryCode { get; set; }
        


        // 5) Kimden kime
        public int SenderCustomerId { get; set; }
        public Customer SenderCustomer { get; set; } = null!;
        public int ReceiverCustomerId { get; set; }
        public Customer ReceiverCustomer { get; set; } = null!;

        public int ReceiverAddressId { get; set; }
        public Address ReceiverAddress { get; set; } = null!;


        // 6) Nereden nereye ve şu an nerede
        public int OriginBranchId { get; set; }
        public Branch OriginBranch { get; set; } = null!;

        public int DestinationBranchId { get; set; }
        public Branch DestinationBranch { get; set; } = null!;

        public int? CurrentBranchId { get; set; }
        public Branch? CurrentBranch { get; set; }

        public int? CurrentTransferCenterId { get; set; }
        public TransferCenter? CurrentTransferCenter { get; set; }



        // 7) Hareket geçmişi
        public ICollection<CargoMovement> Movements { get; set; } = new List<CargoMovement>();



        // 8) Teslimat sonucu
        public Delivery? Delivery { get; set; }
        public ICollection<DeliveryException> DeliveryExceptions { get; set; } = new List<DeliveryException>();
        
    }
}
