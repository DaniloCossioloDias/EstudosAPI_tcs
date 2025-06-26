using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepository _repository;

    public ProdutoController(IProdutoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetProduto()
    {
        var produtos = _repository.GetProdutos();
        return Ok(produtos);
    }

    [HttpGet("{id:int}", Name = "ObterProduto")]
    public ActionResult<Produto> GetProdutoById(int id)
    {
        var produto = _repository.GetProduto(id);
        if(produto is null)
            return NotFound();
        
        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        if(produto is null) 
            return BadRequest();    

        var produtoCriado = _repository.Create(produto);

        return new CreatedAtRouteResult("ObterProduto", new {id = produtoCriado.ProdutoId}, produtoCriado);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Produto produto)
    {
        if (id != produto.ProdutoId)
            return BadRequest();

        _repository.Update(produto);

        return Ok(produto);
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var produto = _repository.GetProduto(id);
        if(produto is null) { return NotFound(); }

        var produtoExcluido = _repository.Delete(id);

        return Ok(produto);
    }
}
