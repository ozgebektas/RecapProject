using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static newlenmediği için kullanılacak
   public static class Messages
    {
        public static string Added = "Ürün eklendi";
        public static string NameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Ürünler listelendi";
        public static string ReturnNotNull = "Araba kiralanamaz";

        public static string CarCountOfBrandError = "bir markadan en fazla 10 ürün seçilebilir";
    }
    public static class CarImagesMessages
    {
        public static string CarImageAdded = "Araç'a resim eklendi";
        public static string CarImageDeleted = "Araç'ın resmi silindi";
        public static string CarImageUpdated = "Araç'ın resmi güncellendi";
        public static string CarImagesListed = "Araç resimlerinin tümü listelendi";
        public static string CarImageByIdListed = "Seçilen araç'ın resmi listelendi";
        public static string CarImageLimitExceded = "Görsel limitini aştığınız için daha fazla görsel eklenemiyor.";
    }
}
