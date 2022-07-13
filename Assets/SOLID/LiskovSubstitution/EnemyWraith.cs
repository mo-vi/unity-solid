namespace LiskovSubstitution
{
    public class EnemyWraith : Enemy
    {
        public override void TakeDamage(int amount)
        {
            /* Do nothing. Player can't hit wraiths currently */
        }
    }    
}
