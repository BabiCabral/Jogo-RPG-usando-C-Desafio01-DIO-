namespace DesafioProjeto01.src.Entities
{
    public abstract class Hero
    {

        // Construtor
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        // Atributos
        public string name;
        public int level;
        public string heroType;

        //Métodos
        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.heroType;
        }

        public virtual string Attack()
        {
            return this.name + " atacou com sua espada";
        }

    }
}