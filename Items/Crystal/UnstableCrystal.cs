using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crystal
{
	class UnstableCrystal:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 44;
			Item.height = 48;

			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 4;
			Item.knockBack = 0;
			Item.shoot = 1;
			Item.value = 10000;
			Item.rare = 1;
			Item.consumable = true;
			Item.maxStack = 999;
			Item.UseSound = SoundID.Item6;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Unstable Crystal");
			/* Tooltip.SetDefault("Teleports you to a random location\n" +
"'Be careful! It can take you to a very dangerous place!'"); */
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			player.TeleportationPotion();
			return false;
		}
	}
}
