﻿using System;
using Aula115.Entities.Enums;

namespace Aula115.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
