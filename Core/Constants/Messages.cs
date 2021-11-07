using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Listed = "Listelendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";
        public static string NameInvalid = "İsim geçersiz";
        public static string MaintenanceTime = "Sistem bakımda ";
        public static string DataNotFound = "Veri bulunamadı";
        public static string InvalidExtension = "Geçersiz Format";


        #region User Messages

        public static string PasswordError = "Şifre hatalı";
        public static string AuthorizationDenied = "Yetkin Yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        #endregion
    }
}
