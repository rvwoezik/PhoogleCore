﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phoogle.MultiTenancy.HostDashboard.Dto;

namespace Phoogle.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}