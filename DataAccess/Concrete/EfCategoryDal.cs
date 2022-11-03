﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Data;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<PortalStoreDbContext, Category>, ICategoryDal
    {
    }
}
