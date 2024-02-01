using System.Collections.Generic;


namespace ZM
{
	//public interface IZM
	//{
	//	int Count { get; }

	//	void Add(IZM zm);
	//	void Remove(IZM zm);
	//}


	/// <summary>
	/// 
	/// </summary>
	public class ZM
	{
		private ZM m_Parent;
		private List<ZM> m_Children;

		public int Count
		{
			get
			{
				return m_Children.Count;
			}
		}

		public ZM()
		{
			m_Parent = null;
			m_Children = new List<ZM>();
		}

		public void SetParent(ZM model)
		{
			var previousParent = m_Parent;
			var nextParent = model;

			if (previousParent != null)
			{
				previousParent.RemoveChild(this);
				m_Parent = null;
			}

			if (nextParent != null)
			{
				nextParent.AddChild(this);
				m_Parent = nextParent;
			}
		}

		public void AddChild(ZM model)
		{
			m_Children.Add(model);
		}

		public void RemoveChild(ZM model)
		{
			m_Children.Remove(model);
		}
	}
}