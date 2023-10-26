using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Groza_Tudor_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string? Title { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [ForeignKey("Publisher")]
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        [ForeignKey("Author")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
    } //navigation property

}

