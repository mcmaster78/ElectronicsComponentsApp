

namespace ElectronicsComponentsApp.Entities
{
    public class ElectronicComponent : EntityBase
    {
        public ElectronicComponent()
        {
        }
        public string? Name { get; set; }
        public int Qty { get; set; }
        public string? Box { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {Name}, Q-ty: {Qty}, Box: {Box}";
    }
}
