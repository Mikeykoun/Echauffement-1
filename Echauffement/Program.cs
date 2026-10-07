using System.ComponentModel.Design;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Mikey et mon jeu préféré est The Last of Us part 2");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("quel est ton prénom?");
        string prenom = Console.ReadLine();
        Console.WriteLine("quel age as-tu?");
        string age = Console.ReadLine();
        int age1 = Convert.ToInt32(age);
        // Etape 3 : affichez soit "tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        {
            if (age1 >= 18)
            {
                Console.WriteLine("Tu es majeur");
            }
            else
            {
                Console.WriteLine("Tu es mineur");
            }

            // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
            Console.WriteLine("Combien d'euro as-tu?");
            float money = Convert.ToSingle(Console.ReadLine());
            
            // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
            Console.WriteLine("\n--Choix d'arme--");
            Console.WriteLine("1. Larry 25$");
            Console.WriteLine("2. Oupi Goupi 15$");
            Console.WriteLine("3. L'électricien 10$");
            Console.WriteLine("4. Le Malice 100$");

            // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
            Console.WriteLine("Quel arme souhaites-tu acheter?");
            int weaponChoice = Convert.ToInt32(Console.ReadLine());

            // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
                if (weaponChoice == 1)
                {
                    float price = 25.0f
                    if (money < price)
                    {
                        Console.WriteLine("Tu n'as pas assez d'argent pour acheter ça");
                    }
                    else
                    {
                    Console.WriteLine("Félicitation! Tu as maintenant Larry");
                    }

                } 
            esle if (weaponChoice == 2)
                {
                     float price = 15.0f
                    if (money < price)
                    {
                        Console.WriteLine("Tu n'as pas assez d'argent pour acheter ça");
                    }
                    else
                    {
                    Console.WriteLine("Félicitation! Tu as maintenant Oupi Goupi");
                    }
                }
             esle if (weaponChoice == 3)
                {
                   float price = 10.0f
                    if (money < price)
                    {
                        Console.WriteLine("Tu n'as pas assez d'argent pour acheter ça");
                    }
                    else
                    {
                    Console.WriteLine("Félicitation! Tu as maintenant L'électricien");
                    }
                }
             esle if (weaponChoice == 4)
                {
                    float price = 100.0f
                    if (money < price)
                    {
                        Console.WriteLine("Tu n'as pas assez d'argent pour acheter ça");
                    }
                    else
                    {
                    Console.WriteLine("Félicitation! Tu as maintenant Le Malicieux");
                    }
                }
            else 
            {
                Console.WriteLine("Entre un chiffre valide s'il te plait")
            }
            // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
            // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

            /*
             * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
             */
        }
    }
}
