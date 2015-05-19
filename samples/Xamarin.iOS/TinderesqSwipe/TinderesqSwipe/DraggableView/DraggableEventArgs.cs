using System;

namespace DraggableView
{
	public class DraggableEventArgs : EventArgs
	{
		public DraggableDirection Dragged { get; private set; }

		public DraggableEventArgs (DraggableDirection dragged)
		{
			Dragged = dragged;
		}
	}
}