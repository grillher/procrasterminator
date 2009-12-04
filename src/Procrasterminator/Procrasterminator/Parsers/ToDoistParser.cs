using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Procrasterminator.Parsers
{
    static class ToDoistParser
    {
        static public List<string> parse(string email, string pass)
        {
            var ret = new List<string>();

            var address = "http://todoist.com/API/";
            var loginSuf = "login?email=" + email + "&password=" + pass;
            const string projsSuf = "getProjects?token=";
            var token = "";

            // Create the web request   
            var request = WebRequest.Create(address + loginSuf) as HttpWebRequest;

            // Get response   
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream   
                var reader = new StreamReader(response.GetResponseStream());

                // Read the whole contents and return as a string   
                token = reader.ReadToEnd();

                int i = token.IndexOf("api_token");
                i = token.IndexOf("\"", i);
                i = token.IndexOf("\"", i + 1);
                i++;
                int u = token.IndexOf("\"", i);
                token = token.Substring(i, u - i);
            }

            request.Abort();

            // Create the web request   
            request = WebRequest.Create(address + projsSuf + token) as HttpWebRequest;

            // Get response   
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream   
                var reader = new StreamReader(response.GetResponseStream());

                // Read the whole contents and return as a string   
                var names = reader.ReadToEnd();

                while (names.Contains("name"))
                {
                    int i = names.IndexOf("name");

                    i = names.IndexOf("\"", i);
                    i = names.IndexOf("\"", i + 1);
                    i++;
                    int u = names.IndexOf("\"", i);
                    var name = names.Substring(i, u - i);

                    names = names.Substring(u);

                    ret.Add(name);
                }
            }

            return ret;
        }
    }
}
