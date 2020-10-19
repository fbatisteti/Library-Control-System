# Library Control System

Simple system to control book flux in a library. Made for college. Won't be updating.

## Description

Simple library system made in Blazor (C# + HTML + CSS + a tiny little piece of JS) for a college project. It manages MEMBER, BOOK, AUTHOR and CATEGORY models, with possibilities to add, edit and delete entries, along with some other interactions between them.  

By request, the project must have at least an One-to-One, an One-to-Many, and a Many-to-Many Relationship:
* __One-to-One:__ each Member has their rental history, which is unique to them (clearly, this is a filler);
* __One-to-Many:__ one Member can have custody of many Book, but each book can only be in custody of one Member;
* __Many-to-Many:__ one Author can have many Books, and a Book can have many Authors; the same can be said for Categories and Books;  

> Final version will __NOT__ be continued or updated after project deadline. Hopefully, I could make everything functional to an acceptable minimum.  
On this version, the overall design and layout was not a primary (or even secondary) objective... so, it might be a little unpleasant to the eye in case of larger databases.

## Getting Started

### Dependencies

* [Microsoft.EntityFrameworkCore](https://docs.microsoft.com/en-us/ef/core/)

* [Pomelo.EntityFrameworkCore.MySQL](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)

* [Microsoft.AspNetCore.Mvc.DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.dataannotations?view=aspnetcore-3.1)

* [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations)

### Installing

Just clone with
´´´
git clone https://github.com/fbatisteti/Library-Control-System.git
´´´

### Executing program

If it is the very first use this line of code on root
´´´
dotnet ef database update
´´´
You can run it from ./Server to make all things work, with code
´´´
dotnet watch run
´´´
What I do is the following commands as soon as I open the project:
´´´
cd server;
cd .. ; dotnet build ; cd server ; dotnet watch run
´´´
With this, everytime I want to refresh the project I just run last command line again once

## Authors

* Fábio Batisteti - [GitHub: fbatisteti](https://github.com/fbatisteti)

## License

Use it for whatever you like. No credits needed, but I'm also not responsible for its use :)

## Acknowledgments

* [awesome-readme](https://github.com/matiassingers/awesome-readme)