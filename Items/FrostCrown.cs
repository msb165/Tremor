using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class FrostCrown:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 38;
			Item.maxStack = 20;

			Item.rare = 6;
			Item.value = 25000;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Crown");
			/* Tooltip.SetDefault("Summons the Frost King\n" +
"Requires any mech. boss to have been slan and the snow or glacier biome"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedMechBossAny && !NPC.AnyNPCs(ModContent.NPCType<FrostKing>()) && player.ZoneSnow;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<FrostKing>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldCrown, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(ItemID.SoulofNight, 18);
			recipe.AddIngredient(ItemID.SoulofLight, 18);
			recipe.AddIngredient(ModContent.ItemType<FrostCore>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
