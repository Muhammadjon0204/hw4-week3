
using hw2;
System.Console.WriteLine();
System.Console.WriteLine("================PhotoBook Manegment================");
System.Console.WriteLine();

PhotoTest photoTest=new PhotoTest();
System.Console.WriteLine($"Standart photo book : {photoTest.photoBook1.GetNumPages()} pages");
System.Console.WriteLine($"Custom photobook : {photoTest.photoBook2.GetNumPages()} pages");
System.Console.WriteLine($"Big photobook : {photoTest.bigPhotoBook.GetNumPages()} pages");


