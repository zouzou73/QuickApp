﻿// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using DAL.Core;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace medicme.Policies
{
    public class ViewRoleByNameRequirement : IAuthorizationRequirement
    {

    }


    public class ViewRoleByNameHandler : AuthorizationHandler<ViewRoleByNameRequirement, string>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ViewRoleByNameRequirement requirement, string roleName)
        {
            if (context.User.HasClaim(CustomClaimTypes.Permission, ApplicationPermissions.ViewRoles) || context.User.IsInRole(roleName))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
