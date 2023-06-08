using ROV_TL.Models;

namespace ROV_TL
{
    public interface IDBCode
    {
        User GetUserById(int id);
        Car GetCarById(int id);
        Vio GetVioById(int id);
    }

    internal class DBCode : IDBCode
    {
        public User GetUserById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(u => u.Id == id).First();
            return user;
        }

        public Car GetCarById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            Car car = db.Cars.Where(c => c.CarId == id).First();
            return car;
        }

        public Vio GetVioById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            Vio vio = db.Violations.Where(v => v.VioId == id).First();
            return vio;
        }
    }
}
