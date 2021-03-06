using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetroidMod.Items.boss
{
	public class PhantoonSummon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ectoplasmic Locator");
			Tooltip.SetDefault("'Gives the location of hidden ectoplasmic beings...'\n" +  
			"Summons Phantoon at night");
		}
		public override void SetDefaults()
		{
			item.maxStack = 20;
			item.consumable = true;
			item.width = 12;
			item.height = 12;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 4;
			item.noMelee = true;
			item.value = 1000;
			item.rare = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 5);
			recipe.AddIngredient(ItemID.CursedFlame, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 5);
			recipe.AddIngredient(ItemID.Ichor, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("Phantoon")) && !Main.dayTime;
		}
		public override bool UseItem(Player player)
		{
			//Main.NewText("Huh, there seems to be a massive amount of ectoplasmic readings coming from... right above me!", 127, 255, 127);
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Phantoon"));
			Main.PlaySound(4,(int)player.position.X,(int)player.position.Y,10);
			return true;
		}
	}
}
