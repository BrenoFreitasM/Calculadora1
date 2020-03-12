using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora    //original  é Prog
{
    public class Calculadora
    {
        private List<double> listNumero = new List<double>();      // CRIANDO NV LISTA

        public void addNumero(double num)                           //
        {                                                           //   
            this.listNumero.Add(num);                               //
        }

        public double somar()                                       
        {                                                           //
            double resultado = 0;                                   //    SOMA
            foreach (double numero in this.listNumero)
            {          
                resultado += numero;                                //   R  E  S  U  L  T  A  D  O
            }

            this.listNumero.Clear();
            return resultado;
        }

        public double subtrair()                                  //
        {                                                               //
            double resultado = this.listNumero[0];                 //    SUBTRAÇÃO
            this.listNumero.RemoveAt(0);                                //  removeAt zera 
            foreach (double numero in this.listNumero)                  //
            {
                resultado -= numero;                                        //  R  E  S  U  L  T  A  D  O
            }

            this.listNumero.Clear();
            return resultado;

        }

        public double multiplicar()    //COMPLETAR AQUI
        {
            double resultado = this.listNumero[0];                 //    SUBTRAÇÃO
            this.listNumero.RemoveAt(0);                              //  removeAt zera 
            foreach (double numero in this.listNumero)                  //
            {
                resultado = (numero * resultado);                                        //  R  E  S  U  L  T  A  D  O
            }

            this.listNumero.Clear();
            return resultado;

                }

        public double dividir()      //COMPLETAR AQUI
        {
            return 0;
        }

    }
}