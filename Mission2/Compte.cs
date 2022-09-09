using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Compte
    {
        private int numero;
        private string nom;
        private int solde;
        private int decouvertautorise;

        public Compte(int numero, string nom, int solde, int decouvertautorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertautorise = decouvertautorise;
        }

        public Compte()
        {

        }

        public int amount()
        {
            return this.solde;
        }

        public int crediter(int somme)
        {
            this.solde = this.solde + somme;
            return this.solde;
        }

        public bool debiter(int montant)
        {
            if ((this.solde + this.decouvertautorise * -1) < montant)
            {
                if (this.solde >= montant)
                {
                    this.solde = this.solde - montant;
                    return true;
                }
                else
                {
                    this.decouvertautorise = this.decouvertautorise - (montant - this.solde);
                    this.solde = 0;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }



        public bool transferer(int montantTransfert)
        {
            if ((this.solde + this.decouvertautorise * -1) < montantTransfert)
            {
                if (this.solde >= montantTransfert)
                {
                    this.solde = this.solde - montantTransfert;
                    return true;
                }
                else
                {
                    this.decouvertautorise = this.decouvertautorise - (montantTransfert - this.solde);
                    this.solde = 0;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "Numéro : " + this.numero + Environment.NewLine + "nom : " + this.nom + Environment.NewLine + "Solde : " + this.solde + Environment.NewLine + "Découvert autorisé " + this.decouvertautorise;

        }
    }
}
