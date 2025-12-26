// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class ProductionEndpointConfiguration : EndpointConfiguration
    {
        public ProductionEndpointConfiguration()
        {
            WebsiteUrl = APIUrl = @"https://osu.refx.online";
            APIClientSecret = @"FGc9GAtyHzeQDshWP5Ah7dega8hJACAJpQtw6OXk";
            APIClientID = "5";
            SpectatorUrl = "https://osu.refx.online/signalr/spectator";
            MultiplayerUrl = "https://osu.refx.online/signalr/multiplayer";
            MetadataUrl = "https://osu.refx.online/signalr/metadata";
            BeatmapSubmissionServiceUrl = "https://bss.ppy.sh"; // soon
        }
    }
}
