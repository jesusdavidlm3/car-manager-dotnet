using System;

namespace CarManager
{
    public static class CarManager
    {
        static void Main(string[] args){
            Database db = new Database();
            db.CreateDatabase();
        }
    }
}