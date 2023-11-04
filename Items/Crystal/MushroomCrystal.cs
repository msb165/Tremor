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

			item.width = 24;
			item.height = 24;
			item.maxStack = 20;
			item.value = 100;
			item.rare = 3;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Crystal");
			Tooltip.SetDefault("Summons Fungus Beetle\n" +
"Requires EoW or BoC to have been slain");
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
