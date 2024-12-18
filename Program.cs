namespace StringExample
{
    class Program
    {
        static void Main()
        {
            // String literals (automatically interned)
            string literal1 = "hello";
            string literal2 = "hello";

            // Dynamically created string (not automatically interned)
            string dynamicString = new string("hello".ToCharArray());

            // Explicitly intern the dynamic string
            string internedString = string.Intern(dynamicString);

            // Comparing references
            Console.WriteLine(Object.ReferenceEquals(literal1, literal2)); // True (same instance)
            Console.WriteLine(Object.ReferenceEquals(literal1, dynamicString)); // False (different instances)
            Console.WriteLine(Object.ReferenceEquals(literal1, internedString)); // True (interned matches the pool)
        }
    }
}
