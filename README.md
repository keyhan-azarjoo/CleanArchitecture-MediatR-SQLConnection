# CleanArchitecture-MediatR-SQLConnection

Youtube : https://www.youtube.com/watch?v=r9wvwCN0BkY&list=PLyFg6Iua5MRkkmAPTF3-6RAW36rPYy9Qq&index=1


For Creating Sql database(Migeration For SQL):

 dotnet tool install --global dotnet-ef --version 8.*        // in the case you get error "Could not execute because the specified command or file was not found."  
 dotnet ef migrations add init --project Infrastructure           
 dotnet ef database update --project Infrastructure   

Install MediatR and MediatR ... injection
