using System;
using System.Collections.Generic;
using System.Text;

//namespace Practice
//{
   
//    //var pizza = new Pizza();
//    //pizza.AddIngredient(new Cheddar());
//    //        pizza.AddIngredient(new TomatoSauce());
//    //        pizza.AddIngredient(new Mozzarela());
//    //        Console.WriteLine(pizza.Describe());

//    //        Cheddar cheddar = new Cheddar();
//    //Console.WriteLine(cheddar.Name);

//    //        Ingredient ingredient = new Cheddar();
//    //Console.WriteLine(ingredient.Name);


//    //        var ingredients = new List<Ingredient>
//    //        {
//    //            new Cheddar(),
//    //            new Mozzarela(),
//    //            new TomatoSauce(),

//    //        };

//    //        foreach (Ingredient ingredient in ingredients)
//    //        {
//    //            Console.WriteLine(ingredient.Name);
//    //        }

//public class Pizza
//{
//    private List<Ingredient> _ingredients = new List<Ingredient>();

//    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

//    public override string ToString() => $"This is a pizza with {string.Join(",", _ingredients)}";
//}


//public class Ingredient

//{

//    public override string ToString() => Name;
   
//    public virtual string Name { get; } = "some ingredient";
//    public int PublicField;

//    public string PublicMethod() => "This method is public in an ingredient class";
//    protected string ProtectedMethod() => "This method is protected in an ingredient class";
//}

//public class Cheese : Ingredient
//{

//}

//public class Cheddar : Cheese
//{
//    public override string Name => "Cheddar Cheese";
//    public int AgedForMonths { get; }

//    public void UseMethodFromBase()
//    {
//        Console.WriteLine(ProtectedMethod());
//    }

//}

//public class TomatoSauce : Ingredient
//{
//    public override string Name => "Tomato Sauce";
//    public int TomatoPer100Grams;

//}

//public class Mozzarela : Cheese
//{
//    public override string Name => "Mozzarela";
//    public bool IsLight { get; }

//}

//}
