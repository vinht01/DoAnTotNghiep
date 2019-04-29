using System;
using System.Collections.Generic;
using System.Text;
using ShopBanGiay.Data.Enums;

namespace ShopBanGiay.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
