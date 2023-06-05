﻿namespace Microsoft.Maui
{
	public interface IMenuElement : IElement, IImageSourcePart, IText
	{
		/// <summary>
		/// Represents a shortcut key for a MenuItem.
		/// </summary>
#if NETSTANDARD2_1_OR_GREATER
		IAccelerator? Accelerator => null;
#else
		IAccelerator? Accelerator { get; }
#endif

		/// <summary>
		/// Gets a value indicating whether this View is enabled in the user interface. 
		/// </summary>
		bool IsEnabled { get; }

		/// <summary>
		/// Occurs when the IMenuElement is clicked.
		/// </summary>
		void Clicked();
	}
}
