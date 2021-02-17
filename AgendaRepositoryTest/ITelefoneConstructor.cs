using System;
using Agenda.Domain;
using AutoFixture;

namespace Agenda.Repository.Test
{
    public class ITelefoneConstructor : BaseConstructor<ITelefone>
    {
        public ITelefoneConstructor() : base() { }

        public static ITelefoneConstructor Um()
        {
            return new ITelefoneConstructor();
        }

        public ITelefoneConstructor Padrao()
        {
            _mock.SetupGet(o => o.Id).Returns(_fixture.Create<Guid>());
            _mock.SetupGet(o => o.Numero).Returns(_fixture.Create<string>());
            _mock.SetupGet(o => o.ContatoId).Returns(_fixture.Create<Guid>);
            return this;
        }

        public ITelefoneConstructor ComId(Guid id)
        {
            _mock.SetupGet(o => o.Id).Returns(id);
            return this;
        }

        public ITelefoneConstructor ComNumero(string numero)
        {
            _mock.SetupGet(o => o.Numero).Returns(numero);
            return this;
        }

        public ITelefoneConstructor ComContatoId(Guid contatoId)
        {
            _mock.SetupGet(o => o.ContatoId).Returns(contatoId);
            return this;
        }
    }
}
