using System;
using System.Collections.Generic;
using System.Text;

namespace Рецепти2.View
{
    public class Display
    {
        public int Input;
        public string Num2;
        public int Choice;
        public int Parse;
        public int RecipeValue;
        public string RecipeName;
        private string Recipes;
        public Display()
        {
            Recipes = new List<RecipeModel>();
            Console.WriteLine("Добре дошли в нашия app! Какво искате да правите?");
            RecipeValue = 0;
            RecipeName = "";
            GetValues();

        }
        
        private void GetValues()
        {
            Console.WriteLine("Добре дошли при нашите рецепти: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Супа");
            Console.WriteLine("2 - Салата");
            Console.WriteLine("3 - Месни ястия");
            Console.WriteLine("4 - Десерт");
            Input = int.Parse(Console.ReadLine());

        }
        public void RecipeName()
        {
            Console.WriteLine("Въведете име на рецепта: ");
            RecipeName = Console.ReadLine();
        }
        public void NewRecipeValue()
        {
            Console.WriteLine($"Въведете стойност на рецепта: {RecipeName} {0}", Recipe.recipe);
            RecipeValue = (Console.ReadLine());
        }
        class Recipe
        {
            public int recipe { get; set; }
            public int name { get; set; }
        }
        public void Input()
        {
            Console.WriteLine("1 - Направете нов запис");
            Console.WriteLine("2 - Покажете всички записи");
            Console.WriteLine("3 - Изчисти конзолата");
            Console.WriteLine("9 - Exit");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was in a correct format");
                Choice = 0;

                
                else
                    throw;
            }
        }
        public void DefaultChoice()
        {
            Console.WriteLine("Грешен избор. Моля изберете на ново");
        }
        public void NewRecipeName()
        {
            Console.WriteLine("Моля въведете име на рецептата");
            RecipeName = Console.ReadLine();
        }
        public void NewRecipeValue()
        {
            Console.WriteLine($"Моля въведете вашата рецепта {IdeaName}");
            RecipeValue = Console.ReadLine();

        }
        public void Successful()
        {
            Console.WriteLine("Вие успешно добавихте нов запис");
        }
        public void AddRecord(RecipeModel recipe)
        {
            Recipes.Add(recipe);
        }
        public void Error(Exception ex)
        {
            Console.WriteLine($"An error occured with the App. Error: {ex.Message}");
        }
        public void ShowAllRecords()
        {
            for (int i = 0; i < ideas.Count;)
        }
    }
}
