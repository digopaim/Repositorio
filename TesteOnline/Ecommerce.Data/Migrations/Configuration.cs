using Ecommerce.core.Entities;

namespace Ecommerce.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ecommerce.Data.Contexto.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Ecommerce.Data.Contexto.DataContext context)
        {
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =1,NomeMercadoria = "Roupa Azul",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =2,NomeMercadoria = "Roupa Amarelo",Preco = 100,Quantidade = 10 , TipoNegocio = "Compra"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =3,NomeMercadoria = "Roupa Vermelho",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =4,NomeMercadoria = "Roupa Roxo",Preco = 100,Quantidade = 10 , TipoNegocio = "Compra" });
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =5,NomeMercadoria = "Roupa Verde Musgo",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =6,NomeMercadoria = "Roupa Laranja",Preco = 100,Quantidade = 10 , TipoNegocio = "Compra" });
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =7,NomeMercadoria = "Roupa Lilas",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =8,NomeMercadoria = "Roupa Abobora",Preco = 100,Quantidade = 10 , TipoNegocio = "Compra" });
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =9,NomeMercadoria = "Roupa Coral",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =10,NomeMercadoria = "Roupa Preto",Preco = 100,Quantidade = 10 , TipoNegocio = "Compra" });
                context.Mercadoria.AddOrUpdate(new Mercadoria() {Id =11,NomeMercadoria = "Roupa Azul Marinho",Preco = 100,Quantidade = 10 , TipoNegocio = "Venda"});
                context.Login.AddOrUpdate(new Login() {Id=1,Nome ="Rodrigo",Usuario = "admin",Password = "admin"});
        }
    }
}
