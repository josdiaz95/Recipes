using System;
using System.Collections.Generic;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipeList = new List<Recipe>(); 
         
            char answer;
            char recipe = '0';
            do
            {
                Console.WriteLine("Recipe name:");
                string recipeName = Console.ReadLine();
                Recipe addNewRecipe = new Recipe(recipeName);
                recipeList.Add(addNewRecipe);
                do
                {
                    Console.WriteLine("What is your ingredient:");
                    string ingredientName = Console.ReadLine();
                    Console.WriteLine("What is the measurement of the ingredient:");
                    string measurementName = Console.ReadLine();
                    Ingredient addNewIngredient= new Ingredient(ingredientName, measurementName);
                    addNewRecipe.IngredientList.Add(addNewIngredient);
                    Console.WriteLine("Add more ingredients? (y/n)");
                    answer = Console.ReadLine().ToLower()[0];
                } while (answer == 'y');

                if (answer == 'n')
                {
                    Console.WriteLine("Would you like to add more Recipes? (y/n)" );
                    recipe = Console.ReadLine().ToLower()[0];
                }

                while (recipe == 'n')
                {
                    Console.WriteLine("Recipes:");
                    foreach (var recipes in recipeList)
                    {
                        Console.WriteLine(recipes);
                        foreach (var ingredient in recipes.IngredientList)
                        {
                            Console.WriteLine(ingredient);
                        }
                        
                    }
                    
                    break;
                }
            } while (recipe == 'y');
            


        }

        
    }
}