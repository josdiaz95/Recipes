namespace Recipe
{
    public class Ingredient

    {
        private string name;
        public string Name { get; set; }

        private string measurement;
        public string Measurement { get; set; }
        
        
        public Ingredient(string name, string measurement)
        {
            Name = name;
            Measurement = measurement;
        }
        
        
        public override string ToString()
        {
            return $"{Measurement} {Name}";
        }

     
         
    }
}