﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmokingCessation.Application.DTOs.Request;
using SmokingCessation.Application.DTOs.Response;

namespace SmokingCessation.Application.Service.Interface
{
    public interface ICoachAdviceLogService
    {
        Task CreateAdviceLogAsync(Guid quitPlanId);
        Task<CoachAdviceLogResponse> GenerateAndSaveDailyAdviceAsync(CoachAdviceLogRequest request);
        Task<CoachAdviceLogResponse> GetLatestAdviceAsync(Guid quitPlanId);
        Task<List<CoachAdviceLogResponse>> GetAllAdvicesByQuitPlanAsync(Guid quitPlanId);
        Task<CoachAdviceLogResponse> GetAdviceByIdAsync(Guid adviceLogId);
        Task<bool> DeleteAdviceAsync(Guid adviceLogId);
        Task<CoachAdviceLogResponse> UpdateAdviceAsync(Guid adviceLogId, string newAdviceText);
        Task<List<CoachAdviceLogResponse>> GetAdviceHistoryByUserAsync(Guid userId);
        Task<List<CoachAdviceLogResponse>> GetAllAdvicesAsync(/* filter/paging params for admin */);

    }
}
