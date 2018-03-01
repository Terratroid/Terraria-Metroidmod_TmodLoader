using System; 
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetroidMod.Items.addons.V2
{
	public class WaveBeamV2Addon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wave Beam V2");
			Tooltip.SetDefault(string.Format("[c/FF9696:Power Beam Addon V2]\n") +
				"Slot Type: Utility\n" +
				"Shots penetrate terrain by an extended depth\n" +
				string.Format("[c/78BE78:+75% damage]\n") +
				string.Format("[c/BE7878:+50% overheat use]"));
		}
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.maxStack = 1;
			item.value = 2500;
			item.rare = 4;
			/*item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WaveBeamV2Tile");*/
			MGlobalItem mItem = item.GetGlobalItem<MGlobalItem>(mod);
			mItem.addonSlotType = 2;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChoziteBar", 3);
            		recipe.AddIngredient(ItemID.DemoniteBar, 5);
            		recipe.AddIngredient(ItemID.Amethyst, 10);
            		recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChoziteBar", 3);
		    	recipe.AddIngredient(ItemID.CrimtaneBar, 5);
		    	recipe.AddIngredient(ItemID.Amethyst, 10);
		    	recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}*/
	}
}