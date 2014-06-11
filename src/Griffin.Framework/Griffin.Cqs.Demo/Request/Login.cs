﻿using DotNetCqs;

namespace Griffin.Cqs.Demo.Request
{
    public class Login : Request<LoginReply>
    {
        public Login(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}