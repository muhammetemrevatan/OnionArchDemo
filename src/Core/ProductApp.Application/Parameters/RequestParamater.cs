using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Parameters
{
    public class RequestParamater
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public RequestParamater(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
