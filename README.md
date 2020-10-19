# Library Control System

Simple system to control book flux in a library. Made for college. Won't be updating.

## Description

> Simple library system made in Blazor for a college project. Manages MEMBER, BOOK, AUTHOR and CATEGORY models, with possibilities to add, edit and delete entries.  
> By request, the project must have at least an One-to-One, an One-to-Many, and a Many-to-Many Relationship.  
> Final version will __not__ be continued after project deadline. Hopefully, I could make everything functional to an acceptable minimum.

## Getting Started

### Dependencies

* [Microsoft.EntityFrameworkCore](https://docs.microsoft.com/en-us/ef/core/).

* [Pomelo.EntityFrameworkCore.MySQL](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql).

* [Microsoft.AspNetCore.Mvc.DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.dataannotations?view=aspnetcore-3.1).

* [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations).

### Installing

> * Just clone with
'''
git clone https://github.com/fbatisteti/Library-Control-System.git
'''

### Executing program

> * If it is the very first use this line of code on root
'''
dotnet ef database update
'''
> * You can run it from ./Server to make all things work, with code
'''
dotnet watch run
'''
> * What I do is the following commands as soon as I open the project:
'''
cd server;
cd .. ; dotnet build ; cd server ; dotnet watch run
'''
> * With this, everytime I want to refresh the project I just run last command line again once

## Authors

Fábio Batisteti
[GitHub: fbatisteti](https://github.com/fbatisteti)

## License

> Use it for whatever you like. No credits needed, but I'm also not responsible for its use :)

## Acknowledgments

* [awesome-readme](https://github.com/matiassingers/awesome-readme)