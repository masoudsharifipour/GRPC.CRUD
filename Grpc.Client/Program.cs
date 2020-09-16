using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService_Crud;

namespace Grpc.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("http://localhost:5001");
            var client =  new EmployeeCRUD.EmployeeCRUDClient(channel);
            // Empty response1 = client.Insert(new Employee()
            // {
            //     FirstName = "Tom",
            //     LastName = "Jerry"
            // });
            Employees employees = client.SelectAll
                (new Empty());

            Console.WriteLine(employees);
            // Employee employee = client.SelectByID(
            //     new EmployeeFilter() { EmployeeID = 1041 });
            //
            // employee.FirstName = "Tom123";
            // employee.LastName = "Jerry123";
            //
            // Empty response2 = client.Update(employee);
            //
            // Empty response3 = client.Delete(new EmployeeFilter()
            // {
            //     EmployeeID = 1062
            // });
            //
            

        }
    }
}