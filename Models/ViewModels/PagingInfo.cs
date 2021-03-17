using System;
namespace OnlineBookstore.Models.ViewModels
{
    //pretty sure we don't need this ViewModel but I added it just in case we want to filter 
    //this is bundling the information to add it to the view
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalNumItems / ItemsPerPage);
    }
}