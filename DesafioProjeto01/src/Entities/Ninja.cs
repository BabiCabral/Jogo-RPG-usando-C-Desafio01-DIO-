namespace DesafioProjeto01.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " deu um golpe";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.name + $" deu um golpe super efetivo com bonus de {bonus}";
            }
            else
            {
                return this.name + $" deu um golpe com força fraca com bonus de {bonus}";
            }
         }
    }
}