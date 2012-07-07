using System.Linq;

namespace Nustache.Core
{
	public class TestBlock : Section
	{
		public TestBlock(string name, params Part[] parts)
			: base(name)
		{
			Load(parts);
		}

		public override void Render(RenderContext context)
		{
			if (context.GetValues(Name).Count() > 0)
			{
				base.Render(context);
			}
		}

		public override string ToString()
		{
			return string.Format("TestBlock(\"{0}\")", Name);
		}
	}
}