using RoR2;
using System.Collections.Generic;

namespace Songstress_Plugin
{
    class Utils
    {
        private static void Charm(CharacterBody self, CharacterBody charmer, int itemsToCopy)
        {
            //Can only charm non-boss, non-elite, non-players
            if (!self.isBoss && !self.isElite && !self.isPlayerControlled)
            {
                //Swap to the player team
                self.teamComponent.teamIndex = charmer.teamComponent.teamIndex;

                //Planned feature of a particle effect of hearts or something

                //Copy random items from the charmer's inventory
                List<ItemIndex> charmerItems = charmer.inventory.itemAcquisitionOrder;
                System.Random random = new System.Random();
                while(itemsToCopy > 0)
                {
                    self.inventory.GiveItem(charmerItems[random.Next(charmerItems.Count)]);
                }
            }
        }
    }
}
