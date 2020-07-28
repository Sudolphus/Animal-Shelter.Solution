# _Animal Shelter_

#### _An app that links a database for an animal shelter, 7.28.20_

#### By _**Micheal Hansen & Chris Yoon*_

## Description

_This is an app that uses Entity to link a MySQL database that can track various animals at a shelter._

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
|Program links a MySQL Database|N/A|N/A|
|User can input animals into the database| "Animal" |Saved To Database|
|Animals have Name, Breed, Date of Admittance, Gender fields| Animal={Violet, Cat, 4-1-2020, Female} | N/A|
|User can view details on animals within the database| Violet | Violet, Cat, 4-1-2020, Female|

## Setup/Installation Requirements

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)
3. MySQL Server

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone https://github.com/Sudolphus/Animal-Shelter.Solution/`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

Database Installation:
1. This program saves and loads from a MySQL database. The Structure has been exported to the `animal_shelter.sql` file in the Animal-Shelter folder, and should be imported to your local Server with Workbench or created manually.
2. You will need to create an `Animal-Shelter\appsettings.json` file, with the following content:
 `{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd={PASSWORD};"
  }
}`

## Known Bugs

_None currently known_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

* _VSCode_
* _C# and .NET_
