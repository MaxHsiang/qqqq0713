using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class PetDetail
    {
        public int ProductId { get; set; }
        public int? GenderId { get; set; }
        public int? ColorId { get; set; }
        public int? CityId { get; set; }
        public decimal? YearCost { get; set; }
        public int? Space { get; set; }
        public int? SizeId { get; set; }
        public int? AgeId { get; set; }
        public int? AccompanyTimeWeek { get; set; }
        public int? LigationId { get; set; }
        public string Description { get; set; }

        public virtual Age Age { get; set; }
        public virtual City City { get; set; }
        public virtual Color Color { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Ligation Ligation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}
