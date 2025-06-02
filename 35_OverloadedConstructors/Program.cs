namespace _35_OverloadedConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloaded constructors = technique to create multiple constructors,
            //                          with a different set of parameters.
            //                          name + parameters = signature

            Pizza pizza = new Pizza("suffed crust", "red sauce", "mozzarella", "pepperoni");
            //we can change bcuz some people doesnt want cheese, or toppings, etc.


            Console.ReadKey();
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}
