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

			item.width = 38;
			item.height = 32;
			item.maxStack = 20;

			item.rare = 11;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Paradox Potion");
			Tooltip.SetDefault("Restores 300 health");
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
			Main.player[Main.myPlayer].HealEffect(300);
			player.statLife += 300;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ParadoxElement>(), 2);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}
}
