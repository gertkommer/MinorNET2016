﻿using Minor.Dag56.BlackJack.Domain;
using Minor.WSA.Common.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minor.Dag56.BlackJack.Common.Events
{
    public class PlayerHitsEvent : DomainEvent
    {
        public Card Card { get; set; }

        public PlayerHitsEvent(Card card)
        {
            Card = card;
        }
    }
}
