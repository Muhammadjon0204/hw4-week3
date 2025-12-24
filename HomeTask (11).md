## Task 1
### Inheritance of Objects

Create a C# program that prompts the user for three names of people and stores them in an array of `Person`-type objects.             
There will be two people of the `Student` type and one person of the `Teacher` type.             

To do this, follow the steps below:

1. Create a `Person` class with the following:
   - A `Name` property of type string
   - A constructor that receives the name as a parameter
   - Override the `ToString()` method

2. Create two more classes that inherit from the `Person` class:
   - `Student` class:
     - Has a `Study` method that writes `The student is studying` to the console
     - Create a constructor in the `Student` class that calls the parent constructor of the `Person` class
   - `Teacher` class:
     - Has an `Explain` method that writes `The teacher is explaining` to the console
     - Create a constructor in the `Teacher` class that calls the parent constructor of the `Person` class

3. In the main program:
   - Prompt the user for the names of three people and store them in an array of `Person` objects
   - Invoke the `Explain` method for the teacher object
   - Invoke the `Study` method for the student objects

##

Создайте программу на языке C#, которая запрашивает у пользователя три имени людей и сохраняет их в массив объектов типа `Person`.
В массиве должно быть два объекта типа `Student` и один объект типа `Teacher`.

Для выполнения задачи выполните следующие шаги:

1. Создайте класс `Person` со следующими характеристиками:
   - Свойство `Name` типа string
   - Конструктор, принимающий имя в качестве параметра
   - Переопределите метод `ToString()`

2. Создайте еще два класса, которые наследуются от класса `Person`:
   - Класс `Student`:
     - Имеет метод `Study`, который выводит в консоль сообщение `The student is studying`
     - Создайте конструктор в классе `Student`, вызывающий конструктор родительского класса `Person`
   - Класс `Teacher`:
     - Имеет метод `Explain`, который выводит в консоль сообщение `The teacher is explaining`
     - Создайте конструктор в классе `Teacher`, вызывающий конструктор родительского класса `Person`

3. В основной  :
   - Запросите у пользователя имена трех людей и сохраните их в массиве объектов типа `Person`
   - Вызовите метод `Explain` для объекта `Teacher`
   - Вызовите метод `Study` для объектов `Student`

##

Барномаи C# эҷод кунед, ки аз корбар се номи одамонро талаб мекунад ва онҳоро дар массиви объектҳои навъи `Person` нигоҳ медорад. Дар массив ду объекти намуди `Student` ва `Teacher` хоҳанд буд.

Барои ин амалҳои зеринро иҷро кунед:

1. Синфи `Person` бо хосиятҳои зерин эҷод кунед:
    - Хосияти `Name` навъи string
    - Конструкторе, ки номро ҳамчун параметр қабул мекунад
    - Усули `ToString()`-ро корашро дигар кунед кунед (Override).

2. Ду синфи дигар эҷод кунед, ки аз синфи `Person` мерос мегиранд:
    - Синфи `Student`:
      - Усули `Study` дорад, ки ба консол `The student is studying` менависад
      - Дар синфи `Student` конструкторе эҷод кунед, ки конструктори волидайни синфи `Person`-ро даъват мекунад
    - Синфи `Teacher`:
      - Усули `Explain` дорад, ки ба консол `The teacher is explaining` менависад
      - Дар синфи `Teacher` конструкторе эҷод кунед, ки конструктори волидайни синфи `Person`-ро даъват мекунад

3. Дар барномаи асосй(Program.cs).
    - Аз корбар номҳои се нафарро дархост кунед ва онҳоро дар массиви объектҳои `Person` нигоҳ доред
    - Барои объекти муаллим усули `Explain`-ро истифода баред
    - Усули `Study` -ро барои объектҳои донишҷӯ истифода баред

### Input:
```
Juan
Sara
Carlos
```

### Output:
```
The Juan is explaining
The Sara is studying
The Carlos is studying
```
---

