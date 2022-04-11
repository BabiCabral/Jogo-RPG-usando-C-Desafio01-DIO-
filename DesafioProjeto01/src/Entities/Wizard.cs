namespace DesafioProjeto01.src.Entities
{
    public class Wizard : Hero
    {
 
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.name + $" lançou magia super efetiva com bonus de {bonus}";
            }
            else
            {
                return this.name + $" lançou magia com força fraca com bonus de {bonus}";
            }
            
        }

    }
}