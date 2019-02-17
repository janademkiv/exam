using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.IO; 

namespace ConsoleApplication24 
{ 
class Program 
{ 

//struct NameIn { 

// public String name; 
// public String surname; 
// public String lastname; 

// //public NameIn(string a, string b, string c) 
// //{ 
// // name = a; 
// // surname = b; 
// // lastname = c; 
// //} 


// } 



static void Main(string[] args) { 

//NameIn user = new NameIn(); 
// ввод фио 
//Console.WriteLine("Введите имя"); 
//string name = Console.ReadLine(); 

//Console.WriteLine("Введите Отчество"); 
//string sname = Console.ReadLine(); 

//Console.WriteLine("Введите фамилию"); 
//string fname = Console.ReadLine(); 

////NameIn user = new NameIn(name, sname, fname); 

//Console.WriteLine("Вызов метода из контсруктора NameIn"); 
//DisplayInfo(); 
//// 
//Console.WriteLine("Вызов метода Ввод фио"); 
//string name; 
//string surname; 
//string middlename; 
//nameFio(out name, out surname, out middlename); 

//Console.WriteLine(name); 
//Console.WriteLine(surname); 
//Console.WriteLine(middlename); 
//Console.WriteLine(); 


//Console.WriteLine("Вызов метода gift"); 
//Console.WriteLine(gift()); 
//String y = gift(); 
//Console.WriteLine("Запись"); 
//readerFile(); 

readerFile(); 
Console.ReadKey(); 
} 


//static void DisplayInfo() { 
// NameIn user = new NameIn(); 
// //String a = "Имя студента " + user.name + " " + " " + user.surname + " " + " " + user.lastname; 
// Console.Write("Имя студента " + user.name + " "); 
// Console.Write(" " + user.surname + " "); 
// Console.Write(" " + user.lastname); 

//} 

static void nameFio(out string name, out string surname, out string middlename) 
{ 

name = tryParseString("Введите ваше имя"); 
surname = tryParseString("Введите вашу фамилию"); 
middlename = tryParseString("Введите ваше отчество"); 
} 

static string tryParseString(string a) 
{ 
Console.WriteLine(a); 
while (true) 
{ 
try 
{ 
string s = Console.ReadLine(); 
proverka(s); 
return s; 
} 
catch (Exception) { Console.WriteLine("Ваше введение данные содержат цифры. Попробуйте еще раз."); } 
} 
} 

static void proverka(string s) 
{ 

int[] cifri = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
foreach (int cifr in cifri) { 
bool sodergit = s.Contains(cifr.ToString()); 

if (sodergit) 
{ 
throw new Exception(); 
} 
} 

} 
//static String nameIn(string wordIn) { 
// Console.WriteLine(wordIn); 
// //try { 
// //int [] numb = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}; 

// String name = Console.ReadLine(); 
// return name; 
// //}catch(Exception){Console.WriteLine( "В введеных данных присутствует цифры")} 



//} 

//static void interF() { 



//} 

//static void inPrint(string[] arr) { 
// for (int i = 0; i < arr.Length; i++) 
// { 
// Console.WriteLine("Введи {0} свою фамилию; ", i); 
// string sname = Console.ReadLine(); 
// arr[i] = sname; 
// } 
//} 

//static void inFIO(out string name, out string sname, out string lname) 
//{ 
// Console.WriteLine("Введите полностью ваше ФИО."); 
// name = nameIn("Введите ваше Имя"); 

// sname = nameIn("Введите ваше Фамилию"); 

// lname = nameIn("Введите ваше Отчество"); 


//} 



static string gift() { 
Console.WriteLine("Выберете подарок"); 
string[] gifts = new string[5]; 

for (int i = 0; i < gifts.Length; i++) { 

gifts[0] = "Машина"; 
gifts[1] = "Дом"; 
gifts[2] = "Квартира"; 
gifts[3] = "Коробка конфет"; 
gifts[4] = "Зачет"; 
int l = int.Parse(Console.ReadLine()); 
switch (l){ 
case 0: String w = gifts[0] = "Машина"; 
return w; 
case 1: String t = gifts[1] = "Дом"; 
return t; 
case 2: String s = gifts[2] = "Квартира"; 
return s; 
case 3: String x = gifts[3] = "Коробка конфет"; 
return x; 
case 4: String y = gifts[4] = "Зачет"; 
return y; 
} continue; 

} 
return " "; 
} 


static void readerFile() 
{ 

//StreamWriter Fq = new StreamWriter(); 
//gift(); 
//NameIn user = new NameIn(); 
String y =
 
Convert.ToString(gift()); 
//String y = gift(); 

//String g = user.name; 
////String h = user.surname; 
////String e = user.lastname; 

////String y = "ghbfgdfgdf"; 
////String g = "thhhdrtyryhhydh"; 

string name; 
string surname; 
string middlename; 
nameFio(out name, out surname, out middlename); 


StreamWriter F1 = new StreamWriter("proba.txt"); 
F1.WriteLine(name + " " +" " + surname + " " + middlename + " " + "Подарок студента" + " " + y); 
//F1.WriteLine(p); 
F1.Close(); 
//StreamReader FR = new StreamReader("proba.txt"); 
//while (!FR.EndOfStream) 
//{ 
// Console.WriteLine(FR.ReadLine());//endofstr смотрит конец 
//} 
//FR.Close(); 

Console.ReadKey(); 
} 

//switch (i) 
//{ 
// case 0: String t = "Машина"; 
// break; 
// case 1: String y = "Машина"; 
// break; 
// case 2: String t = "Машина"; 
// break; 
// case 3: String t = "Машина"; 
// break; 
//} 
// } 

//} 

// return x; 
//} 



//static int numbIn(int x) { 


// return x; 
//} 
} 
}
