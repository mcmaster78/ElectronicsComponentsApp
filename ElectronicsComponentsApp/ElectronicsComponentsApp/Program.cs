using ElectronicsComponentsApp.Entities;
using ElectronicsComponentsApp.Repositories;
using ElectronicsComponentsApp.Data;

var sqlRepository = new SqlRepository<ElectronicComponent>(new ElectronicsComponentsAppDbContext());

AddComponents(sqlRepository);
AddComponentsDisassembly(sqlRepository);
Console.WriteLine("Sql repository:");
WriteAllToConsole(sqlRepository);

var listRepository = new ListRepository<ElectronicComponent>();

AddComponents(listRepository);
AddComponentsDisassembly(listRepository);
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("List repository:");
WriteAllToConsole(listRepository);
static void AddComponents(IRepository<ElectronicComponent> componentRepository)
{
    componentRepository.Add(new ElectronicComponent { Name = "UKŁAD SCALONY 74HCT00 - CZTERY DWUWEJŚCIOWE BRAMKI NAND", Qty = 4, Box = "A01"});
    componentRepository.Add(new ElectronicComponent { Name = "UKŁAD SCALONY 74HCT04 - SZEŚĆ INWERTERÓW", Qty = 2, Box = "A01" });
    componentRepository.Add(new ElectronicComponent { Name = "UKŁAD SCALONY 74HCT393 - DWA 4-BITOWE LICZNIKI", Qty = 3, Box = "A02" });

    componentRepository.Save();
}
static void AddComponentsDisassembly(IWriteRepository<ElectronicComponentDisassembly> componentRepository)
{
    componentRepository.Add(new ElectronicComponentDisassembly { Name = "KONDENSATOR 1000uF/25V" , Qty = 5, Box = "A03"});
    componentRepository.Add(new ElectronicComponentDisassembly { Name = "REZYSTOR 100kohm 0,125W", Qty = 10, Box = "A03" });
    componentRepository.Save();
}
static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}