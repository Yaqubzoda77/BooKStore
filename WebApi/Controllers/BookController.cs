using Domain.Entities;
using Infrustructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
   private BookServices _bookServices;

   public BookController(BookServices bookServices)
   {
      _bookServices = bookServices;
   }

   [HttpGet("GetBooks")]
   public List<Book> GetBooks()
   {
      return _bookServices.GetBooks();
   }

   [HttpGet("GetBookBuId{id}")]
   public Book GetBookBuId(int id)
   {
   return   _bookServices.GetBookBuId(id);
   }

   [HttpPost("AddBook")]
   public void Insert([FromBody] Book book) => _bookServices.Insert(book);

   [HttpPut("Update")]
   public void Update([FromBody] Book book) => _bookServices.Update(book);

   [HttpDelete("delete{id}")]
   public void delete(int id)
   {
      _bookServices.Delete(id);
   }
}