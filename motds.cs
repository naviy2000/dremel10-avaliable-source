using System;
using GorillaLocomotion;
using UnityEngine;
using Forest2000Menu.PluginInfo;

namespace Forest2000Menu.Misc {
    public class MOTDBoard {
        public static void SetBoards() {
            TextMeshPro motdTC = motd.GetComponent<TextMeshPro>();

            if (!udTMP.Contains(motdTC))
            {
                udTMP.Add(motdTC);
            }

            motdTC.richText = true;
            motdTC.fontSize = 70;
            motdTC.text = "<color=blue>FOREST2000'S MENU V" + PluginInfo.Version + "</color>";

            TextMeshPro motdTextB = motdText.GetComponent<TextMeshPro>();
            
            if (!udTMP.Contains(motdTextB))
            {
                udTMP.Add(motdTextB);
            }
            motdTextB.richText = true;
            motdTextB.fontSize = 100;
            motdTextB.color = Color.blue;

            int fullModAmount = -1;

            if (fullModAmount < 0)
            {
                fullModAmount = 0;
                foreach (ButtonInfo[] buttons in Buttons.buttons)
                {
                    fullModAmount += buttons.Length;
                }
            }

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://github.com/foresst2000/menu-status-http/raw/refs/heads/master/status.txt");
            BufferedStream bufferedStream = new BufferedStream(stream, bufferSize);
            StreamReader reader = new StreamReader(bufferedStream);

            WebClient client2 = new WebClient();
            Stream stream = client2.OpenRead("https://github.com/foresst2000/menu-status-http/raw/refs/heads/master/version.txt");
            BufferedStream bufferedStream2 = new BufferedStream(stream, bufferSize);
            StreamReader reader2 = new StreamReader(bufferedStream);

            motdTextB.text = "<color=gray>MODS:</color> <color=blue>" + fullModAmount + "\n<color=gray>STATUS: </color> <color=blue>" + reader.ReadLine() + "</color>\n<color=gray>VERSION: " + reader2.ReadLine(); + "</color>;
        }
    }
}
