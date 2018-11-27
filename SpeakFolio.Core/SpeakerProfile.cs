using System;
using System.Collections.Generic;

namespace SpeakFolio.Core
{
    public class SpeakerProfile
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string EmailAddress { get; set; }

        public string TwitterHandle { get; set; }

        public string TwitterUrl { get; set; }

        public string LinkedInUrl { get; set; }

        public string FaceBookUrl { get; set; }

        public string YouTubeChannelUrl { get; set; }

        public string GitHubUrl { get; set; }

        public List<SpeakerAddress> Addresses { get; set; }

        public string AspNetUserId { get; set; }

        public Guid Uid { get; set; }
    }
}
