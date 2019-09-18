# netcore_personal
Step 1 : Clone github to client, open with Visual Studio (for Mac or for Win)

Step 2 : Update / restore Nuget Packaged

Step 3 : Run "Micro Service" Project in MicroService Solution

# api_structure
GET localhost:62100/basic/hello

# default_api_structure
{
    "data": object,
    "statusCode": number,
    "message": string
}

# database_layer
Currently using sqlite for fast structure.

Can use another database (Example mysql, mssql, oracle ...)

# project_structure
Project Data : Injection model project, communicate with database (model, table, stored procedures), mapping, unit of work

Project Service : Injection data project, this is business layer, crud data with complex business

Project Micro Service : Injection service project, this is REQUEST from client layer.
Call to service project to change data.