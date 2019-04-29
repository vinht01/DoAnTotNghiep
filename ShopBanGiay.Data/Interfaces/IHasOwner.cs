using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBanGiay.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}
