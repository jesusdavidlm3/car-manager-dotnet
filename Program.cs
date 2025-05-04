using System;

namespace CarManager
{
    public static class CarManager
    {
        static void Main(string[] args){
            DataBase db = new DataBase();
            db.CreateDatabase();
        }
    }
}