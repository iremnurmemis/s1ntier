﻿
using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
