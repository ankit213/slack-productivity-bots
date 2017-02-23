﻿using Promact.Erp.DomainModel.ApplicationClass;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Promact.Core.Repository.GroupRepository
{
    public interface IGroupRepository
    {
        /// <summary>
        /// This method used for insert group and return Id. - an
        /// </summary>
        /// <param name="groupAC">pass groupAC</param>
        /// <returns>Primary key(Id)</returns>
        Task<int> AddGroup(GroupAC groupAC);

        /// <summary>
        /// This method used for update group and return Id. - an
        /// </summary>
        /// <param name="groupAC">pass groupAC</param>
        /// <returns>Primary key(Id)</returns>
        Task<int> UpdateGroup(GroupAC groupAC);

        /// <summary>
        /// This method used for get group by id. -an
        /// </summary>
        /// <param name="id">passs group id</param>
        /// <returns>GroupAC object</returns>
        Task<GroupAC> GetGroupById(int id);

        /// <summary>
        /// This method used for check group name is already exists or not.
        /// </summary>
        /// <param name="groupName">passs group name</param>
        /// <param name="groupId">pass group id When check group name is exists at update time
        /// other wise pass 0</param>
        /// <returns></returns>
        Task<bool> CheckGroupNameIsExists(string groupName,int groupId);

        /// <summary>
        /// This method used for get list of group. - an
        /// </summary>
        /// <returns>list of group</returns>
        Task<List<GroupAC>> GetListOfGroupAC();
    }
}
