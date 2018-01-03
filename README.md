# Glue API Intro Lab 1 - Hello Glue API 

This is a part of introductory materials for BIM 360 Glue API discussed here:

https://fieldofviewblog.wordpress.com/2015/01/06/glue-api-intro-labs-overview/

The labs consist of four modules. Starting from Lab1, it incrementally 
adds code or reuse the code you have written, and implement toward a simple web service application. 

This is the first and THE minimum project that demonstrates how to make Glue REST API call. In this lab, you learn what REST API is, how to make a request and obtain a response, and log in to Glue web services through API. 


**How to run the sample project**

* request for an access to development environment, and API key and secret. 

In order to use Glue API, you will need API key and secret assigned to you. 
You will also need an account to a Glue host.

If you are reading this material, we assume you are a developer interested in using Glue API. Please refer to this post to request for a development environment:  

https://fieldofviewblog.wordpress.com/2014/12/30/glue-api-access/

* Once you have the above information, open the App.config and set your own configuration setting there.  


```xml
  <appSettings>
    <add key="baseApiUrl" value="https://b4.autodesk.com/api/"/>
    <add key="baseViewerUrl" value="https://b2.autodesk.com?"/>
    <add key="publicKey" value=""/>
    <add key="privateKey" value=""/>
    <add key="company" value=""/>
  </appSettings>
```

The project is written in C#, using Microsoft Visual Studio 2015, .NET 4.5.2.

Dependency: RestSharp 106.2.0 (NuGet will automatically download a package when you build.) 

Disclaimer: Minimum error checking for simplicity and readability to focus on learning BIM 360 Glue API. 

For detailed explanation, please take a look at this post: 
https://fieldofviewblog.wordpress.com/2015/01/08/lab1-hello-glue-world/

(Note: The project here is slightly updated. But the basic usage of Glue API itself is the same.) 

For additional information about BIM 360 Glue API, please refer to:
https://fieldofviewblog.wordpress.com/glue/

Written by M.Harada, March 2015. 

Last updated: 1/2/2018 by M.Harada 



