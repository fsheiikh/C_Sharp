# EpicU4-FarhanS

#Deployed Apps <hr>
http://430-farhan.vm.epicservers.com/ <br>
http://430-farhan.vm.epicservers.com/casino <br>
http://430-farhan.vm.epicservers.com/darts2 <br>
http://430-farhan.vm.epicservers.com/war <br>
http://430-farhan.vm.epicservers.com/final


https://github.com/fsheiikh/fsheiikh.github.io <--repo<br>
https://fsheiikh.github.io <--links for html pages


<hr>
#Cheat Sheet
9/10

Data Types(CS-ASP_007):
_______
Comments: // or /**/
Data Types: int, string, double(like float), bool(boolean)
|_> is.gd/data_types


Data Types Conversion (CS-ASP_008)
==================================
9/14

Implicit conversions - smaller type to longer type, without data loss, "upcasting"

Explicit conversions - require developer interventions, possibility of data loss, "downcasting", either in teh form of casting or helper method.

Casting Numbers: 
int myInteger = (int)myDouble;

Numbers to strings:
string myString = myInteger.ToString();

String to Numbers: 
int myInteger = int.Parse(myString);



Arithmetic Operators (CS-ASP_009)
==================================
9/14

Math Operators + - * /

Adding Assignment
total = total + 5;
total += 5

Increment Operator; i++;
decrement Operatot; i--;

Beware of order of precedence(use parenthesis)
Beware of down casting (precision loss)
Beware of overflow(use bigger types)

TO make overflow throw an exception:

checked 
{
  //some checked arithmetic that could overflow maybe
}


C# Syntax (CS-ASP_010)
==================================
9/14

Operands- varibale names, object/server control names, literals - "Nouns" (YOU NAME tTHESE)

Operators - "Verbs".... they act on th eoperands

Expressions - One or more operands and sero pr more operators that evaluate to a single value

Statements - A complete instrution - asignmnet of an expression to a variable, an incrememnt/decremet , etc.

C# Conditionals (CS-ASP_011)
==================================
9/18

Assignment "="
Equality "=="

if(a == b){
  //EXECUTE WHEN EXPRESSION IS TRUE
}
else{
  //execute when false
}

....or... evaluate mutaully exclusive options

