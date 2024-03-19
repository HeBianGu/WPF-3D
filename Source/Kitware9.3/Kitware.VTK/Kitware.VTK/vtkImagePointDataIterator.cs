using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImagePointDataIterator
	/// </summary>
	/// <remarks>
	///    iterate over point data in an image.
	///
	/// This class will iterate over an image.  For each position, it will
	/// provide the (I,J,K) index, the point Id, and if a stencil is supplied,
	/// it will report whether the point is inside or outside of the stencil.
	/// &lt;p&gt;For efficiency, this class iterates over spans rather than points.
	/// Each span is one image row or partial row, defined by a start position
	/// and a size.  Within a span, only the X index and the point Id will change.
	/// The vtkImagePointDataIterator and related iterators are the preferred
	/// method of iterating over image data within the VTK image filters.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageData vtkImageStencilData vtkImageProgressIterator
	/// </seealso>
	// Token: 0x0200085E RID: 2142
	public class vtkImagePointDataIterator : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601635A RID: 90970 RVA: 0x001F43D5 File Offset: 0x001F25D5
		static vtkImagePointDataIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePointDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePointDataIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601635B RID: 90971 RVA: 0x001F43FD File Offset: 0x001F25FD
		public vtkImagePointDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601635C RID: 90972 RVA: 0x001F440B File Offset: 0x001F260B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601635D RID: 90973
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePointDataIterator_GetId_01(HandleRef pThis);

		/// <summary>
		/// Get the point Id at the beginning of the current span.
		/// </summary>
		// Token: 0x0601635E RID: 90974 RVA: 0x001F4418 File Offset: 0x001F2618
		public long GetId()
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_GetId_01(base.GetCppThis());
		}

		// Token: 0x0601635F RID: 90975
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointDataIterator_GetIndex_02(HandleRef pThis, IntPtr result);

		/// <summary>
		/// Get the index at the beginning of the current span.
		/// </summary>
		// Token: 0x06016360 RID: 90976 RVA: 0x001F4437 File Offset: 0x001F2637
		public void GetIndex(IntPtr result)
		{
			vtkImagePointDataIterator.vtkImagePointDataIterator_GetIndex_02(base.GetCppThis(), result);
		}

		// Token: 0x06016361 RID: 90977
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePointDataIterator_GetIndex_03(HandleRef pThis);

		/// <summary>
		/// Get the index at the beginning of the current span.
		/// </summary>
		// Token: 0x06016362 RID: 90978 RVA: 0x001F4448 File Offset: 0x001F2648
		public int[] GetIndex()
		{
			IntPtr intPtr = vtkImagePointDataIterator.vtkImagePointDataIterator_GetIndex_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016363 RID: 90979
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePointDataIterator_GetVoidPointer_04(HandleRef image, long i, IntPtr pixelIncrement);

		/// <summary>
		/// Get a void pointer and pixel increment for the given point Id.
		/// The pixel increment is the number of scalar components.
		/// </summary>
		// Token: 0x06016364 RID: 90980 RVA: 0x001F4490 File Offset: 0x001F2690
		public static IntPtr GetVoidPointer(vtkImageData image, long i, IntPtr pixelIncrement)
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_GetVoidPointer_04((image == null) ? default(HandleRef) : image.GetCppThis(), i, pixelIncrement);
		}

		// Token: 0x06016365 RID: 90981
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePointDataIterator_GetVoidPointer_05(HandleRef array, long i, IntPtr pixelIncrement);

		/// <summary>
		/// Get a void pointer and pixel increment for the given point Id.
		/// The array must be the same size as the image.  The pixel increment
		/// that is returned will be the number of components for the array.
		/// </summary>
		// Token: 0x06016366 RID: 90982 RVA: 0x001F44C0 File Offset: 0x001F26C0
		public static IntPtr GetVoidPointer(vtkDataArray array, long i, IntPtr pixelIncrement)
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_GetVoidPointer_05((array == null) ? default(HandleRef) : array.GetCppThis(), i, pixelIncrement);
		}

		// Token: 0x06016367 RID: 90983
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointDataIterator_Initialize_06(HandleRef pThis, HandleRef image, IntPtr extent, HandleRef stencil, HandleRef algorithm, int threadId);

		/// <summary>
		/// Initialize an iterator.  See constructor for more details.
		/// </summary>
		// Token: 0x06016368 RID: 90984 RVA: 0x001F44F0 File Offset: 0x001F26F0
		public void Initialize(vtkImageData image, IntPtr extent, vtkImageStencilData stencil, vtkAlgorithm algorithm, int threadId)
		{
			vtkImagePointDataIterator.vtkImagePointDataIterator_Initialize_06(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), extent, (stencil == null) ? default(HandleRef) : stencil.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis(), threadId);
		}

		// Token: 0x06016369 RID: 90985
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImagePointDataIterator_IsAtEnd_07(HandleRef pThis);

		/// <summary>
		/// Test if the iterator has completed iterating over the entire extent.
		/// </summary>
		// Token: 0x0601636A RID: 90986 RVA: 0x001F4550 File Offset: 0x001F2750
		public bool IsAtEnd()
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_IsAtEnd_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601636B RID: 90987
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImagePointDataIterator_IsInStencil_08(HandleRef pThis);

		/// <summary>
		/// Check if the iterator is within the region specified by the stencil.
		/// This is updated when NextSpan() is called.
		/// </summary>
		// Token: 0x0601636C RID: 90988 RVA: 0x001F4578 File Offset: 0x001F2778
		public bool IsInStencil()
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_IsInStencil_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601636D RID: 90989
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointDataIterator_NextSpan_09(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the next span.
		/// A span is a contiguous region of the image over which nothing but
		/// the point Id and the X index changes.
		/// </summary>
		// Token: 0x0601636E RID: 90990 RVA: 0x001F459E File Offset: 0x001F279E
		public void NextSpan()
		{
			vtkImagePointDataIterator.vtkImagePointDataIterator_NextSpan_09(base.GetCppThis());
		}

		// Token: 0x0601636F RID: 90991
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePointDataIterator_SpanEndId_10(HandleRef pThis);

		/// <summary>
		/// Get the end of the span.
		/// </summary>
		// Token: 0x06016370 RID: 90992 RVA: 0x001F45B0 File Offset: 0x001F27B0
		public long SpanEndId()
		{
			return vtkImagePointDataIterator.vtkImagePointDataIterator_SpanEndId_10(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001910 RID: 6416
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePointDataIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001911 RID: 6417
		public new static readonly string MRClassNameKey = "class vtkImagePointDataIterator";
	}
}
