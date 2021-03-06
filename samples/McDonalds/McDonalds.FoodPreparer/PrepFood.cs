﻿using System;
using System.Threading;
using McDonalds.Messages;
using ServiceConnect.Interfaces;

namespace McDonalds.FoodPreparer
{
    public class PrepFood : IMessageHandler<PrepFoodMessage>
    {
        private readonly IBus _bus;

        public PrepFood(IBus bus)
        {
            _bus = bus;
        }

        public void Execute(PrepFoodMessage message)
        {
            Console.WriteLine("Preping order: BunSize - {0}, OrderId - {1}", message.BunSize, message.CorrelationId);

            Thread.Sleep(2000);

            Console.WriteLine("Preping done for order - {0}", message.CorrelationId);

            _bus.Publish(new FoodPrepped(message.CorrelationId));
        }

        public IConsumeContext Context { get; set; }
    }
}