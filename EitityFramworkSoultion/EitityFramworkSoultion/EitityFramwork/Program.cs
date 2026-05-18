namespace EitityFramwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
         AppDbContext db = new AppDbContext();
         student s1 = new student();
         courses c1 = new courses();

            s1.name = "Widaad";
            s1.age = 27;

            db.Add(s1);
            db.SaveChanges();

        }
    }
}
