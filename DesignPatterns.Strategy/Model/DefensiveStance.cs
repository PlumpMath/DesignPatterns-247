using System;

namespace DesignPatterns.Strategy.Model {
    public class DefensiveStance : IStance {

        public string Attack(string name) {
            return string.Format("{0} can only counter attack in defensive Stance", name);
        }

        public string Move(string name) {
            return string.Format("{0} moves slowly and defensively.", name);
        }

        public string Defend(string name) {
            return string.Format("{0} defends effectively and counterattacks!", name);
        }

        public string StanceName() {
            return "Defensive";
        }
    }
}
