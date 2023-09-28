//Clement VABRE CIEL1

using System;
using System.Windows;
using System.Windows.Controls;

namespace Vabre_Clement_Calculatrice
{
    public partial class MainWindow : Window
    {
        //definition des variables
        double N1 = 0;
        double N2 = 0;
        char operation = ' ';
        double result = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

         // Fonction pour afficher un chiffre ou opérateur sur l'écran
        public void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }


        // Fonction appelée lorsque l'utilisateur clique sur un bouton numérique
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            String btnContent = btn.Content.ToString();
            display (btnContent);

        }

        // Fonction appelée lorsque l'utilisateur clique sur un bouton d'opération

        private void BTN_Click_Operation(object sender, RoutedEventArgs e)
        {
            Button btn_ope = sender as Button;
            if (TB_Display.Text != "")
            {
                N1 = double.Parse(TB_Display.Text);
                operation = btn_ope.Content.ToString()[0]; // Mettez à jour la variable d'opération
            }
            TB_Display.Text = "0";
        }

        // Fonction appelée pour pi
        private void BTN_pi_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text != "") N1 = double.Parse(TB_Display.Text);
            operation = 'p';
            TB_Display.Text = "0";
        }




        // Fonction appelée lorsque l'utilisateur clique sur le bouton "CLR" (effacer)
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            N1 = 0;
            N2 = 0;
            operation = ' ';
            result = 0;
            TB_Display.Text = "0";
        }

        // Fonction appelée lorsque l'utilisateur clique sur le bouton "=" (égal)
        private void BTN_egal_Click(object sender, RoutedEventArgs e)
        {
            N2 = double.Parse(TB_Display.Text);

            // Calcule différentes opérations en fonction de l'opération choisie
                  switch (operation)
                {
                //operation +
                    case '+':
                        result = N1 + N2;
                        TB_Display.Text = result.ToString();
                        break;

                    //racine
                    case '√':
                        double sqrtResult = Math.Sqrt(N1);
                        TB_Display.Text = sqrtResult.ToString();
                        break;

                    //moins
                    case '-':
                        result = N1 - N2;
                        TB_Display.Text = result.ToString();
                        break;

                    //fois
                    case '*':
                        result = N1 * N2;
                        TB_Display.Text = result.ToString();
                        break;

                    //carré
                    case 'x':
                    result = N1 * N1;
                    TB_Display.Text = result.ToString();
                         break;

                    //pi
                    case 'p':
                    result = N1 * Math.PI;
                    TB_Display.Text = result.ToString();
                         break;

                    //tan
                    case 't':
                    result = Math.Tan(N1);
                    TB_Display.Text = result.ToString();
                        break;

                    //sin
                    case 's':
                    result = Math.Sin(N1);
                    TB_Display.Text = result.ToString();
                     break;

                    //cos
                    case 'c':
                    result = Math.Cos(N1);
                    TB_Display.Text = result.ToString();
                     break;

                    //exp
                    case 'e':
                    result = Math.Exp(N1);
                    TB_Display.Text = result.ToString();
                     break;

                    //ln
                    case 'l':
                    result = Math.Log(N1);
                    TB_Display.Text = result.ToString();
                     break;


                case '/':
                        if (N2 != 0)
                        {
                            result = N1 / N2;
                            TB_Display.Text = result.ToString();
                        }
                        else
                        {
                            TB_Display.Text = "Erreur de division par zéro";
                        }
                        break;

                }

           
        }
    }
}
