using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Bleachmod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
 
            
           if (npc.type == mod.NPCType("CobaltZombie"))
 
                {
					if (Main.rand.Next(2) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlueScrap"), Main.rand.Next(1, 3));
                   
 
                
         
      }
	}  
	      if (npc.type == mod.NPCType("MythrilZombie"))
 
                {
					if (Main.rand.Next(2) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreenScrap"), 2);   
	             
}
} 

          if (npc.type == mod.NPCType("AdamantiteZombie"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("RedScrap"), 3);   
	             
}
}         
         if (npc.type == mod.NPCType("Sandman"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.SandBlock, Main.rand.Next(20, 40));   
	             
}
}   
 if (npc.type == mod.NPCType("LivingAmbar"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Amber, 4);   
	             
}
}   
if (npc.type == mod.NPCType("LivingDiamond"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Diamond, 5);   
	             
}
}   
if (npc.type == mod.NPCType("LivingRuby"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Ruby, 3);   
	             
}
}   
if (npc.type == mod.NPCType("LivingEsmerald"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Emerald, 3);   
	             
}
}   
if (npc.type == mod.NPCType("LivingTopaz"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Topaz, 3);   
	             
}
}   
if (npc.type == mod.NPCType("LivingSapphire"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Sapphire, 3);   
	             
}
}   

if (npc.type == mod.NPCType("LivingAmethyst"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Amethyst, 3);   
	             
}
}   
         if (Main.player[Main.myPlayer].ZoneDesert) 
			 
		 { 
		   if (Main.rand.Next(60) == 0)
			   {
				   Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("DessertIdolItem"), 1);
        }
		}
		
		if (npc.type == NPCID.WalkingAntlion)
 
                {
					if (Main.rand.Next(30) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionEyeR"), 1);
                   
 
                
         
                }
	            if (Main.rand.Next(3) == 0)
					{
                
				    {
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionBody"), 1);    
	             
                    }
                    }				
	}  
	      if (npc.type == NPCID.FlyingAntlion)
 
                {
					if (Main.rand.Next(30) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionEyeG"), 1);    
	             
                }
                if (Main.rand.Next(18) == 0)
                
			    {
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionWings"), 1);
                }
				}
                
				if (Main.rand.Next(3) == 0)
					
                {
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionBodyS"), 1);    
	             
                }				
				}
	             
                }
				if (npc.type == NPCID.Antlion)
 
                {
					if (Main.rand.Next(30) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntlionEyeR"), 1);   
	             
                }
                }
				           if (npc.type == mod.NPCType("BoxCactus"))
 
                {
					if (Main.rand.Next(2) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, ItemID.Cactus, Main.rand.Next(10, 20));
                   
 
                
         
      }
	}
           if (npc.type == mod.NPCType("DarkEye"))
 
                {
					if (Main.rand.Next(9) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("SOD"), 1);
                   
 
                
         
      }
	}  
           if (npc.type == mod.NPCType("EvilBeing"))
 
                {
					if (Main.rand.Next(5) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("SOD"), Main.rand.Next(1, 3));
                   
 
                
         
      }
	}  
           if (npc.type == mod.NPCType("Lilsun"))
 
                {
					if (Main.rand.Next(3) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("IncandescentFlame"), Main.rand.Next(2, 5));
                   
 
                
         
      }
	}  	
		           if (npc.type == mod.NPCType("AshenElemental"))
 
                {
					if (Main.rand.Next(1) == 0)
                
				{
 
                Item.NewItem((int)npc.position.X,(int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwinkleAshes"), Main.rand.Next(1, 3));
                   
 
                
         
      }
	}  		
} 

          
}
}
 