namespace Forest2000Menu.Mods {
  public class Safety {
    public static void antireport()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;

                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                if (D1 < threshold || D2 < threshold)
                                {
                                    if (PhotonNetwork.CurrentRoom.IsVisible)
                                    {
                                        PhotonNetwork.Disconnect();
                                        RPCProtection();
                                        NotifiLib.SendNotification("<color=grey>[</color><color=red>antireport flagged</color><color=grey>]</color> " + GetPlayerFromVRRig(vrrig).NickName + " attempted to report");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { } // Not connected
        }

    public static void AntiModerator()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (!vrrig.isOfflineVRRig && vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK") || vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD"))
                {
                    PhotonNetwork.Disconnect();
                    NotifiLib.SendNotification("<color=grey>[</color><color=red>mod join</color><color=grey>]</color> Moderator joined. name: " + player.NickName + " pid: " + player.UserId);
                }
            }
        }
  }
}
