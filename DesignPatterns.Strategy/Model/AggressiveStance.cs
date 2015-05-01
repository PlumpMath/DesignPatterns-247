using System;

namespace DesignPatterns.Strategy.Model {
    public class AggressiveStance : IStance {

        public string Attack(string name) {
            return string.Format("{0} attacks ferociously!", name);
        }

        public string Move(string name) {
            return string.Format("{0} move fast and aggressively!", name);
        }

        public string Defend(string name) {
            return string.Format("{0} attacks instead of defending!", name);
        }

        public string StanceName() {
            return "Aggressive";
        }
    }
}