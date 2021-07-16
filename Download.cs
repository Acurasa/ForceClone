  //Copies the avatar download link of the avatar you're using
        public static void CopyAvatarURL(WhosAffected affectedUser)
        {
            if (affectedUser == WhosAffected.Self)
            {
                var playerAvatarURL = Player.prop_Player_0.prop_ApiAvatar_0.unityPackageUrl ?? Player.prop_Player_0.prop_ApiAvatar_0.assetUrl;
 
                System.Windows.Forms.Clipboard.SetText(playerAvatarURL);
            }
 
            else if (affectedUser == WhosAffected.Selected)
            {
                var selectedPlayer = PlayerCheck.GetSelectedPlayer(QuickMenu.prop_QuickMenu_0.prop_APIUser_0.id);
                var playerAvatarURL = selectedPlayer.prop_ApiAvatar_0.unityPackageUrl ?? selectedPlayer.prop_ApiAvatar_0.assetUrl;
                System.Windows.Forms.Clipboard.SetText(playerAvatarURL);
            }
        }
