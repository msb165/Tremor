using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BounceTome:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(165);

			Item.damage = 20;
			Item.DamageType = DamageClass.Magic;
			Item.width = 26;
			Item.maxStack = 1;

			Item.height = 30;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.shoot = ModContent.ProjectileType<Projectiles.Bounce>();
			Item.shootSpeed = 19f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.mana = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bounce Tome");
			// Tooltip.SetDefault("Summons bouncy ball of gel");
		}

	}
}
