using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Doom;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class EmperorCrown:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 28;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = 11;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Emperor Crown");
			/* Tooltip.SetDefault("Summons the Dark Emperor\n" +
"Requires Tremode"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedMoonlord && !NPC.AnyNPCs(ModContent.NPCType<TheDarkEmperor>());
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SlimeCrown, 1);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 9);
			recipe.AddIngredient(ModContent.ItemType<DarkMass>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<TheDarkEmperor>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}
	}
}
