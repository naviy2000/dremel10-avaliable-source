namespace Dremel.Misc {
    public class MOTDBoard {
        public static void SetBoards() {
            TextMeshPro motdTC = motd.GetComponent<TextMeshPro>();

            if (!udTMP.Contains(motdTC))
            {
                udTMP.Add(motdTC);
            }

            motdTC.richText = true;
            motdTC.fontSize = 70;
            motdTC.text = "<color=blue>Dremel Ultimate</color>";

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

            motdTextB.text = "<color=gray>There are currently</color> <color=blue>" + fullModAmount + "</color><color=gray> mods.</color>"
        }
    }
}