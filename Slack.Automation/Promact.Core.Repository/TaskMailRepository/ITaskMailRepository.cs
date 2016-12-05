﻿using Promact.Erp.DomainModel.ApplicationClass;
using Promact.Erp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promact.Core.Repository.TaskMailRepository
{
    public interface ITaskMailRepository
    {
        /// <summary>
        /// Method to start task mail
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userId"></param>
        /// <returns>questionText in string format containing question statement</returns>
        Task<string> StartTaskMailAsync(string userName,string userId);

        /// <summary>
        /// Method to conduct task mail after started
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="answer"></param>
        /// <param name="userId"></param>
        /// <returns>questionText in string format containing question statement</returns>
        Task<string> QuestionAndAnswerAsync(string userName, string answer,string userId);
        
        /// <summary>
        /// This method use to fetch the task mail details.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="UserRole"></param>
        /// <param name="UserName"></param>
        /// <param name="LoginId"></param>
        /// <returns>task mail</returns>
        Task<List<TaskMailUserAc>> TaskMailDetailsReportAsync(string UserId,string UserRole,string UserName,string LoginId);
        /// <summary>
        /// This method getting list of Employees
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns>list of employees</returns>
        Task<List<TaskMailUserAc>> GetAllEmployeeAsync(string UserId);

        /// <summary>
        /// This method use to fetch the selected date task mail details.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="UserName"></param>
        /// <param name="UserRole"></param>
        /// <param name="CreatedOn"></param>
        /// <param name="LoginId"></param>
        /// <param name="SelectedDate"></param>
        /// <returns>task mail</returns>
        Task<List<TaskMailUserAc>> TaskMailDetailsReportSelectedDateAsync(string UserId, string UserName, string UserRole, string CreatedOn, string LoginId, string SelectedDate);
        /// <summary>
        /// This method use to fetch the next and previous date task mail details.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="UserName"></param>
        /// <param name="UserRole"></param>
        /// <param name="CreatedOn"></param>
        /// <param name="LoginId"></param>
        /// <param name="Type"></param>
        /// <returns>task mail</returns>
        Task<List<TaskMailUserAc>> TaskMailDetailsReportNextPreviousDateAsync(string UserId, string UserName, string UserRole, string CreatedOn, string LoginId,string Type);

    }
}
