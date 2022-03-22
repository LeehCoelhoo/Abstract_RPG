namespace Projeto_RPG.src.Entities
{
    public class Knight : Heros
    {
          public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        { 
           

        }

        public override string Attack(){
            return this.Name + "Atacou com sua espada!!";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + ": Magia com maior nivel de dano" +Bonus;
            }
            else{
                return this.Name + ": Magia com menor dano"+Bonus;
            }
    }
}
}