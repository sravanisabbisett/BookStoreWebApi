﻿using commonLayerr.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ICustomerBL
    {
        bool AddCustomerDetails(CustomerDetails customerDetails);
    }
}
