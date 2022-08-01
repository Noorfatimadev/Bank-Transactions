using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This Field is Required.")]
        //[MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string  AccountName{ get; set; }

        [Column(TypeName = "nvarchar(100)")] //maximum element characters
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This Field is Required.")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field is Required.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This Field is Required.")]
        //[MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public int SWIFTCode { get; set; }

        [Required(ErrorMessage = "This Field is Required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }

    }
}
