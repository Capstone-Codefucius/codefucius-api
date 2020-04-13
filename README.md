# codefucius-api

A RESTful API built using ASP.NET Core and PostgreSQL

# Setup

## Installation

### ASP.NET Core

Head over to the [download section of the .NET Website](https://dotnet.microsoft.com/download) and download the **SDK** for your operating system.  Go ahead and run through the installer.

Make sure the CLI tools work by running `dotnet --version` in your terminal

### PostgreSQL

Go to the [download section on the PostgreSQL website](https://www.postgresql.org/download/) and download the installer appropriate for your OS.  Run through the installer, and don't worry about having to install anything extra if it prompts you.

Use your operating system's search function to find and run PGAdmin.  Log into PGAdmin using the password you setup during installation to confirm everything installed correctly.

### Downloading the code

First, clone the repository:

`git clone https://github.com/Capstone-Codefucius/codefucius-api.git`

Next, run the following command to make sure the necessary packages are installed:

`dotnet restore`

## Configuration

Navigate to the `appsettings.json` file in the project, and you'll notice the following connection string:

`"Server=localhost;Port=5432;Database=codefucius;User Id=postgres;Password=password;"`

This will need to be modified.  You can either use:
1. The default postgres user, with the password you created during installation
2. Create a new user id and password

Replace the user id and password where necessay.  This is needed to connect to the database.

## Database Migration

`dotnet ef database update`

Here, the first command is building a schema from the models that are defined in the code.  The second command then applies this to the database.

# Running the API

First, make sure that PGAdmin/Postgres is running so the API can connect to the databse.

To start the API, run

`dotnet run`

And press CTRL-C to stop it.

# Interacting with the API

For interacting with the API on its own, I would highly recommend using [Postman](https://www.postman.com/downloads/).
