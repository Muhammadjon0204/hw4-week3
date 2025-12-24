
using hw2;
System.Console.WriteLine();
System.Console.WriteLine("================PhotoBook Manegment================");
System.Console.WriteLine();
PhotoBook photoBook=new PhotoBook();

PhotoBook CustomPhotobook=new PhotoBook(24);

PhotoBook bigphotobook=new BigPhotoBook();

System.Console.WriteLine($"Standart photobok pages count: {photoBook.GetNumPages()}");
System.Console.WriteLine($"Custom photobok pages count: {CustomPhotobook.GetNumPages()}");
System.Console.WriteLine($"Big photobok pages count: {bigphotobook.GetNumPages()}");