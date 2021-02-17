using System;
using Agenda.Domain;

namespace Agenda.DAL
{
    public interface IContatos
    {
        IContato Obter(Guid id);
    }
}
