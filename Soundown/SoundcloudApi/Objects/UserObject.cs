using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Soundown.SoundcloudApi.Objects
{
    [DataContract]
    public class UserObject
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "permalink")]
        public string Permalink { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "last_modified")]
        public string LastModified { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "permalink_url")]
        public string PermalinkUrl { get; set; }

        [DataMember(Name = "avatar_url")]
        public string AvatarUrl { get; set; }

        [DataMember(Name = "country")]
        public object Country { get; set; }

        [DataMember(Name = "first_name")]
        public object FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public object LastName { get; set; }

        [DataMember(Name = "full_name")]
        public string FullName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "city")]
        public object City { get; set; }

        [DataMember(Name = "discogs_name")]
        public object DiscogsName { get; set; }

        [DataMember(Name = "myspace_name")]
        public object MyspaceName { get; set; }

        [DataMember(Name = "website")]
        public object Website { get; set; }

        [DataMember(Name = "website_title")]
        public object WebsiteTitle { get; set; }

        [DataMember(Name = "online")]
        public bool Online { get; set; }

        [DataMember(Name = "track_count")]
        public int TrackCount { get; set; }

        [DataMember(Name = "playlist_count")]
        public int PlaylistCount { get; set; }

        [DataMember(Name = "plan")]
        public string Plan { get; set; }

        [DataMember(Name = "public_favorites_count")]
        public int PublicFavoritesCount { get; set; }

        [DataMember(Name = "followers_count")]
        public int FollowersCount { get; set; }

        [DataMember(Name = "followings_count")]
        public int FollowingsCount { get; set; }

        [DataMember(Name = "subscriptions")]
        public List<object> Subscriptions { get; set; }

    }

}
