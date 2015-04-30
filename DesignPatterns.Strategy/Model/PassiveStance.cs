using System;

namespace DesignPatterns.Strategy.Model {
    public class PassiveStance : IStance {

        public string Attack(string name) {
            return string.Format("{0} reacts only to incoming attacks", name);
        }

        public string Move(string name) {
            return string.Format("{0} moves normally", name);
        }
        
        public string Defend(string name) {
            return string.Format("{0} defends normally when attacked", name);
        }

        public string StanceName() {
            return "Passive";
        }
    }
}