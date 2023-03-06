using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        //datayı,işlem sonucu ve mesajı verecek
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
               
        }
        //mesaj istemeyebilir
        public SuccessDataResult(T data):base(data,true)
        {
                
        }
        //datayı default haliyle isteyebilir(çok istenilen bir durum değil)
        public SuccessDataResult(string message):base(default,true,message)
        {
                
        }
        //hiçbir şey istemediği durumda
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
