using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CDrinkFactory
{
    List<CDrink> listDrinks = new List<CDrink>();

    public CDrinkFactory() { }

    public CDrinkFactory(string pathOfFile)
    {
        loadData(pathOfFile);
    }

    private void loadData(string pathOfFile)
    {
        StreamReader reader = new StreamReader(pathOfFile, Encoding.Default);

        int intDrinkId = 0;
        string strKind = "分類1";

        while (reader.Peek() > 0)
        {
            string textLine = reader.ReadLine();


            if (textLine.StartsWith("+"))   //取得分類
                strKind = textLine.Substring(1, textLine.Length - 1);

            if (textLine.StartsWith("-"))   //取得名稱及內容
            {
                string[] textSplit = textLine.Substring(1, textLine.Length - 1).Split(' ', 'M', 'L');
                CDrink drink = new CDrink();
                drink.id = intDrinkId++;
                drink.kind = strKind;
                drink.name = textSplit[0];
                drink.priceMiddle = Convert.ToInt32(textSplit[2]);
                drink.priceLarge = Convert.ToInt32(textSplit[4]);
                listDrinks.Add(drink);
            }
        }

        reader.Close();
    }

    public CDrink[] getAll()
    {
        return listDrinks.ToArray();
    }
}