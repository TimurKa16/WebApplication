# WebApplication

2021 year, november - december

I learned ASP.NET Core

It seems as a powerful, perspective, fast and elegant tool to create web apps.
Here I have learned MVC structure and various related frameworks (Identity, Entity).
There is released an API. With an API I developed some kind of a messenger.

There are two projects: client and server.

Server project was deployed in Azure:
"https://webapp20211225154702.azurewebsites.net/api".
It is a little side that allows to add new objects. Data is stored in a database and shown at a site.
Server receives messages using REST POST method, handles them and send to addressees by a request.

Client project is desktop.
Here I use RestSharp.
It requests messages to a server.

Serialization and deserialization are done using Newtonsoft.Json converter.
