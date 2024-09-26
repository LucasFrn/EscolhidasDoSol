


public class Habilidade
{
    public int id;
    public static int custo;
    public string nome;
    public Personagem caster { get; set; }

    public Habilidade(int id, string nome, Personagem caster)
    {
        this.id = id;
        this.nome = nome;
        this.caster = caster;
    }

    public void Efeito(Personagem alvo)
    {
        caster.energia -= custo;
        alvo.Curar(caster.ataqueMagico*2);
    }

}
