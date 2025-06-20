﻿
using Microsoft.AspNetCore.Http;
using SmokingCessation.Core.Constants;

namespace SmokingCessation.Application.DTOs.Request
{
    public  class AuthenticationRequest
    {
        public class UserRegisterRequest
        {
         
            public string Email { get; set; }
            public string Password { get; set; }
          


        }
        public class UserLoginRequest
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class UpdateUserRequest
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public IFormFile imageUrl { get; set; }
           
        }
        public class RefreshTokenRequest
        {
            public string RefreshToken { get; set; }
        }


    }
}
