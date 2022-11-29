
// String Functions //

using StringFunctions;
using System;



//// Reverse
//var reverseText = "Salih";
//Console.WriteLine($"Reverse for {reverseText}: {reverseText.TBReverse()}");


//// Palindrom
//var palindromText1 = "ütü";
//var palindromText2 = "TechBuddy";
//Console.WriteLine($"{palindromText1} palindrom: {palindromText1.TBIsPalindrom()}");
//Console.WriteLine($"{palindromText2} palindrom: {palindromText2.TBIsPalindrom()}");



//var containsText1 = "Salih";
//var containsText2 = "alit";
//Console.WriteLine($"{containsText1} contains {containsText2} is: {containsText1.TBContains(containsText2)}");


//// SubStr
//var subText1 = "TechBuddy";
//Console.WriteLine(subText1.TBSubString(0, 4));
//Console.WriteLine(subText1.TBSubString(4, 25));


//// Replace
//var replaceText1 = "TechBuddy";
//var subText1 = "ssss";
//var subText2 = "Tech ";
//Console.WriteLine($"Replaced: {replaceText1.TBReplace(subText1, subText2)}");



/*
 
PhoneNumber LIKE '05%' -> StartsWith - Max: 2 - 1. Fastest
PhoneNumber LIKE '%05' -> EndsWith   - Max: 2 - 2. Fastest
PhoneNumber LIKE '%05%' -> Contains  - Max: > PhoneNumber.Length

Table;

PhoneNumber - Reversed_PhoneNumber
05301234567 - 76543210350

0530
PhoneNumber LIKE '0530%'

4567
-> Reverse -> 4567 - 7654
Reversed_PhoneNumber LIKE '7654%'


 */




Console.ReadLine();