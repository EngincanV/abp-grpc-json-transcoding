using System.Threading.Tasks;
using Grpc.Core;

namespace BookStore.Services;

public class BookAppService : BookApp.BookAppBase
{
    //notice: we did not create GetBookListResponse and GetBookListRequest classes
    //Grpc.AspNetCore package did behalf of us
    public override Task<GetBookListResponse> GetBookList(GetBookListRequest request, ServerCallContext context)
    {
        var response = new GetBookListResponse();
        response.Books.Add(new Book
        {
            Title = "The Hitchhiker's Guide to the Galaxy",
            Author = "Douglas Adams",
            PageCount = 42
        });
        response.Books.Add(new Book
        {
            Title = "The Lord of the Rings",
            Author = "J.R.R. Tolkien",
            PageCount = 1234
        });
        
        return Task.FromResult(response);
    }
}