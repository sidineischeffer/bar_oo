using System;
using System.Globalization;

namespace Bar_OO {
    class Bill {
        public char gender;
        public int beer;
        public int barbecue;
        public int softDrink;

        private static double precoBeer = 5.00;
        private static double precoSoftDrink = 3.00;
        private static double precoBarbecue = 7.00;
        private static double coverPagar = 4.00;
        private static double ticketMasculino = 10.00;
        private static double ticketFeminino = 8.00;

        public double ticket() {
            if (gender == 'F') {
                return ticketFeminino;
            }
            else {
                return ticketMasculino;
            }
        }

        public double cover(double totalConsumption) {
            return totalConsumption > 30.00 ? 0.00 : coverPagar;
        }

        public double feeding() {
            return (precoBeer * beer) + (precoSoftDrink * softDrink) + (precoBarbecue * barbecue);
        }

        public double total() {
            double totalConsumption = feeding();
            double totalCover = cover(totalConsumption);
            return totalConsumption + ticket() + totalCover;
        }
    }
}