if(a==b){ //some code}
else if(a==c){// some code}
else{//catch all}

CheckBox server control:
has 'Checked' prooperty 

RadioButton server Control:
has property 'Checked'

C# ternary Operator (CS-ASP_012)
==================================
9/18

shortcut for evaluatingan expression.

if else format can be reduced to 

result = (a ==b) ? "equal" : "not equal";


C# Comparison And Logical Operator (CS-ASP_013)
==================================
9/18

used fo rconditional statements

==
!=
<>
<=  =>
!someBooleanvalue - means testing for NOT is true

Logica Operators
used to combin multiple expressions for evaluation

&& - AND
|| - OR

Combine with () for order of presedence

C# Dates and Times (CS-ASP_014)
==================================
9/18

Creating new DateTime objects
DateTime myDateTime = DateTime.now;
DateTime myDateTime = DateTime("12/7/1969");

Formatting ..  mnay options

myDateTime.to____()

Retrieveing Parts:

myDateTime.Year// return int
myDateTime.hour / return int
myDateTime.DayOfWeek / return string
etc...

DateTime Math:
myDateTime.AddHour(2)
myDateTime.Add__(#)

"Chaining" - using multiple helper methods together with dot operator

myDate.AddHour(3).AddMinute(-5).ToString();


C# Span Time (CS-ASP_015)
==================================
9/18

Create and initialize TimeSpan

//Days.Hours:Minutes:Seconds.Milliseconds
Timespan myTimeSpan = TimeSpan.parse("1.2:3:30.5");

DateTime myBirthday = DateTime.Parse("12/7/1969");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

More info at http://is.gd/timespan

Get individual parts og timespan

myAge.Hours
myAge.___

...or get TOTAL elapse time

myAge.TotalHours //returns double
myAge.Total____ //"


C# Single Dimensional Arrays (CS-ASP_021)
==================================
9/21

Indexes vs. Elements 
Accessor vs. Stored Values
Indexes are zero based

Declaring Arrays
string[] myArray = new string[3]; 

Declaring and INitilaizing Arrays
string[] myArray = new string[3] {"Moe", "Larry", "Sam"}

Setting/Getting values 
string myString = myArray[1]; //Retrive the second value
myArray[0] = myString; // Sets first elemets

C# Multi Dimensional Arrays (CS-ASP_022)
==================================
9/21

Same as single dimensional ... jst requiures more indexes (in dimesnions ) to get th eelemts

double[,] myArray = new double[2, 3]; // contains 6 elements
int[,,] rubicsCube = new int[3,3,3]; // comtains 27

rubicsCube[0,1,2] = 42;
myInteger = rubicsCube[0,1,2];


C# Changing length of array (CS-ASP_023)
==================================
9/21

Arrays are immutable - cannot be changed in memory
HOWEVER .NET framework provides helper methods to resize an array ... 
creates a new array and copies the old values into it.

Array.REsize(ref myArray, myArray.Length + 1);

// Get the highest index: 
int highestIndex = myArray.GetUpperBound(0);
//0 = dimension we want to retrive the upper boundary for

//Arrays have other helper methods 
myArray.Sum()
myArray.Min()
myArray.Max()
myArray.Average()
myArray.Sort()
myArray.Reverse()

Travis demo
====

public string firstName 
{
  get {return TextBox1.Text;}
  set{TextBox1.Text = value;}
}

var x = firstname;
Firstnmae = "Trvais";


C# Looping with for iteration(CS-ASP_026)
==================================
9/24

Snippet for[tab][tab]

for(int i ; i< 10 ; i++){
  //your code here
}

i - any variable name

1st part - counter declaration, can be initilaized to any number 
2nd part - condition, can be any expression that equates to a bool
3rd part - increment i++/ decremedn i--, can step more 1 using i++;

string[] name = new string[] {"Goku", "naruto", "Yugi"};

for (int i = 0; i < names.length; i++){
  if(name[i] == "Goku"){
    //
  }
}



C# Looping with wile and do while iteration (CS-ASP_027)
==================================
9/24

Random random = new Random();
//random.Next(lowerBounds, upperBounds)

random.Next(1, 100);

while(someexpression == true){
  //code that would affect whether

}

do{
  //something at least once
  // will run again if while runs true
}while(someexpression == true)


C# Creating overloaded methods (CS-ASP_031)
==================================
9/24

Different method signature, but same basic function
METHOD SIGNATURE ... the number and type of parameters
Can have different return types

C# Creating Optional Parameters (CS-ASP_032)
==================================
9/24

POtional paramteres provide default values when you define the method. SO if you dont supply a value the dfault wil be used

private void myMethod(string myRequiredParam, int optionalParam =1, int myOtherOPtionalParam =5);

//CAn be called
myMethod("Hello Required Param");

myMethod("Hello Required Param", 100);

myMethod("Hello Required Param". 100, 500);

//you cannot skip an optional parameters

myMethod("Hello Required Param", , 500); //Error


C# Pasing Named Arguments Into Input Parameters (CS-ASP_033)
==================================
9/24

Allow us to sedn in a paramter arguments OUT OF ORDER
WE just prefix the input paramter argument with the name
of the paramter were passing in, a colon, then the value:

myMethod(myOTherOptionalParam: 500,
        myRequiredParam: "Hello requried param",
        myOptionalParam: 100);
        
        //YOu stil have to pass the reuwqired param
        
        
        
C# Creating Methods with output Parameters (CS-ASP_034)
==================================
9/24      

Allows you to return a value the normal way AND return a value via a method paramterL

private bool myMethod(string myREquiredParam,
                      out int myOptionalParam) {}


int myValue = 0;
if (myMethod("Some required TExt", out myValue)) return "Hello World";
                      
                      
                      
C# Manipulating Strings (CS-ASP_035)
==================================
9/28

//Escape double quotes
string myString = "This is a double quote \".";

//Accessing a specific char;
myString[2]

//StartsWith(), EndsWith(), Contains()
//Check to see if a given sring has a set of
// charcters beginning, end or has something inside.
//Return True/False

//IndexOf()
//Find the index for one string inside of 
//anothe string
int myIndex = myString.IndexOf("howdy");

//Insert(), Remove()
//Insert adds characters starting at a given index
//Remove removes charcters starting at a given 
//index, and all the way through the length you input.

//Substring()
//REtrive charcters beginning at a given index
//all the way through the length you input

//Trim(), TrimStart(), TrimEnd()
//Remove space charatcers

//PadLeft(), PadRight()
//Allow you to pad with a charcter with a length
someValue.PadLeft(10, '*')

//ToUpper(), ToLower()
//Important! Compare two strings regardles of the case

//Replace()
//Replace an occurence of a string with something else
myString.Replace("REplace me", myValue);

//Split()
//splits on somehting into an array 

StringBuilder
//efficent way to concatenate strings


C# Intro to classes and objects (CS-ASP_036)
==================================
10/1

Class is a code block that defines a data type
An object is an instance of a class

Metaphors:
Blueprint vs Houses
Recipe vs Cupcakes
Pattern s Bluejeans
Cookie Cuttervs Cookies

Classes have members, like properties and mthods

prop tab initiates peoptery setting

C# Understanding Namespaces and the unsing Directives (CS-ASP_040)
==================================
10/5

Namespace organizes class naems inside of the class libararies or applications.

You must retrieve class names by their full name:

System.Text.Stringbuilder sb = new System.Text.StringBuilder();

.....or, you can employ a using directive at the top of the code file to 
instruct the compiler to look 

StringBuilder sb = new StringBuilder();

YOu must alwaysdo this if te code you re writing is outside
of the namespace of the class you want to use, even if its n the same
project.

Deafult 

C# Working with the List Collecton (CS-ASP_046)
==================================
10/8

use generic collections to work with items in a strongly typed fashion.

Btter than arrays:
Know the  type of item for a certainty, no castng/converting
Better performance inserting / removing / updating
Collections provide more flexible options to access items in the collecito.
Allows for LINQ extension methods

Many differect types of collections - specialties

"Generic Collections"
List<T>
Dictionary<Tkey, Tvalue>
t=> data type you need 
"You make a generic specific by providing a data type"

List<string> - only store strings (strongly typed)
List<Car> - only store Cars in that collection

//Assume I have three objects : car1, car2, car3
List<Car> car = new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);

int numberOfCars = cars.Count;
Car myCar = cars.ElementAt(1); //return secodn car in collection

//Terminology: You access a MEMBER of a collection, you access a ELEMENT of an array

//LINQ queries 


C# Object Initializer (CS-ASP_047)
==================================
10/8

Concise way to initilaize a new object (or collection) with values.

//Didn't talk about this form: 

Car car1 = new Car() {Make = "BMW", Model = "528i", Year= 2010, Color = "Black"};

//no local variable name fo rthe new CAr instacne needed!
cars.Add(new Car() {Make = "BMW", Model = "528i", Year= 2010, Color = "Black"});


C# Collection Initializer (CS-ASP_048)
==================================
10/8

Shortcut to create a new instance of a generic collection AND initilaze it by 
IMMEDIATELY adding new instances of a given type.

List<Car> cars = new List<Car>(){
  new Car{Make="BMW", Model="528i", Color="Black", Year="2010"},
  new Car{Make="BMW", Model="528i", Color="Black", Year="2010"},
  new Car{Make="BMW", Model="528i", Color="Black", Year="2010"},
};



Working with the Dictionary<TKey, TValue> Collection (CS_ASP_049)
=================================================================
Dictionary allows you to use a key to access a memeber of the collection.
Think: Webster Dictionary .... the word (key), then the definition (instance of a given type)
Key is anything meaningful in YOUR system
Key must be unique 

TKey => type of they key 
TValue => Type of the value

Dictionary<string, Car> car = new Dictionary<string, Car()>;
cars.Add("V123", new Car{Make="BMW", Model="528i", Color="Black", Year="2010"});
cars.Add("V234", new Car{Make="BMW", Model="528i", Color="Black", Year="2010"});
cars.Add("V345", new Car{Make="BMW", Model="528i", Color="Black", Year="2010"});

cars.ElementAt(1).Key // Return "V234"
cars.ElementAt(1).Value // Returns the Car object in teh 2nd position

//Better wya to acess Dictionary
Car v2;
if(car.TryGetValue("V234", out v2))
{
  result += v2.Year ...; 
}

//Remove an item 
if(cars.Remove("V345"))
{
  result += "Succesfuly removeed car";
}


Looping with a foreach Iteration Statement (CS-ASP_050)
==========================================================
More elegant way of iterating through collections.

Code snippet: foreach [tab][tab]

foreach(Car car in cars) {
  result += car.Make;
}


Implicitly Typed Local variables with the 'var' Keyword (CS-ASP_51)
==================================================================
(Applies to locally scoped variable declarations)
COmpiler is smart enough to figure out the data type when you initilaze the variable.
Becomes increasingly important because sometimes its difficult to know what the data 
type is supposd to be . (LINQ)

int hitPoints = 0;
.... is the equivalent of ....
var hitPoints = 0;

string heroName = "Pentagorn";
...is teh equivalent of ...
var heroName = "Pentagorn"

var Cars = new List<Car>
{
...

}

Rules: 
1. Must initilize the variable.
2. Variable is permamently set to the implicit data type.
3. Can't be used for a PUBLIC property / variable

















