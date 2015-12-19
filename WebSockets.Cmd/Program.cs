﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using WebSockets.Server;
using WebSockets.Cmd.Connections;
using System.Diagnostics;

namespace WebSockets.Cmd
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // used to decide what to do with incomming connections
                ConnectionFactory connectionFactory = new ConnectionFactory();

                using (WebServer server = new WebServer(connectionFactory))
                {
                    server.Listen(80);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}