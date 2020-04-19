﻿using GameOfLife.CSharp.Engine;
using System;
using System.Threading.Tasks;

namespace GameOfLife.CSharp.Api.Services
{
    public interface IGameOfLifeService
    {
        Generation CreateFromPattern(int userId, int patternId);

        Task<bool> StartGameAsync(int userId, Guid instanceId);

        Task<bool> EndGameAsync(int userId, Guid instanceId);

        Task<Generation> MergeGamesAsync(int userId, Guid firstId, Guid secondId);
    }
}
