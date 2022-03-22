namespace Projeto_RPG.src.Entities
{
    public class Heros
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        
        public Heros(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level+ " "+this.HeroType;
        }
        
         public virtual string Attack(){
            return this.Name + "Atacaa!";
         }
    }
}