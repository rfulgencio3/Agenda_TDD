using System;
using System.Collections.Generic;
using Agenda.Domain;
using Agenda.DAL;
using NUnit.Framework;
using Moq;

namespace Agenda.Repository.Test
{
    [TestFixture]
    public class RepositoryContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositoryContatos _repositoryContatos;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositoryContatos = new RepositoryContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            var telefoneId = Guid.NewGuid();
            var contatoId = Guid.NewGuid();
            var lstTelefone = new List<ITelefone>();

            //Monta
            //Criar Moq de IContato
            Mock<IContato> mContato = IContatoConstructor.Um().ComId(contatoId).ComNome("Ricardo").Obter();
            mContato.SetupSet(o => o.Telefones = It.IsAny<List<ITelefone>>())
                .Callback<List<ITelefone>>(p => lstTelefone = p);

            //Moq da Função ObterPorId de IContatos
            _contatos.Setup(o => o.Obter(contatoId)).Returns(mContato.Object);

            //Criar Moq de ITelefone
            ITelefone mockTelefone = ITelefoneConstructor.Um().ComId(telefoneId)
                .ComContatoId(contatoId).Construir();

            _telefones.Setup(o => o.ObterTodosDoContato(contatoId)).Returns(new List<ITelefone> { mockTelefone });

            //Executa
            //Chamar o Método ObterPorId de RepositoryContatos
            IContato contatoResultado = _repositoryContatos.ObterPorId(contatoId);
            mContato.SetupGet(o => o.Telefones).Returns(lstTelefone);

            //Verifica
            //Verificar se o Contato retornado contém os mesmos dados do Moq IContato com a lista de Telefones do Moq ITelefone
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mockTelefone.Id, contatoResultado.Telefones[0].Id);
            Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
            _repositoryContatos = null;
        }
    }
}
