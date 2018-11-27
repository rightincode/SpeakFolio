using System;

namespace SpeakFolio.Core
{
    public class SpeakerAddress
    {
        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string StateProvience { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public int SpeakerProfileId { get; set; }

        public Guid Uid { get; set; }
    }
}
