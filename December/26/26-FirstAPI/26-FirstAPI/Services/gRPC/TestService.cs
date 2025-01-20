using Grpc.Core;
using Homework_gRPC;

namespace _26_FirstAPI.Services.gRPC;

public class TestService : Homework_gRPC.gRPC.gRPCBase
{
    public override Task<NameResponse> GetUserName(PostName name, ServerCallContext context)
    {
        return Task.FromResult(new NameResponse{
            Name = name.Name,
        });
    }
}