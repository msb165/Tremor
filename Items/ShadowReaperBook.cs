using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ShadowReaperBook:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(165);

			item.damage = 39;
			item.DamageType = DamageClass.Magic;
			item.width = 26;
			item.maxStack = 1;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.shoot = ModContent.ProjectileType<Projectiles.ShadowR>();
			item.shootSpeed = 11.5f;
			item.useStyle = 5;
			item.knockBack = 4;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.mana = 9;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Reaper");
			Tooltip.SetDefault("Summons homing shadow creature");
		}

	}
}
