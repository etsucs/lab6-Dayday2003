
ShowCharacter();

void ShowCharacter()
{
System.Console.WriteLine("Enter a word");
string word = System.Console.ReadLine();
System.Console.WriteLine("Enter a number corresponding with the letter in your word");
string number = System.Console.ReadLine();
System.Console.WriteLine($"Your word is {word} and you number is {number}.");
Convert.ToInt32(number);
char letter = word[Convert.ToInt32(number) -1 ];
System.Console.WriteLine(letter);
}

celcius();

void celcius()
{
System.Console.WriteLine("Enter temperature in farenheit.");
double fahrenheit = double.Parse(System.Console.ReadLine());
double conversion = (fahrenheit - 32) * 5/9;
System.Console.WriteLine($" The temperature is celcius is {Math.Round(conversion, 2)} degrees.");
 const int MinTemp = 80;
    const int MaxTemp = 101;
    for(int i = MinTemp; i < MaxTemp; i++)
    {
        int f = (i - 32 ) * 5 / 9; 
        System.Console.WriteLine(("\t") + i + "\t\t" + f);
    }


}



CalculateRetail();

void CalculateRetail()
{
System.Console.WriteLine("Enter the wholesale cost");
string wholesale = System.Console.ReadLine();
System.Console.WriteLine("Enter the markup percentage as a decimal");
string markup = System.Console.ReadLine();
double retail = double.Parse(wholesale) * double.Parse(markup) + double.Parse(wholesale);
System.Console.WriteLine($"The retail price is ${Math.Round(retail, 2)}");
}



IsPrime();

 void IsPrime()
{
System.Console.WriteLine("Enter a number ");
int number = Int32.Parse(System.Console.ReadLine());

    int n = number, a = 0;
        for (int i = 1; i <= n; i++){
            if(n % i == 0 ){
                a++;
            }

            if(a == 2 ){
                System.Console.WriteLine($"{number} is a prime number", n);
            }
            else {
                System.Console.WriteLine($"{number} is not a prime number");
            }
        }
}

