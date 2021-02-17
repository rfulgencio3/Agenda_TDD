using Agenda.Domain;
using System;

namespace Agenda.Repository.Test
{
    public class IContatoConstructor : BaseConstructor<IContato>
    {
        protected IContatoConstructor() : base() { }

        public static IContatoConstructor Um()
        {
            return new IContatoConstructor();
        }

        public IContatoConstructor ComNome(string nome)
        {
            _mock.SetupGet(o => o.Nome).Returns(nome);
            return this;
        }

        public IContatoConstructor ComId(Guid id)
        {
            _mock.SetupGet(o => o.Id).Returns(id);
            return this;
        }
    }
}
