using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Utils.AddFile
{
    public class AddFileParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var fileParameter = new OpenApiParameter
            {
                Name = "file",
                In = ParameterLocation.Query,
                Required = true,
                Description = "Upload Excel file"
            };

            operation.Parameters.Add(fileParameter);
        }
    }

}
