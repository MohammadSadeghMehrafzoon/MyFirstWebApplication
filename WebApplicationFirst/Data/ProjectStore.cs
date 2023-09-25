using WebApplicationFirst.Models;

namespace WebApplicationFirst.Data
{
    public class ProjectStore
    {

        public static List<Projects> GetProjects()
        {
           return new List<Projects>{

                new Projects(1,"شماره جهانی","با اپلیکیشن شماره جهانی شما می توانید برای تمامی سرویس ها، خیلی سریع و راحت شماره مجازی خریداری کنید","global_number.jpg","https://cafebazaar.ir/app/ir.misterdeveloper.globalnumber"),
                new Projects(2,"خاطرنشان","اپلیکیشن خاطرنشان یک اپلیکیشن برنامه ریزی است که شما از طریق این برنامه می توانید کارهای خود را برنامه ریزی و هدف گذاری کنید","reminder.png","https://cafebazaar.ir/app/com.misterdeveloper.reminder"),
                new Projects(3,"جاسوس باهوش","این اپلیکیشن یک نمونه ساده شده از بازی مافیا است برای دورهمی ها","clever_spy.png","https://cafebazaar.ir/app/com.example.mrspy")


            };
        }


        public static  Projects GetProjectBy(int id)
        {

            return GetProjects().FirstOrDefault(x => x.Id == id);
        }


    }
}
