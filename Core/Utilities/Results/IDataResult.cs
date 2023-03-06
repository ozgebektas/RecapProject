using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //IDataResult bir bool değeri,message değeri ve data belirtecek.
    //zaten ikisini biz voidler için yaptığımız IResult ta var .Tekrar yazmamak için inheritance aldım
  public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
