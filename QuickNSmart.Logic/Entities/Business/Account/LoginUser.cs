﻿//@QnSBaseCode
//MdStart
using CommonBase.Extensions;
using QuickNSmart.Contracts.Persistence.Account;
using QuickNSmart.Logic.Entities.Persistence.Account;

namespace QuickNSmart.Logic.Entities.Business.Account
{
    partial class LoginUser
    {
        public IRole CreateRole()
        {
            return new Role();
        }
        public void AddRole(IRole role)
        {
            role.CheckArgument(nameof(role));
        }
        public void RemoveRole(IRole role)
        {
            role.CheckArgument(nameof(role));
        }
    }
}
//MdEnd