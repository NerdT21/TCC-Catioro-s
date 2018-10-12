using Catiotro_s.classes.Classes.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Screens.Entregavel_I
{
    public class FolhaPagto
    {
        public decimal Salario { get; set; }
        public DateTime HoraExtra { get; set; }
        public int Faltas { get; set; }
        public DateTime Atrasos { get; set; }

        private decimal CalcularSalarioHora()
        {
            decimal salario = this.Salario / 220;
            return salario;
        }

        private decimal CalcularHoraExtra()
        {
            decimal horaPorDia = CalcularSalarioHora();
            decimal AddPorHora = horaPorDia * (50 / 100);

            int convertToDecimal = this.HoraExtra.Hour;

            decimal horaExtra = (horaPorDia + AddPorHora) * convertToDecimal;
            return horaExtra;
        } 

        private decimal CalcularDSR()
        {
            decimal horaExtra = CalcularHoraExtra();
            decimal dsr = (horaExtra / 26) * 4;
            return dsr;
        }
        
        private int CalcularFaltas()
        {
            int faltas = this.Faltas;
            if (faltas > 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }

        }

        private decimal CalcularAtraso()
        {
            DateTime atraso = this.Atrasos;
            decimal horaPorDia = CalcularSalarioHora();

            int horaAtraso = atraso.Hour;
            decimal Atraso = horaPorDia * horaAtraso;
            return Atraso;
        }

        private decimal CalcularINSS()
        {
            decimal salario = this.Salario;
            decimal HoraExtra = CalcularHoraExtra();
            decimal dsr = CalculaDSR();
            int faltas = this.Faltas;

            DateTime atraso = this.Atrasos;
            int horaAtraso = atraso.Hour;

            decimal baseInss = salario + HoraExtra + dsr - faltas - horaAtraso;

            if (baseInss <= 1659.38m)
            {
                decimal sal = 1659.38m;

                INSSBusiness buss = new INSSBusiness();
                INSSDTO dto = buss.Consultar(sal);

                decimal inss = baseInss * (dto.Aliquota / 100);
                return inss;
            }
            else if (baseInss >= 1659.39m && baseInss <= 2765.66m)
            {
                decimal sal = 2765.66m;

                INSSBusiness buss = new INSSBusiness();
                INSSDTO dto = buss.Consultar(sal);

                decimal inss = baseInss * (dto.Aliquota / 100);
                return inss;
            }
            else
            {
                decimal sal = 5531.31m;

                INSSBusiness buss = new INSSBusiness();
                INSSDTO dto = buss.Consultar(sal);

                decimal inss = baseInss * (dto.Aliquota / 100);
                return inss;
            }
        }

        private decimal CalcularFGTS()
        {
            decimal salario = this.Salario;
            return salario * (8 / 100);
        }

        private decimal CalcularValeTransporte()
        {
            decimal salario = this.Salario;
            return salario * (6 / 100);
        }

        private decimal VerificarSalarioFamilia()
        {

        }

        public decimal CalcularSalarioLiquido()
        {
            decimal salario = this.Salario;

            decimal salarioLiquido = salario + CalcularHoraExtra() + CalcularDSR() +  
        } 
    }
}
