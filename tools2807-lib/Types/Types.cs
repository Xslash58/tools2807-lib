using System;
namespace tools2807.Types
{
    public class User
    {
        public string id = string.Empty;
        public string displayName = string.Empty;
        public string login = string.Empty;
        public string avatar = string.Empty;
        public DateTime? granted_at = null;
        public bool banned = false;
    }
    public class FollowUser
    {
        public string id = string.Empty;
        public string displayName = string.Empty;
        public string login = string.Empty;
        public string avatar = string.Empty;
        public DateTime? followedAt = null;
        public bool isLive = false;
    }
    public class FounderUser
    {
        public string id = string.Empty;
        public string displayName = string.Empty;
        public string login = string.Empty;
        public DateTime? firstMonth = null;
        public bool isSubscribed = false;
        public string avatar = string.Empty;
        public bool banned = false;
    }
}
