namespace Projeto_RPG.src.Entities
{
    public class BlackWizard : Heros
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name=Name;
            this.Level=Level;
            this.HeroType=HeroType;
        }

        public override string Attack(){
            return this.Name + "Atacou com sua magia Negra!!";
        }
        
        public string Attack(int Bonus){
            if(Bonus > 8){
                return this.Name + ": Magia com maior nivel de dano" +Bonus;
            }
            else{
                return this.Name + ": Magia com menor dano"+Bonus;
            }
    }
}
}