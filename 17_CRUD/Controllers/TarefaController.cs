using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


//Criando a classe TarefaControler e herdando seus métodos de controller
public class TarefaController : Controller
{
    //Criando um objeto _tarefas que armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();
    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //Verificando o total de tarefas da lista e somando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionando minha nova tarefa a a minha lista
        _tarefas.Add(novaTarefa);
        //Redirecionando para a pagina principal com a lista de tarefas
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
        //Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //Verificando se ela existe
        if (novaTarefa == null)
            return NotFound();

        //Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]

    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
            return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");

    }

    public IActionResult Deletar(int id)
    {
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (novaTarefa == null)
            return NotFound();

        return View(novaTarefa);
    }

    [HttpPost]

    public IActionResult DeletarConfirmado(int id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefaEncontrada == null)
            return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");

    }
}
