
namespace API.Entities.GraphQL
{
    public class StockType : ObjectType<Stock>
    {

        protected override void Configure(IObjectTypeDescriptor<Stock> stock)
        {
            stock.Field(t => t.Id).Type<IntType>().Description("Identificacao");
            stock.Field(t => t.Ticker).Type<StringType>().Description("Identificacao na B3 do Ativo");
            stock.Field(t => t.Nome).Type<StringType>().Description("Nome");
            stock.Field(t => t.PrecoAtual).Type<IntType>().Description("Preco Atual");
            stock.Field(t => t.VolumeNegociado).Type<IntType>().Description("Volume disponivel");
            stock.Field(t => t.DataUltimaAtualizacao).Type<DateType>().Description("Data da Ultima Atualizacao");
        }
       
    }
}
