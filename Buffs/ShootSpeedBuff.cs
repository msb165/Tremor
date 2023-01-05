using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ShootSpeedBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Sniper's Accuracy");
			Description.SetDefault("Increased projectile's speed twice");
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}
