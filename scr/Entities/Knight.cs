namespace desafio_de_projeto_abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.scr.Entities
{
    public class Knight : Hero
    {
            public Knight (string Name, int Level, string HeroType, int MinHP, int MaxHP, int MinMP, int MaxMP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinHP = MinHP;
            this.MaxHP = MaxHP;
            this.MinMP = MinMP;
            this.MaxMP = MaxMP;
        }

            public override string ToString(){
            return this.Name + " Level " + this.Level + " " + this.HeroType + " - HP " + this.MinHP + " / " + this.MaxHP + " - MP " + this.MinMP + " / " + this.MaxMP;
        }
            public override string Attack(){
            return this.Name +  " Atacou com a espada.";
        }
        
            public string Attack(int Bonus){

                if (Bonus > 6){
                    return this.Name + " Atacou com a Espada e causou dano super efetivo com bonus de " + Bonus;
                } else{
                    return this.Name + " Atacou com a Espada com dano pouco eficaz com bonus de " + Bonus;
            }

        }

        

    }
}