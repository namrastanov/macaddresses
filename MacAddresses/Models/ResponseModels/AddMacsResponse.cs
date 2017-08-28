using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacAddresses.Models.ResponseModels
{
    public class AddMacsResponse: BaseResponse
    {
        public int AddedCount { get; set; }
    }
}