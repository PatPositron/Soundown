using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Soundown.SoundcloudApi.Objects
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "error_message")]
        public string ErrorMessage { get; set; }

    }

    [DataContract]
    public class ResolveObject
    {
        [DataMember(Name = "errors")]
        public List<Error> Errors { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        public string RawJson { get; set; }

    }
}
