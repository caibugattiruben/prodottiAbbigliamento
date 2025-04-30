string pathleggo = "prodotti_abbigliamento.csv";
string pathscrivo = " prodotti_abbligliamento_aggiornati.csv";
StreamReader str=new StreamReader(pathleggo);
StreamWriter w=new StreamWriter(pathscrivo);
string dire="";
string riga = str.ReadLine();
riga = str.ReadLine();
w.WriteLine(riga);
while (riga != null) {
    dire = "";
    string[] riga2 = riga.Split(',');
    for(int j = 0; j < riga2.Length; j++)
    {
        if (j == riga2.Length - 1)
        {
            dire += riga2[j] ;
        }
        else
        {
            if (j == 3)
            {
                riga2[j] = riga2[j].Replace(".", ",");
                riga2[j] = (float.Parse(riga2[j])+float.Parse(riga2[j]) * 0.1).ToString();
                riga2[j]=(Math.Round(float.Parse(riga2[j]), 2)).ToString();
                riga2[j] = riga2[j].Replace(",",".");
            }
            else if (j == 2)
            {
                string tema = riga2[j];
                tema = tema.ToLower();
                string path = tema + ".csv";
                StreamWriter w1 = new StreamWriter(path,true);
                w1.WriteLine(riga);
                w1.Close();
            }
                dire += riga2[j] + ",";
        }       
    }
    w.WriteLine(dire);
    riga = str.ReadLine();
}
w.Close();