## Task 2
### Photo Book Class
Create a C# program to manage a photo book using object-oriented programming.
To start, create a class called `PhotoBook` with a private attribute `numPages` of type `int`.
It must also have a public method `GetNumberPages()` that will return the number of photo book pages.        
The default constructor will create an album with 16 pages.                                
There will also be an additional constructor that allows us to specify the number of pages we want in the album.
There is also a `BigPhotoBook` class whose constructor will create an album with 64 pages.
Finally, create a `PhotoBookTest` class to perform the following actions:
1. Create a default photo book and display the number of pages.
2. Create a photo book with 24 pages and display the number of pages.
3. Create a large photo book and display the number of pages.
##
Создайте программу на C# для управления фотокнигой с помощью объектно-ориентированного программирования.
Для начала создайте класс `PhotoBook` закрытым атрибутом `numPages` типа int. 
Он также должен иметь общедоступный метод `GetNumberPages()`, который будет возвращать количество страниц фотокниги.
Конструктор по умолчанию создаст альбом из 16 страниц. Появится дополнительный конструктор, 
с помощью которого мы сможем указать желаемое количество страниц в альбоме.
Еще есть `BigPhotoBook` класс, конструктор которого создаст альбом на 64 страницы.
Наконец создайте `PhotoBookTest` класс для выполнения следующих действий:
Создайте фотокнигу по умолчанию и покажите количество страниц.
Создайте фотокнигу на 24 страницы и покажите количество страниц.
Создайте большую фотокнигу и покажите количество страниц.
##
Эҷоди барномаи C# барои идоракунии китоби аксҳо бо истифода аз барномасозии ба объект нигаронидашуда.
Барои оғоз, синфи `PhotoBook` бо атрибути хусусии `numPages` навъи int эҷод кунед.
Он инчунин бояд усули оммавии `GetNumberPages()` дошта бошад, ки шумораи саҳифаҳои китоби аксҳоро бармегардонад.
Конструктори пешфарз албоми иборат аз 16 саҳифа эҷод мекунад. Конструктори иловагӣ пайдо мешавад, ки бо он мо метавонем шумораи дилхоҳи саҳифаҳои албомро муайян кунем.
Инчунин як синфи `BigPhotoBook` мавҷуд аст, ки созандаи он конструктори он албоми иборат аз 64 саҳифа эҷод мекунад.
Дар ниҳоят синфи `PhotoBookTest` эҷод кунед, то ин амалҳоро иҷро кунед:
Китоби аксҳои пешфарз эҷод кунед ва шумораи саҳифаҳоро нишон диҳед.
Китоби аксҳои 24 саҳифа эҷод кунед ва шумораи саҳифаҳоро нишон диҳед.
Китоби аксҳои калон эҷод кунед ва шумораи саҳифаҳоро нишон диҳед.
##### Output
```
16
24
64
```
---
## Task 3
#### Abstract Classes
Create a C# program that implements an abstract class `Animal` that has a `Name` property of type text and three methods:                               
`SetName(string name)`, `GetName()`, and `Eat()`. The `Eat()` method will be an abstract method of type void.
You will also need to create a `Dog` class that implements the `Animal` class mentioned above,                          
 and override the `Eat()` method to display that the dog is eating.                      
To test the program, ask the user for a dog's name and create a new `Dog` object from the `Main` method of the program. Set the name of the `Dog` object and then execute the `GetName()` and `Eat()` methods.                       
##
Создайте программу на языке C#, в которой будет реализован абстрактный класс `Animal` со свойством `Name` типа string и тремя методами:                                  
`SetName(string name)`, `GetName()` и `Eat()`. Метод `Eat()` будет абстрактным методом типа void.
Также вам необходимо создать класс `Dog`, который наследуется от класса `Animal` и переопределяет метод `Eat()`, чтобы выводить сообщение о том, что собака кушает.
Для тестирования программы попросите пользователя ввести имя собаки и создайте новый объект `Dog` в методе `Main` программы.                                               
Установите имя объекту `Dog`, а затем вызовите методы `GetName()` и `Eat()`.       
##
Дар C# барнома созед, ки синфи абстрактии `Animal`-ро бо хосияти `Name` навъи string ва се усул амалӣ кунад:
`SetName(string name)`, `GetName()` ва `Eat()`. Усули `Eat()` усули абстрактии навъи void хоҳад буд.
Шумо инчунин бояд синфи `Dog` эҷод кунед, ки аз синфи `Animal` мерос гирифта, усули `Eat()`-ро тағйир медиҳад, то паёмеро чоп кунад, ки саг хӯрок мехӯрад.
Барои санҷидани барнома, аз корбар хоҳиш кунед, ки номи сагро ворид кунад ва дар усули `Main`-и барнома объекти нави `Dog`' созад.
Ба объекти `Dog` ном таъин кунед ва сипас усулҳои `GetName()` ва `Eat()`-ро даъват кунед.
### Input
```
Tobby
```
### Output
```
Tobby
Eating
```

