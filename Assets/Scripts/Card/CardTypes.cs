
public enum BaseCardType
{

}
public enum TargetType
{
    NO_TARGET,
    YOUR_TARGET,
    ENEMY_TARGET,
    YOUR_CARD_TARGET,
    ENEMY_CARD_TARGET,
    ALLYOUR_CARD_TARGET,
    ALLENEMY_CARD_TARGET,
    ALL_CARD_TARGET
}
public enum EffectType
{
    NO_EFFECT,
    DAMAGE_TARGER,
    HEAL_TARGET,
    DESTROY_TARGET,
    CLONE_TARGET,
    CAPTURE_TARGET,
    TAKE_CARD
}
public enum TriggerType
{
    NO_TRIGGER,
    WHEN_ENTERS_THE_FIELD,
    WHEN_ATTACK,
    WHEN_ATTACK_PLAYER,
    WHEN_DESTROY,
    WHEN_PLAYED
}
public enum ParametersType
{
    BLEEDING,
    SHIELD,
    DEATH_TOUCH,
    HEALING,
    HZ1,
    HZ2,
    HZ3,
    RANDOM,
    TRAP,
    TEMPORARY,
    DOUBLE_ATTACK,
    MASS_ATTACK
}