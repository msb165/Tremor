using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class NightmareHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 24;
			Item.width = 26;
			Item.height = 32;
			Item.value = 25000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Helmet");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<NightmareBreastplate>() && legs.type == ModContent.ItemType<NightmarePants>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Minor improvements to all stats when health below 50";
			if (player.statLife < 50)
			{
				player.AddBuff(ModContent.BuffType<Buffs.ConcentrationofFear>(), 2);
			}
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
