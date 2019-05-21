﻿using Refit;
using System.Threading.Tasks;

namespace GitTrends.Shared
{
    [Headers("User-Agent: " + nameof(GitTrends), "Accept-Encoding: gzip", "Accept: application/json")]
    interface IGitHubApiV3
    {
        [Get("/repos/{owner}/{repo}/traffic/views")]
        Task<RepositoryViewsModel> GetRepositoryViewStatistics(string owner, string repo);

        [Get("/repos/{owner}/{repo}/traffic/clones")]
        Task<RepositoryClonesModel> GetRepositoryCloneStatistics(string owner, string repo);

        [Get("/login/oauth/access_token")]
        Task<GitHubToken> GetAccessToken([AliasAs("client_id")] string clientId, [AliasAs("client_secret")] string clientSecret, [AliasAs("code")] string loginCode, [AliasAs("state")] string state);
    }
}
