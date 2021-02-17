using Agenda.Domain;
using AutoFixture;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.DAL.Test
{
    class ObterContatosTest : BaseTest
    {
        [TestFixture]
        public class ContatosTest : BaseTest
        {
            Contatos _contatos;
            Fixture _fixture;

            [SetUp]
            public void SetUp()
            {
                _contatos = new Contatos();
                _fixture = new Fixture();
            }

            [Test]
            public void ObterTodosOsContatosTest()
            {
                //Monta
                var contato1 = _fixture.Create<Contato>();
                var contato2 = _fixture.Create<Contato>();
                //Executa
                _contatos.Adicionar(contato1);
                _contatos.Adicionar(contato2);
                var lstContato = _contatos.ObterTodos();
                var contatoResultado = lstContato.Where(o => o.Id == contato1.Id).FirstOrDefault();
                //Verifica
                Assert.AreEqual(2, lstContato.Count());
                Assert.AreEqual(contato1.Id, contatoResultado.Id);
                Assert.AreEqual(contato1.Nome, contatoResultado.Nome);
            }

            [TearDown]
            public void TearDown()
            {
                _contatos = null;
                _fixture = null;
            }
        }
    }
}