namespace DesignPatterns.Strategy.Model
{
    public class Robot
    {
        public string Name { get; set; }
        
        public IStance Stance { get; set; }

        public Robot(string name, IStance stance)
        {
            this.Name = name;
            this.Stance = stance;
        }

        public string Attack()
        {
            return this.Stance.Attack(this.Name);
        }

        public string Defend()
        {
            return this.Stance.Defend(this.Name);
        }

        public string Move()
        {
            return this.Stance.Move(this.Name);
        }
    }
}