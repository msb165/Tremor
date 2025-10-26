using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LinearBurst:TremorModItem
	{
		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.nitro)
				{
					return false;
				}
			}
			return true;
		}

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 300000;
			Item.rare = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Linear Burst");
			// Tooltip.SetDefault("Achemical flasks leave five death flames");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ExplosivePowder, 15);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedBurst>(), 1);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.LinearBurstBuff>(), 2);
			modPlayer.nitro = true;
		}
	}
}
