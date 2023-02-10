# Local Business Lookup Api

#### By Grace Lee

#### Brief Description of Application

This application allows the user to find local restaurants and shops in town.

## Technologies Used

- _C#_
- _.NET_
- _Entity Framework Core_
- _MySQL_
- _ASP.NET Core_
- _Swagger_

## Description

This is an application that allows the user

## Setup/Installation Requirements

- Clone this repository to your desktop:

```
    $ git clone https://github.com/g-lee2/LocalBusinessLookupApi.Solution.git
```

- Navigate to the LocalBusinessLookupApi.Solution directory on your desktop and open the cloned directory with your favorite text editor (Visual Studio Code was used when setting this project up).

- Navigate into the LocalBusinessLookupApi production directory and run the code:

```
    $ dotnet restore
```

- Within the production directory, create a new file called `appsettings.json`.

- Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL Workbench. Please install MySQL Workbench if not already installed on your local machine.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[YOUR_ID];pwd=[YOUR_PASSWORD];"
  }
}
```

- To start the application, run the following codes in the production directory:

```
    $ dotnet build
```

```
    $ dotnet watch run
```

## Re-creating the Database

1. Launch MySQL Workbench and open your local instance.
2. Then follow [this link](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/introduction-to-mysql-workbench-creating-a-database) with instructions to create a database, based on the data from the `Models` directory.
3. You may also use migrations to create and update your database without having to manually create them yourself. Follow [this link](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations) for instructions to install the right tools.

## API Documentation/Endpoints

## Known Bugs

- _No known bugs as of now_

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2022_ _Grace Lee_
