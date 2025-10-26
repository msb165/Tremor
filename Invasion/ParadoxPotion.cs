using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{

	public class ParadoxPotion:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 32;
			Item.maxStack = 20;

			Item.rare = 11;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paradox Potion");
			// Tooltip.SetDefault("Restores 300 health");
		}

		public override bool CanUseItem(Player player)
		{
			if (player.FindBuffIndex(BuffID.PotionSickness) == -1)
			{
				player.AddBuff(BuffID.PotionSickness, 3600, true);
			}
			else
			{
				return false;
			}
			return true;
		}

		public override bool? UseItem(Player player)
		{
			SoundEngine.PlaySound(SoundID.Item3, player.position);
			Main.LocalPlayer.HealEffect(300);
			player.statLife += 300;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParadoxElement>(), 2);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}
}
