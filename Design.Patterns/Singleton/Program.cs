using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi i'm going to create 10 database connections based on the singleton DbConnection class and show that the connection has the same connection id for every connection I create. Press Enter to continue");
            Console.ReadLine();
            var connections = GetDbConnections(10);
            for (var i = 0; i < connections.Count; i++)
            {
                Console.WriteLine($"Connection {i} - Connection ID: {connections[i].GetConnectionId()}");
            }

            Console.ReadLine();
        }

        private static List<DbConnection> GetDbConnections(int numberToGet)
        {
            var connections = new List<DbConnection>();
            for (var i = 0; i < numberToGet; i++)
            {
                connections.Add(DbConnection.CreateConnection());
            }

            return connections;
        }
    }
}
