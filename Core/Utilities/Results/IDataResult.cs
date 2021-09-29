using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //interfacelerin implement edilmesi
        T Data { get; }
    }
}
