
using Microsoft.AspNetCore.Mvc;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.ViewComponents
{
    public class LastEducationViewComponent : ViewComponent

        
    {
        public IViewComponentResult Invoke()
        {

            var LastEducation = new List<LastEducation>
            {

                new LastEducation(1,"آموزش گیت و گیت هاب در اندروید","git_github.png","https://faradars.org/courses/git-and-github-in-android-studio-fvand0103","گیت یک نوع سیستم کنترل ورژن (VCS) است که در میان برنامه‌نویسان برای مدیریت‌های کدهای خود استفاده می‌‌شود و توانایی کار با این ورژن کنترل برای همه برنامه‌نویس‌ها بسیار مهم است، زیرا با یادگیری این ورژن کنترل دیگر نگران از دست رفتن کدها و چگونگی استفاده از آن برای کارهای تیمی نخواهیم بود."),
                new LastEducation(2,"آموزش  تزریق وابستگی در اندروید","dependency.png","https://faradars.org/courses/dependency-injection-in-android-fvand301","تزریق وابستگی (Dependency Injection) در برنامه‌نویسی، یک الگوی طراحی است که برای کاهش وابستگی بین کلاس‌ها و افزایش قابلیت تست و نگهداری کد استفاده می‌شود. در این الگو، وابستگی‌های یک کلاس، به جای تولید درون کلاس، از بیرون به کلاس تزریق می‌شو"),
                new LastEducation(3,"آموزش پروژه محور کتابخانه room ","notpad_app.png","https://faradars.org/courses/build-notepad-application-using-room-library-in-android-fvprm009","هدف از این آموزش، آشنایی با نحوه ذخیره کردن داده‌ها در دیتابیس Room و همچنین نمایش دادن آن‌ها در کنار اعمال ویرایش و حذف است. همچنین شما در این آموزش می‌توانید نحوه دو زبانه کردن اپلیکیشن را یاد بگیرید. بدین‌منظور، پروژه کاربردی دفترچه یادداشت در نظر گرفته شده تا مخاطب بتواند با کاربرد دیتابیس روم (Room) به طور عملی آشنا شود و بعد از آن بتواند در پروژه‌های دیگر خود از آن استفاده نماید. با استفاده از کتابخانه Room نیاز نیست کدهای طولانی SQLite را ایجاد نمایید و خیلی راحت و سریع می‌توانید دیتابیس برای اپلیکیشن خود ایجاد کنید.")
            };

            return View("~/Views/Home/Component/LastEducation/_LastEducations.cshtml",LastEducation);
        }

    }
}
