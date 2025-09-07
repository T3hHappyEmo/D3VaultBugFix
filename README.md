# D3VaultBugFix
Fixes a save file for Danganronpa V3, forcing the Chapter 6 Vault open.

!!! SAVE FILE SHOULD BE IN RANTARO'S LAB AND NOT IN A DIALOGUE !!!
!!! USE AT YOUR OWN DISCRETION AND MAKE AN ADDITIONAL COPY OF YOUR SAVE FILE AS A BACKUP !!!
!!! THIS HAS ONLY BEEN PERSONALLY VERIFIED ON ONE DEVICE !!!

The script can be ran from the "D3VaultBugFix" file in the "PublishedApplication" folder.

I was able to complete the game after running this script on my own save file to bypass the stuck puzzle.
The vault still visually appeared to be closed BUT registered as open upon tapping it, allowing me to continue.

Script checks that the save was done in the correct location (Rantaro's Lab) to prevent accidentally selecting and writing to the wrong save file.
This should avoid overwriting any personal game progression. (Gametime / Coins / Presents / Freetime history should all NOT be affected)

You must have access to your save files for this to work.
The easiest way I found was to enable USB Debugging on the mobile device and navigating to "Android\data\jp.co.spike_chunsoft.DRV3\files".
The save file should look like "SAVE-DATA00", with the number indicating the save slot. 0 is autosave.

Due to file permissions on most mobile devices, it is recommended to copy the save file to a location on the computer running the script first.
Then after running the script to fix the save, copy the save file back.
You may need to delete the original file out before copying back, instead of "replacing" it.

If all else fails, an already fixed save file has been included in the "D3VaultBugFix" folder, but copying that over will overwrite personal progress in the save slot.
