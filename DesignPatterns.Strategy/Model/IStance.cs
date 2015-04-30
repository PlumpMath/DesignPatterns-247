namespace DesignPatterns.Strategy.Model {
    public interface IStance {

        string Attack(string name);

        string Move(string name);

        string Defend(string name);

        string StanceName();
    }
}