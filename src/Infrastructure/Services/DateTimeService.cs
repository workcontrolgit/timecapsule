﻿using timecapsule.Application.Common.Interfaces;
using System;

namespace timecapsule.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
