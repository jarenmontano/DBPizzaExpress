/* PizzaForm.cs
 * Author: Jaren Montano
 * Date: 10/26/2023
 * Purpose: this is the gui that
 * adds the data to the order.cs
 */


using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class PizzaForm : Form
    {
        private Order newOrder;

        public PizzaForm()
        {
            InitializeComponent();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            newOrder = new Order();
            for (int i = 0; i < newOrder.pizzaSize.Length; i++)
            {
                CBxSize.Items.Add(newOrder.pizzaSize[i]);
            }
            for (int i = 0; i < newOrder.toppings.Length; i++)
            {
                CLBxToppings.Items.Add(newOrder.toppings[i]);
            }
            for (int i = 0; i < newOrder.otherItems.Length; i++)
            {
                CBxOtherItems.Items.Add(newOrder.otherItems[i]);
            }
            CBxSize.SelectedIndex = 0;
            CBxCrust.SelectedIndex = 0;
            CBxSauce.SelectedIndex = 0;
            CBxOtherItems.SelectedIndex = 0;


        }

        private void CBxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Size = CBxSize.Text;
        }

        private void CBxCrust_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Crust = CBxCrust.Text;
        }

        private void CBxSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Sauce = CBxSauce.Text;
        }

        private void CBxSpecialtyPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.SpecialtyPizzas = CBxSpecialtyPizzas.Text;
        }

        //this may need some work



        private void TBxSoda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newOrder.Sodas = decimal.Parse(TBxSoda.Text);
            }
            catch (FormatException)
            {
                TBxSoda.Text = "0";
                MessageBox.Show("Invalid input must be a Number!!");

            }

        }



        private void TBxWater_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newOrder.Waters = int.Parse(TBxWater.Text);
            }
            catch (FormatException)
            {
                TBxWater.Text = "0";
                MessageBox.Show("Invalid input must be a Number!!");

            }
        }

        private void TBxName_TextChanged(object sender, EventArgs e)
        {
            newOrder.Name = TBxName.Text;

        }

        private void TBxDeliveryAddress_TextChanged(object sender, EventArgs e)
        {
            newOrder.DeliveryAddress = TBxDeliveryAddress.Text;
        }

        private void TBxPhone_TextChanged(object sender, EventArgs e)
        {
            newOrder.Phone = TBxPhone.Text;

        }

        private void TBxEmail_TextChanged(object sender, EventArgs e)
        {
            newOrder.Email = TBxEmail.Text;
        }

        private void BTNxPlaceOrder_Click(object sender, EventArgs e)
        {
            GettingCheckedListBoxItems();
            //this is just incase they didn't hit the drop down because it 
            //was already pre selected
            newOrder.SpecialtyPizzas = CBxSpecialtyPizzas.Text;
            newOrder.Size = CBxSize.Text;
            newOrder.Crust = CBxCrust.Text;
            newOrder.Sauce = CBxSauce.Text;
            newOrder.OtherItemSelected = CBxOtherItems.Text;

            MessageBox.Show("Order\n\n" +
                newOrder.Size + "\n " +
                newOrder.Crust + "\n" +
                newOrder.Sauce + "\n" +
                newOrder.SpecialtyPizzas + "\n\n" +
                //this is where i need to put the toppings
                "Toppings " +
                newOrder.DetermineToppings() + "\n" +
                newOrder.DetermineToppingsCost().ToString("C2") + "\n\n" +

                 "Sodas: " + newOrder.Sodas + "\n" +
                "Waters: " + newOrder.Waters + "\n" +
                "Other Items Selected : " + newOrder.OtherItemSelected + " " +
                newOrder.OtherItemPriceSelected +
                "\n\n" +
                newOrder.Name + "," + newOrder.DeliveryAddress +
                "\n\n" + newOrder
                );


        }

        private void GettingCheckedListBoxItems()
        {

            for (int i = 0; i < CLBxToppings.CheckedIndices.Count; i++)
            {
                newOrder.Toppings[CLBxToppings.CheckedIndices[i]] = true;
            }

        }

        private void BTNxResetOrder_Click(object sender, EventArgs e)
        {

            //unchecking the checklistbox
            for (int i = 0; i < CLBxToppings.Items.Count; i++)
            {
                CLBxToppings.SetItemChecked(i, false);
            }

            //clearing main page
            CBxSize.SelectedIndex = 0;
            CBxCrust.SelectedIndex = 0;
            CBxSauce.SelectedIndex = 0;
            CBxSpecialtyPizzas.SelectedIndex = -1;
            CBxSpecialtyPizzas.Text = string.Empty;

            //DRinks page
            TBxWater.Text = "0";
            TBxSoda.Text = "0";

            //Other items
            CBxOtherItems.SelectedIndex = 0;
            CBxOtherItems.Text = string.Empty;



            //last page
            TBxName.Text = string.Empty;
            TBxEmail.Text = string.Empty;
            TBxDeliveryAddress.Text = string.Empty;
            TBxPhone.Text = string.Empty;

            newOrder = new Order();
        }

        private void CBxOtherItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.OtherItemSelected = CBxOtherItems.Text;
        }


    }
}