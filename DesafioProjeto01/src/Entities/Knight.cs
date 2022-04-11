namespace DesafioProjeto01.src.Entities
{
    public class Knight : Hero
    {
         public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
    }
}