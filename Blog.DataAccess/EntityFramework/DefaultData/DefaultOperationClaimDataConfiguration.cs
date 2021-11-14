using Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework.DefaultData
{
    public class DefaultOperationClaimDataConfiguration : IEntityTypeConfiguration<OperationClaim>
    {

        void IEntityTypeConfiguration<OperationClaim>.Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            List<OperationClaim> operationClaim = new List<OperationClaim>
            {
                    new OperationClaim(){ Id=1, Name = "Admin", Status = true, UpdateDate = DateTime.Now },
                    new OperationClaim(){ Id=2, Name = "User", Status = true, UpdateDate = DateTime.Now },
                    new OperationClaim(){ Id=3, Name = "Blogger", Status = true, UpdateDate = DateTime.Now },
                    new OperationClaim(){ Id=4, Name = "E-Blogger", Status = true, UpdateDate = DateTime.Now }

            };
            builder.HasData(operationClaim);

        }



    }
}
