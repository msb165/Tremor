using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items.Crystal
{
	public class MushroomCrystal:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = 3;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mushroom Crystal");
			/* Tooltip.SetDefault("Summons Fungus Beetle\n" +
"Requires EoW or BoC to have been slain"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedBoss3 && !NPC.AnyNPCs(ModContent.NPCType<FungusBeetle>());
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 8);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddIngredient(ItemID.Sapphire, 12);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<FungusBeetle>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}
	}
}
