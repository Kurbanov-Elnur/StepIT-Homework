using _26_SecondAPI.Services.Interfaces;
using Homework_gRPC;

namespace _26_SecondAPI.Services.Classes;

public class Test : ITest
{
    private readonly Homework_gRPC.gRPC.gRPCClient _client;

    public Test(Homework_gRPC.gRPC.gRPCClient client)
    {
        _client = client;
    }

    public async Task<string> TestAsync(string name)
    {
        var response = _client.GetUserName(new PostName
        {
            Name = name
        });

        return response.Name;
    }
}