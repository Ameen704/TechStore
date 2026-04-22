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
*(قم بإضافة صور للمشروع هنا بعد رفعه)*

---

### How to Run Locally (طريقة تشغيل المشروع):
1. قم بنسخ المستودع (Clone the repository).
2. تأكد من تعديل الـ `ConnectionStrings` في ملف `appsettings.json` ليتوافق مع الـ SQL Server الخاص بك.
3. افتح الـ Package Manager Console وقم بتشغيل الأمر: `Update-Database` لإنشاء الجداول.
4. قم بتشغيل المشروع باستخدام Visual Studio (أو `dotnet run`).
