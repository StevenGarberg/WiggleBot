using System.Text.Json;
using MediatR;
using Microsoft.AspNetCore.WebUtilities;
using WiggleBot.Models.RaiderIO;

namespace WiggleBot.Dashboard.Requests;

public record GetCharacterProfileQuery(string RealmName, string CharacterName) : IRequest<CharacterProfile>
{
    public class Handler : IRequestHandler<GetCharacterProfileQuery, CharacterProfile>
    {
        public async Task<CharacterProfile> Handle(GetCharacterProfileQuery request, CancellationToken cancellationToken)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "region", "us" },
                { "realm", request.RealmName },
                { "name", request.CharacterName },
                { "fields", "guild,talents" }
            };
            var httpClient = new HttpClient { BaseAddress = new Uri("https://raider.io/") };
            var requestUri = QueryHelpers.AddQueryString("api/v1/characters/profile", queryParameters);
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);
            httpRequest.Headers.Add("Accept", "application/json");
            var httpResponse = await httpClient.SendAsync(httpRequest, cancellationToken);
            if (!httpResponse.IsSuccessStatusCode) return null;
            var json = await httpResponse.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<CharacterProfile>(json);
        }
    }
}