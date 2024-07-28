﻿using System.Threading.Tasks;

namespace YEDUSO.EA
{
    public interface IHandleAsync : IEvent
    {
    }

    public interface IHandleAsync<in T> : IHandle
    {
        Task HandleAsync(T message);
    }
}