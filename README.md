# Local Business Lookup Api

#### By Grace Lee

#### Brief Description of Application

This application allows the user to find local restaurants and shops in town.

## Technologies Used

- _C#_
- _Entity Framework Core_
- _MySQL_
- _ASP.NET Core MVC_
- _Swagger_

## Description

This is an application that allows the user to make Get, Post, Put, Delete requests to the BusinessApi in order to find local stores. One may be able to find a specific store with the unique id of the business and they may also filter the amount of store they would like to see at a given time.

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

- To launch the API, run the following codes in the production directory:

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
4. There should only be one table called `Businesses`.

## API Documentation/Endpoints

Base URL: `https://localhost:5001`

#### HTTP Request Structure

```
GET /api/[controller]
POST /api/[controller]
GET /api/[controller]/{id}
PUT /api/[controller]/{id}
DELETE /api/[controller]/{id}
```

### Note on Request Structure

The [controller] for the BusinessApi is Businesses.

```
GET /api/Businesses
POST /api/Businesses
GET /api/Businesses/{id}
PUT /api/Businesses/{id}
DELETE /api/Businesses/{id}
```

### Note on Different Responses

200: Success<br>
201: Created (New local business was successfully created)<br>
400: Error: Bad Request<br>
404: Error: Not Found (Entered a non-existent id)<br>

#### Parameters

| Name        | Type   |
| ----------- | ------ |
| name        | string |
| address     | string |
| description | string |
| rating      | double |
| review      | string |

#### Example Query

```
https://localhost:5001/api/Businesses/5
```

#### Sample JSON Response

```
{
  "businessId": 5,
  "name": "Over the Sea",
  "address": "127 Moole Street",
  "description": "Pet Shop",
  "rating": 2.5,
  "review": "Employee don't help out"
}
```

#### Example Query With Pagination Parameters

```
https://localhost:5001/api/Businesses?Page=1&ItemsPerPage=3
```

#### Sample JSON Response

```
[
  {
    "businessId": 1,
    "name": "Starz Restaurant",
    "address": "123 Moole Street",
    "description": "Fancy american restaurant",
    "rating": 4.6,
    "review": "Pricy and need to make reservations"
  },
  {
    "businessId": 2,
    "name": "Rexie's Bookstore",
    "address": "124 Moole Street",
    "description": "Antique bookstore",
    "rating": 3.1,
    "review": "Not a lot of books"
  },
  {
    "businessId": 3,
    "name": "Matilda Jewlers",
    "address": "125 Moole Street",
    "description": "Local handmande jewlery shop",
    "rating": 5,
    "review": "Has a variety of jewlery and can customize"
  }
]
```

### Note on Pagination Parameters

Both the page query parameter and items per page query parameters are optional. The BusinessApi will return a default of 5 results per page at a time, and up to a maximum of 5. If the page query parameter is left blank, it will return page 1 as default.

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

Copyright (c) _2023_ _Grace Lee_
