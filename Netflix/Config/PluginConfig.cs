using System;
using MediaBrowser.Model.Plugins;
using Netflix.Api;

namespace Netflix
{
    public class PluginConfig : BasePluginConfiguration
    {
        public string ChannelName { get; set; }
        public string TraktListUserName => "eduardoaguiar";
        public string TraktListName => "netflix-movies";
        
        public Guid Guid = new Guid("3A1DD6D1-070C-4B2A-98C2-0D97550518F3"); // Also Needs Set In HTML File
        public string PluginName => "Netflix";
        public string PluginDesc => "Movies from Netflix";
        public string Pin { get; set; }
        public bool Enabled { get; set; }
        public TraktUser TraktUser { get; set; }

        public PluginConfig()
        {
            TraktUser = new TraktUser();
            Enabled = true;
        }
    }
}