using AutoMapper;
using LibraryAPI.Models;
using LibraryAPI.Models.DTOs;
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
            app.MapPost("/api/book", CreateBook).Accepts<CreateBookDTO>("application/json");
            app.MapPut("/api/book", UpdateBook);
            app.MapDelete("/api/book/{id:int}", DeleteBook);
            app.MapGet("/api/book/result", SearchBook);
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

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IMapper mapper, CreateBookDTO newBook)
        {
            APIResponse response = new APIResponse();

            if (bookRepository.GetSingleAsync(newBook.Title).GetAwaiter().GetResult() != null)
            {
                response.IsSuccess = false;
                response.StattusCode = HttpStatusCode.BadRequest;
                response.ErrorMessages.Add("Title already exists in database");
                return Results.BadRequest(response);
            }

            Book bookToAdd = mapper.Map<Book>(newBook);
            await bookRepository.CreateBookAsync(bookToAdd);
            await bookRepository.SaveAsync();

            response.Result = newBook;
            response.IsSuccess= true;
            response.StattusCode = HttpStatusCode.Created;
            return Results.Ok(response);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, Book bookToUpdate)
        {
            APIResponse response = new APIResponse();

            await bookRepository.UpdateBookAsync(bookToUpdate);
            await bookRepository.SaveAsync();

            response.Result = bookToUpdate;
            response.IsSuccess= true;
            response.StattusCode = HttpStatusCode.OK;
            return Results.Ok(response);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            APIResponse response = new APIResponse();

            var result = await bookRepository.GetSingleAsync(id);

            if (result == null)
            {
                response.IsSuccess = false;
                response.StattusCode = HttpStatusCode.BadRequest;
                response.ErrorMessages.Add($"Book with ID {id} does not exist");
                return Results.BadRequest(response);
            }

            await bookRepository.DeleteBookAsync(result);
            await bookRepository.SaveAsync();

            response.Result = result;
            response.IsSuccess= true;
            response.StattusCode = HttpStatusCode.OK;
            return Results.Ok(response);
        }

        private static async Task<IResult> SearchBook(IBookRepository bookRepository, string searchKeyword)
        {
            APIResponse response = new APIResponse();
            response.Result = await bookRepository.SearchBookAsync(searchKeyword);
            response.IsSuccess = true;
            response.StattusCode = HttpStatusCode.OK;
            return Results.Ok(response);
        }
    }
}
