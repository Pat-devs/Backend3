// method overloads

// overloads in built in methods
//Console.WriteLine("Hi"); // WriteLine can take a string (this is one overload)

//Console.WriteLine(1234); // another overload

//Console.WriteLine('A'); // another overload 


static void Greet(string data)
{
    Console.WriteLine(data);
}

static void Greet(int data)
{
    Console.WriteLine(data);
}


Greet("hi there");

Greet(1234);