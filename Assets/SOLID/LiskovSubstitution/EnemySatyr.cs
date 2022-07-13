namespace LiskovSubstitution
{
    public class EnemySatyr : Enemy
    {
        public override void TakeDamage(int amount)
        {
            /* Satyr will take double damage from Minotaur players */
            base.TakeDamage(amount * 2);
        }
    }
}

