﻿using Microsoft.AspNet.Identity.EntityFramework;
using Promact.Erp.DomainModel.Models;
using System.Data.Entity;

namespace Promact.Erp.DomainModel.Context
{
    public class PromactErpContext : IdentityDbContext<ApplicationUser>
    {
        public PromactErpContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        /// <summary>
        /// Added table of LeaveRequest on Database PromactErpContext
        /// </summary>
        public DbSet<LeaveRequest> LeaveRequest { get; set; }

        public static PromactErpContext Create()
        {
            return new PromactErpContext();
        }
    }
}