using System.Collections.Generic;

namespace Recipe
{
    public class Recipe
    {
        private string name;
        public string Name { get; set; }      
        
        private List<Ingredient> ingredientList = new List<Ingredient>();

        public List<Ingredient> IngredientList
        {
            get { return ingredientList;}
            set { ingredientList = value;}
        }
        
        public Recipe(string name)
        {
            Name = name;
            
        }
        public Recipe()
        {
            
        }
        public override string ToString()
        {
            return $"{Name} ";
        }
        
    }

}