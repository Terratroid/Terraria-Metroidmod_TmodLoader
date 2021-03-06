using Terraria.ID;
using Terraria.ModLoader;

namespace MetroidMod.Items.missileaddons
{
	public class DiffusionMissileAddon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diffusion Missile");
			Tooltip.SetDefault(string.Format("[c/9696FF:Missile Launcher Addon]\n") +
			"Slot Type: Charge\n" +
			"Hold Click to charge\n" + 
			"~Charge shots create 4 large diffusion flares on impact that spiral outward, dealing damage to enemies\n" + 
			"~Charge shots and flares deal 3x damage\n" +
			"~Costs 5 missiles");
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
			item.createTile = mod.TileType("DiffusionMissileTile");*/
			MGlobalItem mItem = item.GetGlobalItem<MGlobalItem>();
			mItem.missileSlotType = 0;
			mItem.addonChargeDmg = 3f;
			mItem.addonMissileCost = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(null, "MissileExpansion");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}