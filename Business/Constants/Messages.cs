using Core.Entities.Concrete;
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
    public static class UserMessages
    {
        public static string UserAdded = "kullanıcı eklendi";
        public static string UserDeleted = "kullanıcı silindi";
        public static string UserUpdated = "kullanıcı bilgileri güncellendi";
        public static string UserNotGetByEmail = "girdiğiniz emaile uygun kullanıcı bulunmmaktadır.";
        public static string PasswordError = "yanlış şifre";
        public static string SuccessLogin = "başarılı giriş";
        public static string UserAlreadyExists="böyel bir kullanıcı zaten var";
        public static string UserRegistered="yeni kullanıcı başarıyla eklendi";
        public static string AccessTokenCreated="token oluşturuldu";
    }
}
