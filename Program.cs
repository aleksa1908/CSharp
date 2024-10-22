using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string vrednost = "L23#08:05#08:25#22:40#23:55#L24#08:06#08:17#22:35#23:59#L906#08:02#08:14#23:05#23:15#23:44#23:59#";
        string unos = "L906";
        string pocetno_vreme_unos = "08:13";
        string krajnje_vreme_unos = "23:16";
        
        string[] pocetno_vreme_unos_split = pocetno_vreme_unos.Split(':');
        string[] krajnje_vreme_unos_split = krajnje_vreme_unos.Split(':');

        int pv_vreme_unos = int.Parse(pocetno_vreme_unos_split[0]) * 60 + int.Parse(pocetno_vreme_unos_split[1]);
        int kv_vreme_unos = int.Parse(krajnje_vreme_unos_split[0]) * 60 + int.Parse(krajnje_vreme_unos_split[1]);
        
        string[] vrednost_split1 = vrednost.Split('L');
        int counter = 0;

        for(int i = 0; i < vrednost_split1.Length; i++){
            string[] curr = vrednost_split1[i].Split('#'); 
            if('L'+curr[0] == unos){
                break;
            } 
            else 
            {
                counter++;
            }
        }
        string[] current = vrednost_split1[counter].Split("#");
        System.Console.WriteLine('L'+current[0]);

        for(int i = 1; i < current.Length-1; i++){
            string[] tv = current[i].Split(':');

            int tvc = int.Parse(tv[0]) * 60 + int.Parse(tv[1]);

            if(pv_vreme_unos <= tvc && kv_vreme_unos >= tvc){
                System.Console.WriteLine(current[i]);
            }
        }
    }
}