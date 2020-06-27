using System;
using System.Collections.Generic;
using System.Text;

namespace OrtakClassLibrary.DTOs
{
    public class FilterKitaplarDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
        public PaginationDTO Pagination
        {
            get { return new PaginationDTO() { Page = Page, RecordsPerPage = RecordsPerPage }; }
        }
        public string Baslik { get; set; }
        public int KitapturId { get; set; }
        public bool KitapListele { get; set; }
    }
}
