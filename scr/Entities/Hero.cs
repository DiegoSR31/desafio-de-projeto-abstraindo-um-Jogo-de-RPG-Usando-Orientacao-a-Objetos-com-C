namespace desafio_de_projeto_abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.scr.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, int MinHP, int MaxHP, int MinMP, int MaxMP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinHP = MinHP;
            this.MaxHP = MaxHP;
            this.MinMP = MinMP;
            this.MaxMP = MaxMP;
        }

        public Hero(){

        }

        public string Name;
        public int Level;
        public string HeroType; 
        public int MinHP;
        public int MaxHP;
        public int MinMP;
        public int MaxMP;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.MinHP + " " + this.MaxHP + " " + this.MinMP + " " + this.MaxMP;
        }
        
        public virtual string Attack (){
            return this.Name + " Atacou com a sua espada.";
        }
    }
}