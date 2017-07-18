﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OAuthDemo.Models
{
    public class Demo
    {
        public Demo()
        {
            Id = "4dp5b7gRqk";
            Secret = "fa3a5b16753d09b24bb44243605a4a98";
            RedirectUri = "https://developer.authorize.net/api/reference/index.html";
        }

        // Step 1
        public string Id { get; set; }
        public string Secret { get; set; }

        // Step 2
        public string RedirectUri { get; set; }
        public string Scope { get; set; }
        public string State { get; set; }
        public string Sub { get; set; }

        // Step 3
        public string GrantType { get; set; }
        public string Code { get; set; }

        // Step 4

        // Step 5
        public string RefreshToken { get; set; }


        override public string ToString()
        {   
            return "Id: " + Id + 
                "\nSecret: " + Secret + 
                "\nRedirectUri: " + RedirectUri + 
                "\nScope: " + Scope + 
                "\nState: " + State + 
                "\nSub: " + Sub + 
                "\nGrantType: " + GrantType + 
                "\nCode: " + Code + 
                "\nRefreshToken: " + RefreshToken;
        }
    }
}