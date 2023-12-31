﻿using Core.DataAccess.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
	public interface IUserDal: IAsyncRepository<User,Guid>,IRepository<User,Guid>
    {
        List<OperationClaim> GetClaims(User user);
    }	
}
