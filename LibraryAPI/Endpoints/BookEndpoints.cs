using LibraryAPI.Models;
using LibraryAPI.Repositories;
using System.Net;

namespace LibraryAPI.Endpoints
{
    public static class BookEndpoints
    {
        public static void ConfigurationBookEndpoints(this WebApplication app)
        {
            app.MapGet("/api/books", GetAllBooks);
            app.MapGet("/api/book/{id:int}", GetBook);
        }

        private static async Task<IResult> GetAllBooks(IBookRepository bookRepository)
        {
            APIResponse response = new APIResponse();
            response.Result = await bookRepository.GetAllAsync();
            response.IsSuccess = true;
            response.StattusCode = HttpStatusCode.OK;
            return Results.Ok(response);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            APIResponse response = new APIResponse();
            response.Result = await bookRepository.GetSingleAsync(id);
            response.IsSuccess = true;
            response.StattusCode = HttpStatusCode.OK;
            return Results.Ok(response);
        }
    }
}
