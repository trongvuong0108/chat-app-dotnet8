﻿namespace ChatApp.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string ConnectionId { get; set; } = string.Empty;
        public bool InCall { get; set; }
    }
}
