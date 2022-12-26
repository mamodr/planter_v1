using planter.Application.TodoLists.Queries.ExportTodos;

namespace planter.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
