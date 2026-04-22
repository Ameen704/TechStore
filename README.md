# TechStore - E-Commerce Web Application

**متجر إلكتروني (TechStore)**

متجر إلكتروني متكامل لبيع المنتجات التقنية، مبني باستخدام أحدث تقنيات الـ .NET (ASP.NET Core 9 MVC).

## 🚀 المميزات (Features)
- **لوحة تحكم للإدارة (Admin Panel):** لإدارة المنتجات والأقسام بسهولة (إضافة، تعديل، حذف، وعرض).
- **نظام مصادقة (Authentication):** تسجيل دخول وتسجيل مستخدمين جدد باستخدام ASP.NET Core Identity.
- **إدارة الصلاحيات (Authorization):** نظام أدوار (Roles) يفصل بين المشرفين (Admins) والمستخدمين العاديين (Users).
- **تصميم متجاوب (Responsive UI):** واجهة مستخدم متوافقة مع جميع الأجهزة باستخدام Bootstrap 5.
- **أمان البيانات:** تشفير كلمات المرور وحماية الـ Routes من الوصول غير المصرح به.

## 🛠️ التقنيات المستخدمة (Tech Stack)
- **Backend:** C#, ASP.NET Core 9 MVC
- **Database:** SQL Server, Entity Framework Core 9 (Code-First)
- **Security:** ASP.NET Core Identity
- **Frontend:** HTML5, CSS3, JavaScript, Bootstrap 5

## 📸 صور للمشروع (Screenshots)
<img width="589" height="617" alt="1" src="https://github.com/user-attachments/assets/3078c88c-90bb-41f8-84d7-0ba19484a662" /> 
<img width="774" height="613" alt="1 1" src="https://github.com/user-attachments/assets/ff730ed4-4b88-4f2e-867b-82062d4063e3" />
<img width="803" height="549" alt="1 3" src="https://github.com/user-attachments/assets/ecc558f8-9656-4d1c-92d5-1b3c2de78059" />
<img width="803" height="548" alt="1 4" src="https://github.com/user-attachments/assets/4a601393-5e03-4a46-bc85-c23f21478dda" />
<img width="591" height="625" alt="0 11" src="https://github.com/user-attachments/assets/1458c697-be5f-4d38-849c-92dfceff20cd" />
<img width="844" height="547" alt="1 7" src="https://github.com/user-attachments/assets/daf4c92b-2db1-42e3-8d39-15c7f6b226b0" />
<img width="803" height="585" alt="1 6" src="https://github.com/user-attachments/assets/b1b0b903-9e02-4d8d-840a-f03ff41aa3c8" />
<img width="1349" height="617" alt="1 5" src="https://github.com/user-attachments/assets/c7af1a98-baa4-40fc-937c-c9aa3a91c6a6" />
<img width="844" height="587" alt="1 9" src="https://github.com/user-attachments/assets/b40b9b3a-96e6-4f97-8c74-85c13bf91567" />


---

### How to Run Locally (طريقة تشغيل المشروع):
1. قم بنسخ المستودع (Clone the repository).
2. تأكد من تعديل الـ `ConnectionStrings` في ملف `appsettings.json` ليتوافق مع الـ SQL Server الخاص بك.
3. افتح الـ Package Manager Console وقم بتشغيل الأمر: `Update-Database` لإنشاء الجداول.
4. قم بتشغيل المشروع باستخدام Visual Studio (أو `dotnet run`).
