﻿namespace StateManagementBot
{
    public class ConversationData
    {
        public string Timestamp { get; set; }

        // The ID of the user's channel.
        public string ChannelId { get; set; }

        // Track whether we have already asked the user's name
        public bool PromptedUserForName { get; set; } = false;
    }
}
