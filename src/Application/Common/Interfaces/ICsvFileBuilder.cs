﻿using timecapsule.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace timecapsule.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
