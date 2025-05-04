namespace CarManager.Models
{
    class Car
    {
        public string Id { get; private set; }
        public string Plates { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string Color { get; set; }
        public int year { get; set; }

        public Car(string id, string plates, int brandId, int modelId, string color)
        {
            this.Id = id;
            this.Plates = plates;
            this.BrandId = brandId;
            this.ModelId = modelId;
            this.Color = color;
        }

        public void CreateCar()
        {
            Console.WriteLine("Carro creado");
        }

        public void EditCar()
        {
            Console.WriteLine("Carro editado");
        }
    }
}