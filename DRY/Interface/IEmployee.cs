namespace DRY.Interface
{
    public interface IEmployee
    {
         string Name { get; set; }
         bool IsManager { get; set; }

         decimal bonus { get; set; }
        decimal Bonus { get; }

        void SetBonus(decimal freightUsedForBonus);
    }
}