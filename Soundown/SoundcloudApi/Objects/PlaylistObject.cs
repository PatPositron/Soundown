using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Soundown.SoundcloudApi.Objects
{
    [DataContract]
    public class CreatedWith
    {
        [DataMember(Name = "permalink_url")]
        public string PermalinkUrl { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "external_url")]
        public string ExternalUrl { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "creator")]
        public string Creator { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }
    }

    [DataContract]
    public class PlaylistObject
    {
        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "release_day")]
        public object ReleaseDay { get; set; }

        [DataMember(Name = "permalink_url")]
        public string PermalinkUrl { get; set; }

        [DataMember(Name = "genre")]
        public string Genre { get; set; }

        [DataMember(Name = "permalink")]
        public string Permalink { get; set; }

        [DataMember(Name = "purchase_url")]
        public object PurchaseUrl { get; set; }

        [DataMember(Name = "release_month")]
        public object ReleaseMonth { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "label_name")]
        public string LabelName { get; set; }

        [DataMember(Name = "tag_list")]
        public string TagList { get; set; }

        [DataMember(Name = "release_year")]
        public object ReleaseYear { get; set; }

        [DataMember(Name = "track_count")]
        public int TrackCount { get; set; }

        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [DataMember(Name = "last_modified")]
        public string LastModified { get; set; }

        [DataMember(Name = "license")]
        public string License { get; set; }

        [DataMember(Name = "tracks")]
        public List<TrackObject> Tracks { get; set; }

        [DataMember(Name = "playlist_type")]
        public string PlaylistType { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "downloadable")]
        public object Downloadable { get; set; }

        [DataMember(Name = "sharing")]
        public string Sharing { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "release")]
        public string Release { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "purchase_title")]
        public object PurchaseTitle { get; set; }

        [DataMember(Name = "created_with")]
        public CreatedWith CreatedWith { get; set; }

        [DataMember(Name = "artwork_url")]
        public object ArtworkUrl { get; set; }

        [DataMember(Name = "ean")]
        public string Ean { get; set; }

        [DataMember(Name = "streamable")]
        public bool Streamable { get; set; }

        [DataMember(Name = "user")]
        public UserObject User { get; set; }

        [DataMember(Name = "embeddable_by")]
        public string EmbeddableBy { get; set; }

        [DataMember(Name = "label_id")]
        public object LabelId { get; set; }
    }
}
