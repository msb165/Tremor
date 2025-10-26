using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ShadowReaperBook:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(165);

			Item.damage = 39;
			Item.DamageType = DamageClass.Magic;
			Item.width = 26;
			Item.maxStack = 1;
			Item.height = 30;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.shoot = ModContent.ProjectileType<Projectiles.ShadowR>();
			Item.shootSpeed = 11.5f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.mana = 9;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Reaper");
			// Tooltip.SetDefault("Summons homing shadow creature");
		}

	}
}
