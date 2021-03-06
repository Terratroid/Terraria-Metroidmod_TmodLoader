using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MetroidMod.Items.vanity
{
	[AutoloadEquip(EquipType.Body)]
	public class VanityDreadSuitBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("'Dread' Suit Breastplate");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 2;
			item.vanity = true;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return (head.type == mod.ItemType("VanityDreadSuitHelmet") && body.type == mod.ItemType("VanityDreadSuitBreastplate") && legs.type == mod.ItemType("VanityDreadSuitGreaves"));
		}
		public override void UpdateVanitySet(Player P)
		{
			MPlayer mp = P.GetModPlayer<MPlayer>();
			mp.isPowerSuit = true;
			mp.visorGlowColor = new Color(0, 248, 112);
			if(P.velocity.Y != 0f && ((P.controlRight && P.direction == 1) || (P.controlLeft && P.direction == -1) || mp.SMoveEffect > 0) && mp.shineDirection == 0 && !mp.shineActive && !mp.ballstate)
			{
				mp.jet = true;
			}
			else if(mp.shineDirection == 0 || mp.shineDirection == 5)
			{
				mp.jet = false;
			}
		}
	}
	[AutoloadEquip(EquipType.Legs)]
	public class VanityDreadSuitGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("'Dread' Suit Greaves");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 2;
			item.vanity = true;
		}
	}
	[AutoloadEquip(EquipType.Head)]
	public class VanityDreadSuitHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("'Dread' Suit Helmet");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 2;
			item.vanity = true;
		}
	}
}