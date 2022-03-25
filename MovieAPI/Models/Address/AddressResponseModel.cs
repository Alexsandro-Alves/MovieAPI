using System;

namespace MovieAPI.Models.Adress
{
    public class AddressResponseModel
    {
        public string Road { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
        public DateTime ConsultationTime { get; set; }
    }
}
