using System;
using RestEase;

namespace RuneSharp.Core
{
    public interface IRuneScapeApi : IDisposable
    {
        [Header("User-Agent")]
        string UserAgent { get; set; }
    }
}