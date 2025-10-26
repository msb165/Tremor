using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items.Doom
{
	public class DoomKey:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 30;
			Item.maxStack = 1;

			Item.rare = 4;
			Item.maxStack = 20;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.UseSound = SoundID.Item44;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Doom Key");
			// Tooltip.SetDefault("Summons the Skeletron");
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && !NPC.AnyNPCs(35);
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, 35);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CursedSoul>(), 1);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}

	}
}
