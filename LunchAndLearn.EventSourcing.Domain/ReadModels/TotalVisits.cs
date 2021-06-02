﻿using System;
using System.Collections.Generic;
using System.Linq;
using LunchAndLearn.EventSourcing.Domain.Events;

namespace LunchAndLearn.EventSourcing.Domain.ReadModels
{
    public class TotalVisits
    {
        public int Count { get; private set; }

        public static TotalVisits Replay(ICollection<object> events)
        {
            var entity = new TotalVisits();

            foreach (var e in events)
            {
                entity.Apply((dynamic)e);
            }

            return entity;
        }

        private void Apply(PatientArrivedEvent e)
        {
            Count++;
        }

        private void Apply(object e)
        { }
    }
}