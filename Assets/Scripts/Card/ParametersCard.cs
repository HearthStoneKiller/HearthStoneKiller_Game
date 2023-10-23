public class ParametersCard: ModCard
{
    private int maxHealth;
    private int currentHealth;
    private int attackDamage;
    public ParametersCard(string name, int maxHealth, int attackDamage): base(name)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.attackDamage = attackDamage;
    }
}
