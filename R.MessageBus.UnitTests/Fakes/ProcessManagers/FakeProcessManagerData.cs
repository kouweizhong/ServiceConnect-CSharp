﻿using System;
using R.MessageBus.Interfaces;

namespace R.MessageBus.UnitTests.Fakes.ProcessManagers
{
    public class FakeProcessManagerData : IProcessManagerData
    {
        public Guid CorrelationId { get; set; }
    }
}