﻿using System;

namespace LunchAndLearn.EventSourcing.Domain.Events
{
    public class HospitalEntryCreatedEvent
    {
        public string Hospital { get; }
        public DateTime Timestamp { get; }

        public HospitalEntryCreatedEvent(string hospital, DateTime timestamp)
        {
            Hospital = hospital;
            Timestamp = timestamp;
        }
    }
}