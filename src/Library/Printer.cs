using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Printer
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            Recipe myRecipe = new Recipe(); // Crea una instancia de Recipe
            myRecipe.TheSteps(); // Llama al método TheSteps de Recipe
            
        }
    }
}
