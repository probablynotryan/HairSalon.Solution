# Hair Salon

#### By _**Ryan Bass** (/probablynotryan)_ 

#### _Epicodus Independent Project Week 10: An MVC website demonstrating familiarity with using and manipulating SQL databases._

## Technologies Used

* C#
* HTML
* Javascript
* CSS
* Bootstrap
* ASP .NET Core
* MySql
* Entity / Linq / Razor

## Description

This MVC website allows Claire (of the infamous Eau Claire's Salon) to view/add her stylists and their clients!

## Setup/Installation Requirements

* Download or clone this repository to your computer.
* Install [.NET 5](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) if it is not installed already.
* In order to properly run the database, [install MySQL](https://dev.mysql.com/downloads/mysql/).
* In your terminal, log into MySql by entering: ```mysql -uroot -p```
* Type in the password provided during installation.
* Create the salon's database by entering: ```CREATE DATABASE hair_salon;```
* Exit MySql by typing ```quit``` in your terminal.
* Still in terminal, navigate to your downloaded repository. _(ie: User/desktop/HairSalon.Solution/)_
* Enter in ```mysql -u root -p hair_salon < ryan_bass.sql``` to copy in the tables used in this project.
* (We're still using terminal) Navigate to inside HairSalon.Solution/HairSalon and enter ```touch appsettings.json```. You can then edit that created file with a code editor of your choice and enter this on in it: 
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=PASSWORD;"
    }
  } ```

and save that file. (Be sure to replace PASSWORD with the password you provided during installation).
* (Guess what: we're still using terminal from inside HairSalon/) Enter ```dotnet build```
* After a successful build, run the project by entering ```dotnet run``` (you guessed it: in terminal).
* You should get a _Now listening on:_ line with the path of where its running. (ie: http://localhost.5000) Hold command and click it to open it up with your default browser.
* Go wild! Add clients and stylists as you see fit!

## Known Bugs

* No reported bugs (yet)

## License

MIT
Copyright (c) _2022_ _Ryan Bass_