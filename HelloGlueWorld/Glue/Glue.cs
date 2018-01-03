#region Copyright
//
// Copyright (C) 2013-2018 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// Written by M.Harada.  
// 
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net; // for HttpStatusCode
using System.Configuration;  // for ConfigurationManager. Add reference to System.Configuration. 
// Added for RestSharp 
using RestSharp;
using RestSharp.Deserializers;  

///===================================================================
/// Welcome to the Glue REST API.  
/// 
/// "Glue" class in this page defines/constructs REST API calls to 
/// Glue web services.   
/// 
/// You can find the API documentation at the following site. 
/// Doc 
/// http://b4.autodesk.com/api/doc/index.shtml
///
/// Note: as of Oct 2014, display component page is not up to date.
/// We will cover this topic in the next section. 
///===================================================================
/// 10/13/2014 - We are going to use RestSharp in this labs for 
/// simplicity and to focus on Glue specific APIs.
/// 
///===================================================================
namespace HelloGlueWorld
{
   class Glue
   {
      // Set values that are specific to your environments.
      // companyId is the name of the host. 

      // To Do: set your own configuration in App.config file.
      private static string baseApiUrl = ConfigurationManager.AppSettings["baseApiUrl"];
      private static string baseViewerUrl = ConfigurationManager.AppSettings["baseViewerUrl"];
      private static string apiKey = ConfigurationManager.AppSettings["publicKey"];
      private static string apiSecret = ConfigurationManager.AppSettings["privateKey"];
      private static string companyId = ConfigurationManager.AppSettings["company"];

      // Member variables 
      // Save the last response. This is for learning purpose. 
      public static IRestResponse m_lastResponse = null; 

      ///===============================================================
      /// Security service: Login
      /// URL 
      /// https://b4.autodesk.com/api/security/v1/login.{format}
      /// Methods: POST
      /// Doc
      /// http://b4.autodesk.com/api/security/v1/login/doc
      ///
      /// Sample Response (JSON)  
      /// {
      ///   "auth_token":"The authentication token returned by BIM 360",
      ///   "user_id":"The BIM 360 Glue user identifier for this user"
      /// }
      ///===============================================================

      public static string Login(string login_name, string password)
      {
         // Calculate signature components. 
         string timeStamp = Utils.GetUNIXEpochTimestamp().ToString();
         string signature = Utils.ComputeMD5Hash(apiKey + apiSecret + timeStamp);

         // (1) Build request 
         var client = new RestClient();
         client.BaseUrl = new System.Uri(baseApiUrl);

         // Set resource/end point
         var request = new RestRequest();
         request.Resource = "security/v1/login.json";
         request.Method = Method.POST;

         // Set required parameters 
         request.AddParameter("login_name", login_name);
         request.AddParameter("password", password);
         request.AddParameter("company_id", companyId);
         request.AddParameter("api_key", apiKey);
         request.AddParameter("timestamp", timeStamp);
         request.AddParameter("sig", signature);

         Debug.WriteLine("Calling POST security/v1/login.json ...");

         // (2) Execute request and get response
         IRestResponse response = client.Execute(request);

         // Save response. This is to see the response for our learning.
         m_lastResponse = response;

         Debug.WriteLine("StatusCode = " + response.StatusCode);

         // (3) Parse the response and get the auth token. 
         string authToken = ""; 
         if (response.StatusCode == HttpStatusCode.OK)
         {
            JsonDeserializer deserial = new JsonDeserializer();
            LoginResponse loginResponse = deserial.Deserialize<LoginResponse>(response);
            authToken = loginResponse.auth_token;
         }
 
         return authToken; 

      }
   }
}
