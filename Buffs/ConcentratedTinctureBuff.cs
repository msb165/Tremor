using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ConcentratedTinctureBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Concentrated Tincture");
			Description.SetDefault("Increases life regeneration from healing flasks");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}