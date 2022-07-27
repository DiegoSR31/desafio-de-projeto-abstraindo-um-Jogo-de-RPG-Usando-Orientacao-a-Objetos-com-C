namespace desafio_de_projeto_abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.scr.Entities
{
    public class Ninja : Hero
    {
            public Ninja (string Name, int Level, string HeroType, int MinHP, int MaxHP, int MinMP, int MaxMP){
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
            return this.Name +  " Lançou uma Flecha.";
        }

            public string Attack(int Bonus){

                if (Bonus > 6){
                    return this.Name + " Lançou uma Flecha com dano super efetivo com bonus de " + Bonus;
                } else{
                    return this.Name + " Lançou uma Flecha com dano pouco eficaz com bonus de " + Bonus;
            }

        }
        
    }
}