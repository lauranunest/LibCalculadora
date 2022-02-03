namespace LibCalc
{
    public class Funcoes
    {
        private static double calculo;

        public static void setSoma(double x,double y) { calculo = (x + y); }
        public static double getSoma() { return calculo; }

        public static void setSub(double x, double y) { calculo = (x - y); }
        public static double getSub() { return calculo; }

        public static void setDiv(double x, double y) { calculo = (x / y); }
        public static double getDiv() { return calculo; }

        public static void setMult(double x, double y) { calculo = (x * y); }
        public static double getMult() { return calculo; }


    }
}